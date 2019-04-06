using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;
using Indieteur.VDFAPI;

namespace AutoInstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get's the steam directory so we can work off of that
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam", false);
            string value = null;

            // If we can find the steam directory in the registry files, continue
            if (key != null)
            {
                value = (string)key.GetValue("SteamPath");
            }

            // Give credit of course :)
            Console.WriteLine("KV Generator auto installer setup. KV Generator made by Squidski, Installer made by JamDoggie. Licensed MIT 2019. https://github.com/18swenskiq/KVFileGenerator/");
            Console.WriteLine("Grabbing CSGO directory from registry...");

            if (value != null)
            {
                VDFData vdfData = new VDFData($"{value}/steamapps/libraryfolders.vdf");
                foreach(VDFNode vm in vdfData.Nodes)
                {
                    if(vm.Name == "LibraryFolders")
                    {
                        foreach (VDFKey v in vm.Keys)
                        {
                            int dummy = 0;
                            if (int.TryParse(v.Name, out dummy))
                            {        
                                if (Directory.Exists($"{v.Value}\\steamapps\\common\\Counter-Strike Global Offensive\\csgo"))
                                {

                                }
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
