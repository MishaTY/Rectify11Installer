using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    class ResourceAccess
    {
        public static byte[] GetResource(IntPtr moduleHandle, string type, string name)
        {
            IntPtr resHandle = Win32Api.FindResource(moduleHandle, name, type);
            if (resHandle == IntPtr.Zero)
                return null;

            IntPtr dataHandle = Win32Api.LoadResource(moduleHandle, resHandle);
            IntPtr data = Win32Api.LockResource(dataHandle);
            uint size = Win32Api.SizeofResource(moduleHandle, resHandle);

            byte[] managedArray = new byte[size];
            Marshal.Copy(data, managedArray, 0, (int)size);
            return managedArray;
        }

        public static byte[] GetResource(IntPtr moduleHandle, string type, uint id)
        {
            IntPtr resHandle = Win32Api.FindResource(moduleHandle, id, type);
            if (resHandle == IntPtr.Zero)
                return null;

            IntPtr dataHandle = Win32Api.LoadResource(moduleHandle, resHandle);
            IntPtr data = Win32Api.LockResource(dataHandle);
            uint size = Win32Api.SizeofResource(moduleHandle, resHandle);

            byte[] managedArray = new byte[size];
            Marshal.Copy(data, managedArray, 0, (int)size);
            return managedArray;
        }


        public static ushort GetFirstLanguageId(IntPtr moduleHandle, string type, uint name)
        {
            return GetFirstLanguageId(moduleHandle, type, "#" + name);
        }

        public static ushort GetFirstLanguageId(IntPtr moduleHandle, string type, string name)
        {
            var list = GetAllLanguageIds(moduleHandle, type, name, Win32Api.EnumResourceFlags.RESOURCE_ENUM_LN);
            if (list.Count > 0)
                return list.First();
            else return 0xFFFF;
        }


        public static List<ushort> GetAllLanguageIds(IntPtr moduleHandle, string type, uint name, Win32Api.EnumResourceFlags flags)
        {
            return GetAllLanguageIds(moduleHandle, type, "#" + name, flags);
        }

        public static List<ushort> GetAllLanguageIds(IntPtr moduleHandle, string type, string name, Win32Api.EnumResourceFlags flags)
        {
            var ctx = new EnumLanguagesCallbackContext();
            Win32Api.EnumResourceLanguagesEx(moduleHandle, 
                type, 
                name,
                ctx.Callback,
                IntPtr.Zero,
                flags, 
                0);

            return ctx.langIds;
        }

        class EnumLanguagesCallbackContext
        {
            public List<ushort> langIds = new List<ushort>();

            public bool Callback(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, ushort wIDLanguage, IntPtr lParam)
            {
                langIds.Add(wIDLanguage);
                return true;
            }
        }

        public class StringTable
        {
            const int BUCKET_SIZE = 16;

            private static int BUCKETED_TO_FLAT(int bucket, int index)
            {
                return (bucket - 1) * BUCKET_SIZE + index;
            }

            private static void FLAT_TO_BUCKETED(int flatid, ref int bucket, ref int index)
            {
                bucket = (flatid / BUCKET_SIZE) + 1;
                index = flatid % BUCKET_SIZE;
            }

            private static void BucketAppendString(BinaryWriter bw, string str)
            {
                bw.Write((UInt16)str.Length);
                if (str.Length > 0)
                {
                    // ToCharArray() stops BinaryWriter from length-prefixing
                    bw.Write(str.ToCharArray());
                }
            }

            private static void BucketAppendEmpty(BinaryWriter bw, int numEntries)
            {
                for (int i = 0; i < numEntries; ++i)
                {
                    bw.Write((UInt16)0);
                }
            }

            public static void Load(IntPtr moduleHandle, ushort langId, Dictionary<int, string> stringTable)
            {
                var ctx = new ReadStringsCallbackContext();
                ctx.langId = langId;
                ctx.stringTable = stringTable;

                Win32Api.EnumResourceNamesEx(moduleHandle,
                    Win32Api.RT_STRING,
                    ctx.Callback,
                    IntPtr.Zero,
                    Win32Api.EnumResourceFlags.RESOURCE_ENUM_LN |
                    Win32Api.EnumResourceFlags.RESOURCE_ENUM_MUI,
                    langId);
            }

            public static bool Update(IntPtr moduleHandle, IntPtr updateHandle, Dictionary<int, string> table, ushort langId = 0)
            {
                MemoryStream ms = new MemoryStream();
                BinaryWriter bw = new BinaryWriter(ms, Encoding.Unicode);

                int previousBucketIndex = -1;
                int currentBucketIndex = 0;

                int currentBucket = 0;
                int previousBucket = (table.Count > 0) ? (table.First().Key / 16) + 1 : 0;

                List<int> bucketsTouched = new List<int>();

                foreach (var item in table)
                {
                    // get current bucket
                    FLAT_TO_BUCKETED(item.Key, ref currentBucket, ref currentBucketIndex);

                    // write changes once a bucket is complete
                    if (currentBucket != previousBucket)
                    {
                        // fill in empty entries at the end if required
                        int toFill1 = (BUCKET_SIZE - 1) - previousBucketIndex;
                        BucketAppendEmpty(bw, toFill1);

                        // commit bucket
                        if (Win32Api.UpdateResource(updateHandle
                            , Win32Api.RT_STRING
                            , (uint)previousBucket
                            , langId
                            , ms.ToArray()
                            , (uint)ms.Length) == false)
                        {
                            int err = Marshal.GetLastWin32Error();
                            throw new Exception($"Updating string resource with id '{previousBucket}' failed with error '{err}'!");
                        }

                        // remember bucket
                        bucketsTouched.Add(previousBucket);

                        // reset bucket buffer
                        previousBucket = currentBucket;
                        ms = new MemoryStream();
                        bw = new BinaryWriter(ms, Encoding.Unicode);

                        previousBucketIndex = -1;
                    }

                    // fill in empty entries as required
                    int toFill = currentBucketIndex - previousBucketIndex - 1;
                    BucketAppendEmpty(bw, toFill);
                    BucketAppendString(bw, item.Value);

                    previousBucketIndex = currentBucketIndex;
                }

                if(previousBucketIndex != -1) // bucket needs filling
                {
                    // fill in empty entries at the end if required
                    int toFill2 = (BUCKET_SIZE - 1) - previousBucketIndex;
                    BucketAppendEmpty(bw, toFill2);

                    // commit bucket
                    if (Win32Api.UpdateResource(updateHandle
                        , Win32Api.RT_STRING
                        , (uint)previousBucket
                        , langId
                        , ms.ToArray()
                        , (uint)ms.Length) == false)
                    {
                        int err = Marshal.GetLastWin32Error();
                        throw new Exception($"Updating string resource with id '{previousBucket}' failed with error '{err}'!");
                    }

                    // remember bucket
                    bucketsTouched.Add(previousBucket);
                }

                var ctx = new DeleteStringsCallbackContext();
                ctx.stringTable = table;
                ctx.bucketsUsed = bucketsTouched;
                ctx.updateHandle = updateHandle;

                // remove all buckets we haven't touched
                Win32Api.EnumResourceNamesEx(moduleHandle, 
                    Win32Api.RT_STRING,
                    ctx.Callback, 
                    IntPtr.Zero, 
                    Win32Api.EnumResourceFlags.RESOURCE_ENUM_LN | 
                    Win32Api.EnumResourceFlags.RESOURCE_ENUM_MUI,
                    Win32Api.LANG_NEUTRAL);

                return true;
            }

            class ReadStringsCallbackContext
            {
                public Dictionary<int, string> stringTable = new Dictionary<int, string>();
                public ushort langId = 0;

                public bool Callback(IntPtr hModule, IntPtr lpType, IntPtr lpName, IntPtr lParam)
                {
                    var resHandle = Win32Api.FindResourceEx(hModule, Win32Api.RT_STRING, (uint)lpName.ToInt32(), langId);
                    if (resHandle != IntPtr.Zero)
                    {
                        var dataHandle = Win32Api.LoadResource(hModule, resHandle);
                        if (dataHandle != IntPtr.Zero)
                        {
                            var dataPtr = Win32Api.LockResource(dataHandle);
                            if (dataPtr != IntPtr.Zero)
                            {
                                for (int i = 0; i < BUCKET_SIZE; ++i)
                                {
                                    int len = Marshal.ReadInt16(dataPtr);
                                    dataPtr = new IntPtr(dataPtr.ToInt64() + 2);

                                    int id = BUCKETED_TO_FLAT(lpName.ToInt32(), i);

                                    if (len > 0)
                                    {
                                        string str = Marshal.PtrToStringUni(dataPtr, len);
                                        stringTable[id] = str;
                                    }

                                    dataPtr = new IntPtr(dataPtr.ToInt64() + (len * 2));
                                }
                            }
                        }
                    }
                    return true;
                }
            }

            class DeleteStringsCallbackContext
            {
                public Dictionary<int, string> stringTable = new Dictionary<int, string>();
                public List<int> bucketsUsed = new List<int>();
                public IntPtr updateHandle = IntPtr.Zero;

                public bool Callback(IntPtr hModule, IntPtr lpType, IntPtr lpName, IntPtr lParam)
                {
                    int bucket = lpName.ToInt32();

                    if (!bucketsUsed.Contains(bucket))
                    {
                        if (Win32Api.UpdateResource(updateHandle,
                            Win32Api.RT_STRING,
                            (uint)bucket,
                            Win32Api.LANG_NEUTRAL,
                            null,
                            0) == false)
                        {
                            // should not happend
                            throw new Exception("DeleteStringsCallbackContext");
                        }
                    }

                    return true;
                }
            }
        }
    }

    
}