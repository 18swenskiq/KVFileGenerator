using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileGenerator
{
    class VMFParse
    {
        static void Main(string[] args)
        {
            GetCTNumber(args[0]);
        }

        private static string GetCTNumber(string mapDirectory)
        {
            var fileStream = new FileStream(@"c:\file.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    // process the line
                }
            }
        }

    }
}
