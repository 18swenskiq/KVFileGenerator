﻿using System;
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
        private static bool custompathfound = false;

        static void Main(string[] args)
        {
            // Give credit of course :)
            Console.WriteLine("KV Generator auto installer setup. KV Generator made by Squidski, Installer made by JamDoggie. Licensed MIT 2019. https://github.com/18swenskiq/KVFileGenerator/");
            Console.WriteLine("Grabbing CSGO directory from registry...\n");

            // Get's the steam directory so we can work off of that
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam", false);
            string value = null;

            // If we can find the steam directory in the registry files, continue
            if (key != null)
            {
                value = (string)key.GetValue("SteamPath");
            }
            else
            {
                string path = "";
                if ((path = getUserDefinedPath()) == null)
                {
                    custompathfound = false;
                }
                else
                {
                    custompathfound = true;
                    CSGOPath = path;
                }
            }

            

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
                                if (Directory.Exists($"{v.Value}\\steamapps\\common\\Counter-Strike Global Offensive"))
                                {
                                    CSGOPath = $"{v.Value}\\steamapps\\common\\Counter-Strike Global Offensive";
                                }
                            }
                        }
                    }
                }
                if (CSGOPath == "NULL")
                {
                    string path = "";
                    if ((path = getUserDefinedPath()) == null)
                    {
                        custompathfound = false;
                    }
                    else
                    {
                        custompathfound = true;
                        CSGOPath = path;
                    }
                }
            }

           
            // TODO: add else statement to cover a scenario where we couldn't find the directory, and ask the user to supply the directory instead.
            if (CSGOPath != "NULL")
            {
                Console.WriteLine("CSGO directory found successfully \nInstalling files...");

                // Copy EXE file
                Console.WriteLine("25%");
                if (File.Exists("bin/FileGenerator.exe"))
                {
                    if (!Directory.Exists($"{CSGOPath}\\bin\\skv"))
                    {
                        Directory.CreateDirectory($"{CSGOPath}\\bin\\skv");
                    }
                    Copy("bin/FileGenerator.exe", $"{CSGOPath}\\bin\\skv\\FileGenerator.exe");
                }

                // Copy FGD file
                Console.WriteLine("50%");
                if (File.Exists("bin/kvfilegen.fgd"))
                {
                    Copy("bin/kvfilegen.fgd", $"{CSGOPath}\\bin\\kvfilegen.fgd");
                }

                // Copy VMT file
                Console.WriteLine("75%");
                if (File.Exists("bin/s_kvfile.vmt"))
                {
                    if (!Directory.Exists($"{CSGOPath}\\csgo\\materials\\s_kvfile\\editor\\"))
                    {
                        Directory.CreateDirectory($"{CSGOPath}\\csgo\\materials\\s_kvfile\\editor\\");
                    }
                    Copy("bin/s_kvfile.vmt", $"{CSGOPath}\\csgo\\materials\\s_kvfile\\editor\\s_kvfile.vmt");
                }

                // Copy VMF file
                Console.WriteLine("100%");
                if (File.Exists("bin/s_kvfile.vtf"))
                {
                    if (!Directory.Exists($"{CSGOPath}\\csgo\\materials\\s_kvfile\\editor\\"))
                    {
                        Directory.CreateDirectory($"{CSGOPath}\\csgo\\materials\\s_kvfile\\editor\\");
                    }
                    Copy("bin/s_kvfile.vtf", $"{CSGOPath}\\csgo\\materials\\s_kvfile\\editor\\s_kvfile.vtf");
                }
                Console.WriteLine("Finished installing files");
                Console.WriteLine("Configuring FGD...");

                // This parses the GameConfig txt so that we can add our fgd to it
                string contents = File.ReadAllText($"{CSGOPath}\\bin\\GameConfig.txt").Replace('\\','/');
                VDFData vdfData = new VDFData(contents, false);

                bool gameDataExists = false;

                foreach (VDFNode vm in vdfData.Nodes)
                {
                    if (vm.Name == "Configs")
                    {
                        foreach (VDFNode v in vm.Nodes)
                        {
                            if (v.Name == "Games")
                            {
                                foreach (VDFNode v1 in v.Nodes)
                                {
                                    if (v1.Name == "Counter-Strike: Global Offensive")
                                    {
                                        foreach (VDFNode v2 in v1.Nodes)
                                        {
                                            if (v2.Name == "Hammer")
                                            {
                                                int counter = 0;
                                                foreach(VDFKey vk in v2.Keys)
                                                {
                                                    if (vk.Name.Contains("GameData"))
                                                    {
                                                        counter++;
                                                        if (vk.Value == $"{CSGOPath}/bin/kvfilegen.fgd".Replace('\\', '/'))
                                                        {
                                                            gameDataExists = true;
                                                        }
                                                    }
                                                }
                                                if (!gameDataExists)
                                                {
                                                    v2.Keys.Add(new VDFKey($"GameData{counter}", $"{CSGOPath}/bin/kvfilegen.fgd".Replace('\\', '/'), v2));
                                                }
                                                
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                vdfData.SaveToFile($"{CSGOPath}\\bin\\GameConfig.txt", true);

                Console.WriteLine("Configuring launch options...");

                if (File.Exists($"{CSGOPath}\\bin\\CmdSeq.wc"))
                {
                    if (!WCRead.entryExists($"{CSGOPath}\\bin\\CmdSeq.wc"))
                    {
                        // Write it into the wc file
                        WCRead.writeEntry($"{CSGOPath}\\bin\\CmdSeq.wc");
                    }
                    else
                    {
                        Console.WriteLine("The correct launch option already exists! Skipping unnecessary step.");
                    }
                }
                else
                {
                    Console.WriteLine("Launch option config file not found! You will need to manually add the launch option to hammer(see how in the readme).");
                }
            }

            Console.WriteLine("Installer finished.");
            Console.ReadKey();
        }
        public static void Copy(string inputFilePath, string outputFilePath)
        {
            int bufferSize = 1024 * 1024;

            using (FileStream fileStream = new FileStream(outputFilePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                FileStream fs = new FileStream(inputFilePath, FileMode.Open, FileAccess.ReadWrite);
                fileStream.SetLength(fs.Length);
                int bytesRead = -1;
                byte[] bytes = new byte[bufferSize];

                while ((bytesRead = fs.Read(bytes, 0, bufferSize)) > 0)
                {
                    fileStream.Write(bytes, 0, bytesRead);
                }
            }
        }

        // This will ask the user for a path. It will then check if the path is valid.
        public static string getUserDefinedPath()
        {
            Console.WriteLine("Counter-Strike Global Offensive not found. Please input your Counter-Strike Global Offensive path. It will look something like ''{SteamDirectory}\\steamapps\\common\\Counter Strike Global Offensive''. do NOT supply Counter-Strike Global Offensive\\csgo, only Counter-Strike Global Offensive.");
            string input = Console.ReadLine();
            if(!Directory.Exists(input))
            {
                input = null;
            }
            if(!Directory.Exists($"{input}\\bin") || !File.Exists($"{input}\\bin\\GameConfig.txt"))
            {
                Console.WriteLine("Custom path invalid! Installer exiting.");
                custompathfound = false;
                input = null;
            }
            return input;
        }

    }
}
