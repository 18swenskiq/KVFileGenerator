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
        private static string CSGOPath = "NULL";

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

            // If we could find the "SteamPath" value, continue
            if (value != null)
            {
                // Parse VDF file and make it an object. The libraryfolders VDF file contains references to all user set game paths.
                VDFData vdfData = new VDFData($"{value}/steamapps/libraryfolders.vdf");

                // This starts searching for game paths in this vdf
                foreach (VDFNode vm in vdfData.Nodes)
                {
                    if (vm.Name == "LibraryFolders")
                    {
                        foreach (VDFKey v in vm.Keys)
                        {
                            // This variable is used so that tryparse can work. We use try parse to make sure the value is a number. We need to make sure the value is a number, beacuse all numbered values in this vdf file
                            // contain references to all the game paths.
                            int dummy = 0;
                            if (int.TryParse(v.Name, out dummy))
                            {
                                if (Directory.Exists($"{v.Value}\\steamapps\\common\\Counter-Strike Global Offensive\\csgo"))
                                {
                                    CSGOPath = $"{v.Value}\\steamapps\\common\\Counter-Strike Global Offensive\\csgo";
                                }
                            }
                        }
                    }
                }
            }
            // TODO: add else statement to cover a scenario where we couldn't find the directory, and ask the user to supply the directory instead.

            if(CSGOPath != "NULL")
            {
                Console.WriteLine("CSGO directory found successfully \nExtracting files...");
            }
            Console.ReadKey();
        }
    }
}
