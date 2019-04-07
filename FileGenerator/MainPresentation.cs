using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileGenerator
{
    class MainPresentation
    {
        static void Main(string[] args)
        {

            //Read Map Name, CT, and T keyvalues from VMF
            threevalue tresval = ParseVMF(args[1]);
            int ctFaction = tresval.valone;
            int tFaction = tresval.valtwo;
            string mapName = tresval.valthree;

            //Create .kv file in /csgo/maps
            string mapsDir = args[0] + "\\maps\\";
            File.Create(mapsDir + mapName + ".kv").Dispose();

            //Write map name to .kv file

            //Write faction data (use different class?)

            //Write "written by Squidski's kv file tool" or something like that

            //Close Program

        }

        public static threevalue ParseVMF(string mapDirectory)
        {
            VMFParse vmf = new VMFParse();
            threevalue tresval = new threevalue();
            tresval = vmf.ParseVMF(mapDirectory);
            return tresval;
        }

        private static void SquidFileWriter(int ctFaction, int tFaction, string mapName)
        {

        }
    }
}

