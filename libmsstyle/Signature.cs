using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    internal class Signature
    {
        static int HEADER_SIZE = 16;
        static uint SIGNATURE_MAGIC = 0x84692426;

        UInt32 magic;
        UInt32 sigSize;
        UInt32 fileSize;
        UInt32 const2;
        byte[] data;

        public static Signature ReadSignature(FileStream fs)
        {
            using(var br = new BinaryReader(fs, Encoding.UTF8, true))
            {
                Signature sig = new Signature();

                long size = fs.Length;
                fs.Seek(size - HEADER_SIZE, SeekOrigin.Begin);
                
                sig.magic = (UInt32)br.ReadInt32();
                sig.sigSize = (UInt32)br.ReadInt32();
                sig.fileSize = (UInt32)br.ReadInt32();
                sig.const2 = (UInt32)br.ReadInt32();

                if (sig.magic != SIGNATURE_MAGIC)
                    return null;
                //if (sig.fileSize != size) // i have seen a file where this isn't true..what to do?
                //    return null;
                if (sig.sigSize > UInt16.MaxValue) // probably garbage
                    return null;

                fs.Seek(size - HEADER_SIZE - sig.sigSize, SeekOrigin.Begin);
                sig.data = br.ReadBytes((int)sig.sigSize);

                return sig;
            }
        }

        public static bool AppendSignature(string file, byte[] signature)
        {
            using(var fs = File.Open(file, FileMode.Open))
            using (var bw = new BinaryWriter(fs))
            {
                Signature sig = ReadSignature(fs);
                int offset = sig == null ? 0 : -(int)sig.sigSize;

                long sizeNoSig = fs.Seek(offset, SeekOrigin.End);

                bw.Write(signature);
                bw.Write((UInt32)(SIGNATURE_MAGIC));
                bw.Write((UInt32)(signature.Length));
                bw.Write((UInt32)(sizeNoSig + signature.Length + HEADER_SIZE));
                bw.Write((UInt32)(0));
            }

            return true;
        }
    }
}
