//NOTE: most of this code credit to TopHattWaffle. This code reads wc files, which is the file type that stores compile options. This is very jank because the WC format leads all the way back to
//when valve was still working on the original half-life, and thus is not as simple as parsing a plain text JSON file.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInstaller
{
    public static class WCRead
    {
        /// <summary>
        /// This reads the binary data of the WC file and reports if our program's needed launch option already exists.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool entryExists(string path)
        {
            var fileName = path;

            BinaryReader binReader = new BinaryReader(File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));

            ///header
            var d1 = binReader.ReadChars(31);
            //Console.WriteLine("HEADER" + string.Join("", d1));

            //version
            float d2 = binReader.ReadSingle();
            //Console.WriteLine("VERSION:" + d2);

            //seq count
            var d3 = binReader.ReadUInt32();
            //Console.WriteLine("SEQUENCE COUNT:" + d3);

            var seqcnt = d3;

            bool ret = false;

            while (seqcnt != 0)
            {
                seqcnt--;

                // first seq name
                var d4 = binReader.ReadBytes(128);
                //Console.WriteLine("SEQ NAME:" + Encoding.Default.GetString(d4));

                // cmd count
                var d5 = binReader.ReadUInt32();
                //Console.WriteLine("CMD COUNT:" + d5);

                var cmdcnt = d5;

                while (cmdcnt != 0)
                {
                    cmdcnt--;

                    // command enabled?
                    var d6 = binReader.ReadInt32();
                    //Console.WriteLine("ENABLED?:" + d6);

                    // Special?
                    var d7 = binReader.ReadInt32();
                    //Console.WriteLine("SPECIAL?:" + d7);

                    // Exe
                    var d8 = binReader.ReadChars(260);
                    //Console.WriteLine("EXE:" + string.Join("", d8));

                    //args
                    var d9 = binReader.ReadChars(260);
                    //Console.WriteLine("ARG:" + string.Join("", d9));

                    // Check if needed config already exists
                    if (string.Join("",d8).Contains("$exedir/bin/skv/FileGenerator.exe") && string.Join("",d9).Contains("$gamedir $path\\$file"))
                    {
                        ret = true;
                    }

                    // long file
                    var d10 = binReader.ReadInt32();
                    //Console.WriteLine("LONG FILE:" + d10);

                    // ensure check
                    var d11 = binReader.ReadInt32();
                    //Console.WriteLine("CHECK:" + d11);

                    // ensure file
                    var d12 = binReader.ReadChars(260);
                   // Console.WriteLine("ENSURE FILE:" + string.Join("", d12));

                    // use proc window
                    var d13 = binReader.ReadInt32();
                    //Console.WriteLine("PROC WIN:" + d13);

                    // wait?
                    var d14 = binReader.ReadInt32();
                    //Console.WriteLine("WAIT:" + d14);
                }
            }

            //Console.WriteLine("donezoe");
            binReader.Close();
            return ret;
        }

        /// <summary>
        /// This writes a launch config to the binary WC file.
        /// </summary>
        /// <param name="path"></param>
        public static void writeEntry(string path)
        {
            string newPath = $"bin\\CmdSeq.wc";
            File.Copy(path, newPath, true);

            BinaryReader binReader = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));
            BinaryWriter binWriter = new BinaryWriter(File.Open(newPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite));
            binWriter.BaseStream.SetLength(binReader.BaseStream.Length*2);
            ///header
            var d1 = binReader.ReadChars(31);
            //Console.WriteLine("HEADER" + string.Join("", d1));
            binWriter.Write(d1);
            //version
            float d2 = binReader.ReadSingle();
            binWriter.Write(d2);
            //Console.WriteLine("VERSION:" + d2);

            //seq count
            var d3 = binReader.ReadUInt32();
            binWriter.Write(d3+1);
            //Console.WriteLine("SEQUENCE COUNT:" + d3);

            long seqPos = 0;
            seqPos = binReader.BaseStream.Position;

            var seqcnt = d3;

            while (seqcnt != 0)
            {
                seqcnt--;

                // first seq name
                var d4 = binReader.ReadBytes(128);
                binWriter.Write(d4);
                //Console.WriteLine("SEQ NAME:" + Encoding.Default.GetString(d4));

                // cmd count
                var d5 = binReader.ReadUInt32();
                binWriter.Write(d5);
                //Console.WriteLine("CMD COUNT:" + d5);

                var cmdcnt = d5;

                while (cmdcnt != 0)
                {
                    cmdcnt--;

                    // command enabled?
                    var d6 = binReader.ReadInt32();
                    binWriter.Write(d6);
                    //Console.WriteLine("ENABLED?:" + d6);

                    // Special?
                    var d7 = binReader.ReadInt32();
                    binWriter.Write(d7);
                    //Console.WriteLine("SPECIAL?:" + d7);

                    // Exe
                    var d8 = binReader.ReadChars(260);
                    binWriter.Write(d8);
                    //Console.WriteLine("EXE:" + string.Join("", d8));

                    //args
                    var d9 = binReader.ReadChars(260);
                    //Console.WriteLine("ARG:" + string.Join("", d9));
                    binWriter.Write(d9);
                    // long file
                    var d10 = binReader.ReadInt32();
                    binWriter.Write(d10);
                    //Console.WriteLine("LONG FILE:" + d10);

                    // ensure check
                    var d11 = binReader.ReadInt32();
                    binWriter.Write(d11);
                    //Console.WriteLine("CHECK:" + d11);

                    // ensure file
                    var d12 = binReader.ReadChars(260);
                    binWriter.Write(d12);
                    //Console.WriteLine("ENSURE FILE:" + string.Join("", d12));

                    // use proc window
                    var d13 = binReader.ReadInt32();
                    binWriter.Write(d13);
                    //Console.WriteLine("PROC WIN:" + d13);

                    // wait?
                    var d14 = binReader.ReadInt32();
                    binWriter.Write(d14);
                    //Console.WriteLine("WAIT:" + d14);
                }
            }
            binReader.Close();
            // first seq name
            binWriter.Write("SKV_Auto                                                                                                                        ".ToCharArray());
            //Console.WriteLine("SEQ NAME:" + Encoding.Default.GetString(d4));

            // cmd count
            binWriter.Write(1);
            // command enabled?
            binWriter.Write(1);

            // Special
            binWriter.Write(0);

            // Exe
            binWriter.Write("$exedir/bin/skv/FileGenerator.exe                                                                                                                                                                                                                                   ".ToCharArray());

            //args
            binWriter.Write("$gamedir $path\\$file                                                                                                                                                                                                                                               ".ToCharArray());
            // long file
            binWriter.Write(1);

            // ensure check
            binWriter.Write(0);

            // ensure file
            binWriter.Write("                                                                                                                                                                                                                                                                    ".ToCharArray());

            // use proc window
            binWriter.Write(1);

            // wait?
            binWriter.Write(1);

            binWriter.Close();

            File.Delete(path);
            File.Copy(newPath,path);
        }
    }
}
