using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace FileGenerator
{
    public class VMFParse
    {
        public threevalue ParseVMF(string mapDirectory)
        { 
            // Get CT and T Faction Integers
            string[] parsedMap = File.ReadAllLines(mapDirectory);
            int counter = 0;
            bool matched = false;
            int ctFaction = 0;
            int tFaction = 0;

            foreach (string s in parsedMap)
            {
                if (s.Contains("s_kvfile"))
                {
                    matched = true;
                    break;
                }
                else
                {
                    counter++;
                }
            }
            if (matched == false) StopProgram("VMF file does not contain an s_kvfile point entity");
            ctFaction = int.Parse(Regex.Match(parsedMap[counter + 1], @"\d+").Value);
            tFaction = int.Parse(Regex.Match(parsedMap[counter + 2], @"\d+").Value);

            // Get map name
            counter = 0;
            int slashes = 0;
            foreach (char c in mapDirectory)
            {
                if (c == '\\')
                {
                    slashes = counter;
                    counter++;
                }
                else
                {
                    counter++;
                }
                
            }
            counter++;
            string mapName = "";
            while (counter < (mapDirectory.Length - 3))
            {
                mapName = mapName + mapDirectory[counter];
                counter++;
            }
            return VMFInfo(ctFaction, tFaction, mapName);

        }

        private static threevalue VMFInfo(int ctFaction, int tFaction, string mapName)
        {
            threevalue vals = new threevalue();
            vals.valone = ctFaction;
            vals.valtwo = tFaction;
            vals.valthree = mapName;
            return vals;

        }

        private static void StopProgram(string myError)
        {
            Console.WriteLine(myError);
            Console.ReadKey();
            System.Environment.Exit(0);
        }

    }
}

public class threevalue
{
    public int valone { get; set; }
    public int valtwo { get; set; }
    public string valthree { get; set; }
}
