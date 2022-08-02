using System.Xml;

namespace Rectify11Installer.Core
{
    public static class Patches
    {
        public static PatchDef[] GetAll()
        {
            List<PatchDef> p = new();
            XmlDocument doc = new();
            doc.LoadXml(File.ReadAllText(@"C:\Windows\Rectify11" + "\\rectify11.xml"));

            var patchesTag = doc.GetElementsByTagName("Patches");
            if (patchesTag.Count != 1)
            {
                throw new Exception("There needs to be only 1 <Patches> Tag");
            }
            var patches = patchesTag[0];
            if (patches != null)
            {
                foreach (XmlNode patch in patches.ChildNodes)
                {
                    if (patch != null)
                    {
                        if (patch.NodeType != XmlNodeType.Comment)
                        {
                            if (patch.Attributes == null)
                            {
                                throw new Exception("<Patch> tag has no attributes!");
                            }
                            else
                            {
                                var packageNameAttrib = patch.Attributes["Package"];
                                if (packageNameAttrib == null)
                                    throw new Exception("<Patch> tag missing Package attribute!");
                                var archAttrib = patch.Attributes["Arch"];
                                if (archAttrib == null)
                                    throw new Exception("<Patch> tag missing Arch attribute!");
                                var hardLinkTargetAttrib = patch.Attributes["HardlinkTarget"];
                                if (hardLinkTargetAttrib == null)
                                    throw new Exception("<Patch> tag missing HardlinkTarget attribute!");

                                var disableOnSafeMode = patch.Attributes["DisableOnSafeMode"];
                                if (disableOnSafeMode == null)
                                    throw new Exception("<Patch> tag missing DisableOnSafeMode attribute!");

                                var packageName = packageNameAttrib.Value;
                                var disableOnSafeModeProper = bool.Parse(disableOnSafeMode.InnerText);
                                var arch = archAttrib.Value;
                                PackageArch archProper;
                                if (arch == "amd64")
                                {
                                    archProper = PackageArch.Amd64;
                                }
                                else
                                {
                                    throw new Exception("Unknown arch value: " + arch);
                                }

                                var hardlinkTarget = hardLinkTargetAttrib.Value;

                                var instructions = new List<PatchInstruction>();

                                var commandsTag = patch.ChildNodes[0];
                                if (commandsTag != null)
                                {
                                    if (commandsTag.Name != "Commands")
                                    {
                                        throw new Exception("Unknown node under <Patch>: " + commandsTag.Name);
                                    }

                                    foreach (XmlNode item in commandsTag.ChildNodes)
                                    {
                                        if (item != null)
                                        {
                                            if (item.Name != "Command")
                                            {
                                                throw new Exception("Unknown node under <Patch>: " + commandsTag.Name);
                                            }

                                            if (item.Attributes != null)
                                            {
                                                var action = item.Attributes["action"];
                                                if (action == null)
                                                    throw new Exception("Attribute: action is required under Command tag");
                                                var resource = item.Attributes["resource"];

                                                var mask = item.Attributes["mask"];
                                                if (mask == null)
                                                    throw new Exception("Attribute: mask is required under Command tag");

                                                string resourceProper = resource == null ? "" : resource.InnerText;

                                                instructions.Add(new PatchInstruction(action.InnerText, resourceProper, mask.InnerText));
                                            }
                                            else
                                            {
                                                throw new Exception("<Command> tag requires attributes");
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Tag under <Commands> null!");
                                        }
                                    }
                                }
                                else
                                {
                                    throw new Exception("Tag under <Patch> null!");
                                }

                                p.Add(new PatchDef(packageName, archProper, hardlinkTarget, instructions.ToArray(), disableOnSafeModeProper));
                            }
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Root tag: <Patches> is null");
            }


            return p.ToArray();
        }
    }
}
