using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VMFParse;

namespace FileGenerator
{
    class MainPresentation
    {
        static void Main(string[] args)
        {

            //Read Map Name from VMF
            ParseVMF(args[1]);

            //Read Terrorist KeyValue from VMF

            //Read Counter-Terrorist KeyValue from VMF

            //Create .kv file in /csgo/maps

            //Test if arms is obsolete. If its not, then add arms to file (use different class if so I guess)

            //Write map name to .kv file

            //Write faction data (use different class?)

            //Write "written by Squidski's kv file tool" or something like that

            //Close Program

        }

         public static string ParseVMF(string mapDirectory)
        {

        }
    }
}
