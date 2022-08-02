// This is used to simplify the creation of Rectify11.xml to avoid unnessesary steps

List<Info> dllsToSearch = new();

foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory() + "/stuff"))
{
    var name = Path.GetFileName(file);

    var dll = name.Replace(".res", "");//name.Substring(0, name.IndexOf('_'));
    var ext = dll.Substring(dll.Length - 3, 3);
    dll = dll.Substring(0, dll.Length - 4);
   

    string type = "??";

    if (ext == "msc")
        continue;

    if (!File.Exists(@"C:\Windows\System32\" + dll + ".exe"))
    {
        if (!File.Exists(@"C:\Windows\System32\" + dll + ".dll"))
        {
            if (!File.Exists(@"C:\Windows\System32\" + dll + ".cpl"))
            {
                Console.WriteLine("Warning: Cannot find " + dll + ".dll/exe/cpl");
            }
            else
            {
                type = "cpl";
            }
        }
        else
        {
            type = "dll";
        }
    }
    else
    {
        type = "exe";
    }

    if (type != "??")
    {
        dllsToSearch.Add(new Info() { DllName = dll + "." + type, ResFile = file, DllPath = @"C:\Windows\System32\" + dll + "." + type });
    }
}

foreach (var dir in Directory.GetDirectories(@"C:\Windows\WinSxS\"))
{
    var dirName = Path.GetDirectoryName(dir + "/").Substring(18);
    if (dirName.StartsWith("amd64_"))
    {
        foreach (var file in Directory.GetFiles(dir))
        {
            var fs = Path.GetFileName(file);
            foreach (var item in dllsToSearch)
            {
                var properPackageName = dirName.Substring(6);
                properPackageName = properPackageName.Substring(0, properPackageName.IndexOf('_'));

                var a = fs.ToLower();
                var b = item.DllName.ToLower();
                if (a == b)
                {
                    

                    Console.WriteLine($"	<Patch Package=\"" + properPackageName + "\" HardlinkTarget=\"" + item.DllPath + "\" DisableOnSafeMode=\"false\" Arch=\"amd64\">");
                    Console.WriteLine($"		<Commands>");
                    Console.WriteLine($"			<Command action=\"delete\" mask=\"ICONGROUP, \"></Command>");
                    Console.WriteLine($"			<Command action=\"addskip\" resource=\"{Path.GetFileName(item.ResFile)}\" mask=\"ICONGROUP, \"></Command>");
                    Console.WriteLine($"		</Commands>");
                    Console.WriteLine($"	</Patch>");
                    dllsToSearch.Remove(item);
                    break;
                }
            }
        }
    }
}

Console.WriteLine("cannot find " + dllsToSearch.Count + " dlls/exes in winsxs");

foreach (var item in dllsToSearch)
{
    Console.WriteLine(" - "+item.DllName);
}

class Info
{
    public string DllName;
    public string ResFile;
    public bool SxsFound;
    public string DllPath;
}