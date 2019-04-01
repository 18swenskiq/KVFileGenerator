using System;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace KVFileGenerator
{

    public partial class MainWindow : Window
    {

        //Build GUI

        public MainWindow()
        {
            InitializeComponent();

        }

        //Global Variables

        private bool isCTBoxChecked = false;
        private bool isTBoxChecked = false;
        private int lastCTCheckedIndex = 0;
        private int lastTCheckedIndex = 0;
        private string CTfactionChosen;
        private string TfactionChosen;
        private string mapName = "";
        private string authorName = "";
        private string folderPath;
        private string absPath;
        private string tArmString = "models/weapons/t_arms_";
        private string ctArmString = "models/weapons/ct_arms_";
        private string tFactionPre = "tm_";
        private string ctFactionPre = "ctm_";
        private string varA = "_variantA";
        private string varB = "_variantB";
        private string varC = "_variantC";
        private string varD = "_variantD";
        private string varE = "_variantE";
        private string doubleTab = "\t\t";

        //Actions when clicking on checkboxes

        private void CTFBICheck_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(1, "FBI");
                CTFBICheck.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(1, "FBI");
                CTFBICheck.IsEnabled = false;
            }
        }

        private void CT_GIGN_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(2, "GIGN");
                CT_GIGN_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(2, "GIGN");
                CT_GIGN_Check.IsEnabled = false;
            }
        }

        private void CT_GSG9_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(3, "GSG9");
                CT_GSG9_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(3, "GSG9");
                CT_GSG9_Check.IsEnabled = false;
            }
        }

        private void CT_IDF_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(4, "IDF");
                CT_IDF_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(4, "IDF");
                CT_IDF_Check.IsEnabled = false;
            }
        }

        private void CT_SAS_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(5, "SAS");
                CT_SAS_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(5, "SAS");
                CT_SAS_Check.IsEnabled = false;
            }
        }

        private void CT_ST6_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(6, "ST6");
                CT_ST6_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(6, "ST6");
                CT_ST6_Check.IsEnabled = false;
            }
        }

        private void CT_SWAT_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(7, "SWAT");
                CT_SWAT_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(7, "SWAT");
                CT_SWAT_Check.IsEnabled = false;
            }
        }

        private void CT_Anarchist_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(8, "Anarchist");
                CT_Anarchist_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(8, "Anarchist");
                CT_Anarchist_Check.IsEnabled = false;
            }
        }

        private void CT_Balkan_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(9, "Balkan");
                CT_Balkan_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(9, "Balkan");
                CT_Balkan_Check.IsEnabled = false;
            }
        }

        private void CT_Leet_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(10, "Leet");
                CT_Leet_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(10, "Leet");
                CT_Leet_Check.IsEnabled = false;
            }
        }

        private void CT_Phoenix_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(11, "Phoenix");
                CT_Phoenix_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(11, "Phoenix");
                CT_Phoenix_Check.IsEnabled = false;
            }
        }

        private void CT_Pirate_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(12, "Pirate");
                CT_Pirate_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(12, "Pirate");
                CT_Pirate_Check.IsEnabled = false;
            }

        }

        private void CT_Professional_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(13, "Professional");
                CT_Professional_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(13, "Professional");
                CT_Professional_Check.IsEnabled = false;
            }
        }

        private void CT_Separatist_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isCTBoxChecked)
            {
                UncheckLastAndCheckNewCT(14, "Separatist");
                CT_Separatist_Check.IsEnabled = false;
            }
            else
            {
                CheckCTFromScratch(14, "Separatist");
                CT_Separatist_Check.IsEnabled = false;
            }
        }

        private void T_Anarchist_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(15, "Anarchist");
                T_Anarchist_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(15, "Anarchist");
                T_Anarchist_Check.IsEnabled = false;
            }
        }

        private void T_Balkan_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(16, "Balkan");
                T_Balkan_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(16, "Balkan");
                T_Balkan_Check.IsEnabled = false;
            }
        }

        private void T_Leet_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(17, "Leet");
                T_Leet_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(17, "Leet");
                T_Leet_Check.IsEnabled = false;
            }

        }

        private void T_Phoenix_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(18, "Phoenix");
                T_Phoenix_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(18, "Phoenix");
                T_Phoenix_Check.IsEnabled = false;
            }
        }

        private void T_Pirate_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(19, "Pirate");
                T_Pirate_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(19, "Pirate");
                T_Pirate_Check.IsEnabled = false;
            }
        }

        private void T_Professional_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(20, "Professional");
                T_Professional_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(20, "Professional");
                T_Professional_Check.IsEnabled = false;
            }
        }

        private void T_Separatist_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(21, "Separatist");
                T_Separatist_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(21, "Separatist");
                T_Separatist_Check.IsEnabled = false;
            }
        }

        private void T_FBI_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(22, "FBI");
                T_FBI_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(22, "FBI");
                T_FBI_Check.IsEnabled = false;
            }
        }

        private void T_GIGN_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(23, "GIGN");
                T_GIGN_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(23, "GIGN");
                T_GIGN_Check.IsEnabled = false;
            }
        }

        private void T_GSG9_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(24, "GSG9");
                T_GSG9_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(24, "GSG9");
                T_GSG9_Check.IsEnabled = false;
            }
        }

        private void T_IDF_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(25, "IDF");
                T_IDF_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(25, "IDF");
                T_IDF_Check.IsEnabled = false;
            }
        }

        private void T_SAS_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(26, "SAS");
                T_SAS_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(26, "SAS");
                T_SAS_Check.IsEnabled = false;
            }
        }

        private void T_ST6_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(27, "ST6");
                T_ST6_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(27, "ST6");
                T_ST6_Check.IsEnabled = false;
            }
        }

        private void T_SWAT_Check_Checked(object sender, RoutedEventArgs e)
        {
            if (isTBoxChecked)
            {
                UncheckLastAndCheckNewT(28, "SWAT");
                T_SWAT_Check.IsEnabled = false;
            }
            else
            {
                CheckTFromScratch(28, "SWAT");
                T_SWAT_Check.IsEnabled = false;
            }
        }

        //Uncheck Functions

        private void UncheckLastCTCheck(int lastCTCheckedIndex)
        {
            switch (lastCTCheckedIndex)
            {
                case 0:
                    Console.WriteLine("Unchecked Nothing");
                    break;
                case 1:
                    CTFBICheck.IsChecked = false;
                    CTFBICheck.IsEnabled = true;
                    break;
                case 2:
                    CT_GIGN_Check.IsChecked = false;
                    CT_GIGN_Check.IsEnabled = true;
                    break;
                case 3:
                    CT_GSG9_Check.IsChecked = false;
                    CT_GSG9_Check.IsEnabled = true;
                    break;
                case 4:
                    CT_IDF_Check.IsChecked = false;
                    CT_IDF_Check.IsEnabled = true;
                    break;
                case 5:
                    CT_SAS_Check.IsChecked = false;
                    CT_SAS_Check.IsEnabled = true;
                    break;
                case 6:
                    CT_ST6_Check.IsChecked = false;
                    CT_ST6_Check.IsEnabled = true;
                    break;
                case 7:
                    CT_SWAT_Check.IsChecked = false;
                    CT_SWAT_Check.IsEnabled = true;
                    break;
                case 8:
                    CT_Anarchist_Check.IsChecked = false;
                    CT_Anarchist_Check.IsEnabled = true;
                    break;
                case 9:
                    CT_Balkan_Check.IsChecked = false;
                    CT_Balkan_Check.IsEnabled = true;
                    break;
                case 10:
                    CT_Leet_Check.IsChecked = false;
                    CT_Leet_Check.IsEnabled = true;
                    break;
                case 11:
                    CT_Phoenix_Check.IsChecked = false;
                    CT_Phoenix_Check.IsEnabled = true;
                    break;
                case 12:
                    CT_Pirate_Check.IsChecked = false;
                    CT_Pirate_Check.IsEnabled = true;
                    break;
                case 13:
                    CT_Professional_Check.IsChecked = false;
                    CT_Professional_Check.IsEnabled = true;
                    break;
                case 14:
                    CT_Separatist_Check.IsChecked = false;
                    CT_Separatist_Check.IsEnabled = true;
                    break;

            }


        }

        private void UncheckLastTCheck(int lastTCheckedIndex)
        {
            switch (lastTCheckedIndex)
            {
                case 15:
                    T_Anarchist_Check.IsEnabled = true;
                    T_Anarchist_Check.IsChecked = false;
                    break;
                case 16:
                    T_Balkan_Check.IsEnabled = true;
                    T_Balkan_Check.IsChecked = false;
                    break;
                case 17:
                    T_Leet_Check.IsEnabled = true;
                    T_Leet_Check.IsChecked = false;
                    break;
                case 18:
                    T_Phoenix_Check.IsEnabled = true;
                    T_Phoenix_Check.IsChecked = false;
                    break;
                case 19:
                    T_Pirate_Check.IsEnabled = true;
                    T_Pirate_Check.IsChecked = false;
                    break;
                case 20:
                    T_Professional_Check.IsEnabled = true;
                    T_Professional_Check.IsChecked = false;
                    break;
                case 21:
                    T_Separatist_Check.IsEnabled = true;
                    T_Separatist_Check.IsChecked = false;
                    break;
                case 22:
                    T_FBI_Check.IsEnabled = true;
                    T_FBI_Check.IsChecked = false;
                    break;
                case 23:
                    T_GIGN_Check.IsEnabled = true;
                    T_GIGN_Check.IsChecked = false;
                    break;
                case 24:
                    T_GSG9_Check.IsEnabled = true;
                    T_GSG9_Check.IsChecked = false;
                    break;
                case 25:
                    T_IDF_Check.IsEnabled = true;
                    T_IDF_Check.IsChecked = false;
                    break;
                case 26:
                    T_SAS_Check.IsEnabled = true;
                    T_SAS_Check.IsChecked = false;
                    break;
                case 27:
                    T_ST6_Check.IsEnabled = true;
                    T_ST6_Check.IsChecked = false;
                    break;
                case 28:
                    T_SWAT_Check.IsEnabled = true;
                    T_SWAT_Check.IsChecked = false;
                    break;
            }
        }

        // Grab Map name from text box

        private void MapNameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (mapNameInput.Text.Contains("/") || mapNameInput.Text.Contains("\\") || mapNameInput.Text.Contains(":") || mapNameInput.Text.Contains("*") || mapNameInput.Text.Contains("?") || mapNameInput.Text.Contains("\"") || mapNameInput.Text.Contains("<") || mapNameInput.Text.Contains(">") || mapNameInput.Text.Contains("|"))
            {
                mapNameInput.Text = "";
                System.Windows.Forms.MessageBox.Show("Please enter a valid map name");
            }
            else
            {
                mapName = mapNameInput.Text;
            }
        }

        // Grab Author Name from text box

        private void AuthorNameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
                authorName = authorNameInput.Text;
        }

        // Uncheck the last CT/T Box, and check a new CT/T box

        private void UncheckLastAndCheckNewCT(int CTIndex, string YourFaction)
        {
            UncheckLastCTCheck(lastCTCheckedIndex);
            lastCTCheckedIndex = CTIndex;
            CTfactionChosen = YourFaction;
        }

        private void UncheckLastAndCheckNewT(int TIndex, string YourFaction)
        {
            UncheckLastTCheck(lastTCheckedIndex);
            lastTCheckedIndex = TIndex;
            TfactionChosen = YourFaction;
        }

        //Check a CT or T box from scratch    

        private void CheckCTFromScratch(int CTIndex, string YourFaction)
        {
            lastCTCheckedIndex = CTIndex;
            isCTBoxChecked = true;
            CTfactionChosen = YourFaction;
        }

        private void CheckTFromScratch(int TIndex, string YourFaction)
        {
            lastTCheckedIndex = TIndex;
            isTBoxChecked = true;
            TfactionChosen = YourFaction;
        }

        // Check if all prerequisites are good so file can be generated 

        private bool GoodToGenerateFile()
        {
            if (isTBoxChecked && isCTBoxChecked && mapNameInput.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Create KV File
        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(1000);
            if (GoodToGenerateFile())
            {
                Console.WriteLine(lastTCheckedIndex + " , " + lastCTCheckedIndex);

                FolderBrowserDialog fbd = new FolderBrowserDialog
                {
                    Description = "Select a folder to save your .kv file to"
                };
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    folderPath = fbd.SelectedPath;

                    Console.WriteLine(folderPath);

                    absPath = folderPath + "\\" + mapName + ".kv";

                    //This writes the KV File

                    File.Create(absPath).Dispose();

                    if (File.Exists(absPath))
                    {
                        SquidFileWriter();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Please generate again and select a valid file path");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please generate again and select a valid file path");
                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You must select a faction for both teams!");
            }
      
        }

        //Write to KV File
        private void SquidFileWriter()
        {
            TfactionChosen = TfactionChosen.ToLower();
            CTfactionChosen = CTfactionChosen.ToLower();

            using (StreamWriter sw = File.AppendText(absPath))
            {
                sw.WriteLine("\"" + mapName + "\"");
                sw.WriteLine("{");
                sw.WriteLine("\t\"name\" \t" + '"' + mapName + '"');
                sw.WriteLine("\t\"t_arms\" \t" + '"' + tArmString + TfactionChosen + ".mdl\"");
                sw.WriteLine("\t\"ct_arms\" \t" + '"' + ctArmString + CTfactionChosen + ".mdl\"");
                sw.WriteLine("\t\"t_models\"");
                sw.WriteLine("\t{");
                switch (TfactionChosen)
                {
                    case "leet":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varE + "\"" + " \"\"");
                        break;

                    case "balkan":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varE + "\"" + " \"\"");
                        break;

                    case "anarchist":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "phoenix":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "pirate":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "professional":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + "_var1" + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + "_var2" + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + "_var3" + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + "_var4" + "\"" + " \"\"");
                        break;

                    case "separatist":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "fbi":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "gign":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "gsg9":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "idf":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varE + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + "_variantF" + " \"" + "\"\"");
                        break;

                    case "sas":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varE + "\"" + " \"\"");
                        break;

                    case "st6":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "swat":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + TfactionChosen + varD + "\"" + " \"\"");
                        break;
                }
                sw.WriteLine("\t}");
                sw.WriteLine("\t\"ct_models\"");
                sw.WriteLine("\t{");
                switch (CTfactionChosen)
                {
                    case "leet":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varE + "\"" + " \"\"");
                        break;

                    case "balkan":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varE + "\"" + " \"\"");
                        break;

                    case "anarchist":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "phoenix":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "pirate":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "professional":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + "_var1" + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + "_var2" + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + "_var3" + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + "_var4" + "\"" + " \"\"");
                        break;

                    case "separatist":
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + tFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "fbi":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "gign":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "gsg9":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "idf":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varE + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + "_variantF" + "\"" + " \"\"");
                        break;

                    case "sas":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varE + "\"" + " \"\"");
                        break;

                    case "st6":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        break;

                    case "swat":
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varA + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varB + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varC + "\"" + " \"\"");
                        sw.WriteLine(doubleTab + '"' + ctFactionPre + CTfactionChosen + varD + "\"" + " \"\"");
                        break;
                }
                sw.WriteLine("\t}");
                sw.WriteLine("}");
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine(doubleTab + doubleTab + "// Map Author: " + authorName);
                sw.WriteLine(doubleTab + doubleTab + "// Generated by Squid's KVFileGenerator Tool");
                System.Windows.Forms.MessageBox.Show("KV File Successfully Created!");
            }
        }

    }
}
