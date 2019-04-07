using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileGenerator
{
    public class NameDefs
    {
        public string[] GetCTFaction(int ctFactionInt)
        {
            switch (ctFactionInt)
            {
                case 0:
                    string[] str1 = new string[5];
                    str1[0] = "\"ctm_fbi\"\"\"";
                    str1[1] = "\"ctm_fbi_variantA\"\"\"";
                    str1[2] = "\"ctm_fbi_variantB\"\"\"";
                    str1[3] = "\"ctm_fbi_variantC\"\"\"";
                    str1[4] = "\"ctm_fbi_variantD\"\"\"";
                    return str1;
                case 1:
                    string[] str2 = new string[5];
                    str2[0] = "\"ctm_gign\"\"\"";
                    str2[1] = "\"ctm_gign_variantA\"\"\"";
                    str2[2] = "\"ctm_gign_variantB\"\"\"";
                    str2[3] = "\"ctm_gign_variantC\"\"\"";
                    str2[4] = "\"ctm_gign_variantD\"\"\"";
                    return str2;
                case 2:
                    string[] str3 = new string[5];
                    str3[0] = "\"ctm_gsg9\"\"\"";
                    str3[1] = "\"ctm_gsg9_variantA\"\"\"";
                    str3[2] = "\"ctm_gsg9_variantB\"\"\"";
                    str3[3] = "\"ctm_gsg9_variantC\"\"\"";
                    str3[4] = "\"ctm_gsg9_variantD\"\"\"";
                    return str3;
                case 3:
                    string[] str4 = new string[6];
                    str4[0] = "\"ctm_idf\"\"\"";
                    str4[1] = "\"ctm_idf_variantB\"\"\"";
                    str4[2] = "\"ctm_idf_variantC\"\"\"";
                    str4[3] = "\"ctm_idf_variantD\"\"\"";
                    str4[4] = "\"ctm_idf_variantE\"\"\"";
                    str4[5] = "\"ctm_idf_variantF\"\"\"";
                    return str4;
                case 4:
                    string[] str5 = new string[6];
                    str5[0] = "\"ctm_sas\"\"\"";
                    str5[1] = "\"ctm_sas_variantA\"\"\"";
                    str5[2] = "\"ctm_sas_variantB\"\"\"";
                    str5[3] = "\"ctm_sas_variantC\"\"\"";
                    str5[4] = "\"ctm_sas_variantD\"\"\"";
                    str5[5] = "\"ctm_sas_variantE\"\"\"";
                    return str5;
                case 5:
                    string[] str6 = new string[5];
                    str6[0] = "\"ctm_st6\"\"\"";
                    str6[1] = "\"ctm_st6_variantA\"\"\"";
                    str6[2] = "\"ctm_st6_variantB\"\"\"";
                    str6[3] = "\"ctm_st6_variantC\"\"\"";
                    str6[4] = "\"ctm_st6_variantD\"\"\"";
                    return str6;
                case 6:
                    string[] str7 = new string[5];
                    str7[0] = "\"ctm_swat\"\"\"";
                    str7[1] = "\"ctm_swat_variantA\"\"\"";
                    str7[2] = "\"ctm_swat_variantB\"\"\"";
                    str7[3] = "\"ctm_swat_variantC\"\"\"";
                    str7[4] = "\"ctm_swat_variantD\"\"\"";
                    return str7;
                case 7:
                    string[] str8 = new string[5];
                    str8[0] = "\"tm_anarchist\"\"\"";
                    str8[1] = "\"tm_anarchist_variantA\"\"\"";
                    str8[2] = "\"tm_anarchist_variantB\"\"\"";
                    str8[3] = "\"tm_anarchist_variantC\"\"\"";
                    str8[4] = "\"tm_anarchist_variantD\"\"\"";
                    return str8;
                case 8:
                    string[] str9 = new string[5];
                    str9[0] = "\"tm_balkan_variantA\"\"\"";
                    str9[1] = "\"tm_balkan_variantB\"\"\"";
                    str9[2] = "\"tm_balkan_variantC\"\"\"";
                    str9[3] = "\"tm_balkan_variantD\"\"\"";
                    str9[4] = "\"tm_balkan_variantE\"\"\"";
                    return str9;
                case 9:
                    string[] str10 = new string[5];
                    str10[0] = "\"tm_leet_variantA\"\"\"";
                    str10[1] = "\"tm_leet_variantB\"\"\"";
                    str10[2] = "\"tm_leet_variantC\"\"\"";
                    str10[3] = "\"tm_leet_variantD\"\"\"";
                    str10[4] = "\"tm_leet_variantE\"\"\"";
                    return str10;
                case 10:
                    string[] str11 = new string[5];
                    str11[0] = "\"tm_phoenix\"\"\"";
                    str11[1] = "\"tm_phoenix_variantA\"\"\"";
                    str11[2] = "\"tm_phoenix_variantB\"\"\"";
                    str11[3] = "\"tm_phoenix_variantC\"\"\"";
                    str11[4] = "\"tm_phoenix_variantD\"\"\"";
                    return str11;
                case 11:
                    string[] str12 = new string[5];
                    str12[0] = "\"tm_pirate\"\"\"";
                    str12[1] = "\"tm_pirate_variantA\"\"\"";
                    str12[2] = "\"tm_pirate_variantB\"\"\"";
                    str12[3] = "\"tm_pirate_variantC\"\"\"";
                    str12[4] = "\"tm_pirate_variantD\"\"\"";
                    return str12;
                case 12:
                    string[] str13 = new string[5];
                    str13[0] = "\"tm_professional\"\"\"";
                    str13[1] = "\"tm_professional_var1\"\"\"";
                    str13[2] = "\"tm_professional_var2\"\"\"";
                    str13[3] = "\"tm_professional_var3\"\"\"";
                    str13[4] = "\"tm_professional_var4\"\"\"";
                    return str13;
                case 13:
                    string[] str14 = new string[5];
                    str14[0] = "\"tm_separatist\"\"\"";
                    str14[1] = "\"tm_separatist_variantA\"\"\"";
                    str14[2] = "\"tm_separatist_variantB\"\"\"";
                    str14[3] = "\"tm_separatist_variantC\"\"\"";
                    str14[4] = "\"tm_separatist_variantD\"\"\"";
                    return str14;
                case 14:
                    string[] str15 = new string[3];
                    str15[0] = "\"tm_jumpsuit_varianta\"\"\"";
                    str15[1] = "\"tm_jumpsuit_variantb\"\"\"";
                    str15[2] = "\"tm_jumpsuit_variantc\"\"\"";
                    return str15;
                case 15:
                    string[] str16 = new string[1];
                    str16[0] = "\"tm_phoenix_heavy\"\"\"";
                    return str16;
                case 16:
                    string[] str17 = new string[1];
                    str17[0] = "\"zombie\"\"\"";
                    return str17;
                default:
                    string[] str18 = new string[6];
                    str18[0] = "\"ctm_sas\"\"\"";
                    str18[1] = "\"ctm_sas_variantA\"\"\"";
                    str18[2] = "\"ctm_sas_variantB\"\"\"";
                    str18[3] = "\"ctm_sas_variantC\"\"\"";
                    str18[4] = "\"ctm_sas_variantD\"\"\"";
                    str18[5] = "\"ctm_sas_variantE\"\"\"";
                    return str18;
            }
        }

        public string[] GetTFaction(int tFactionInt)
        {
            switch (tFactionInt)
            {
                case 0:
                    string[] str1 = new string[5];
                    str1[0] = "\"tm_anarchist\"\"\"";
                    str1[1] = "\"tm_anarchist_variantA\"\"\"";
                    str1[2] = "\"tm_anarchist_variantB\"\"\"";
                    str1[3] = "\"tm_anarchist_variantC\"\"\"";
                    str1[4] = "\"tm_anarchist_variantD\"\"\"";
                    return str1;
                case 1:
                    string[] str2 = new string[5];
                    str2[0] = "\"tm_balkan_variantA\"\"\"";
                    str2[1] = "\"tm_balkan_variantB\"\"\"";
                    str2[2] = "\"tm_balkan_variantC\"\"\"";
                    str2[3] = "\"tm_balkan_variantD\"\"\"";
                    str2[4] = "\"tm_balkan_variantE\"\"\"";
                    return str2;
                case 2:
                    string[] str3 = new string[5];
                    str3[0] = "\"tm_leet_variantA\"\"\"";
                    str3[1] = "\"tm_leet_variantB\"\"\"";
                    str3[2] = "\"tm_leet_variantC\"\"\"";
                    str3[3] = "\"tm_leet_variantD\"\"\"";
                    str3[4] = "\"tm_leet_variantE\"\"\"";
                    return str3;
                case 3:
                    string[] str4 = new string[5];
                    str4[0] = "\"tm_phoenix\"\"\"";
                    str4[1] = "\"tm_phoenix_variantA\"\"\"";
                    str4[2] = "\"tm_phoenix_variantB\"\"\"";
                    str4[3] = "\"tm_phoenix_variantC\"\"\"";
                    str4[4] = "\"tm_phoenix_variantD\"\"\"";
                    return str4;
                case 4:
                    string[] str5 = new string[5];
                    str5[0] = "\"tm_pirate\"\"\"";
                    str5[1] = "\"tm_pirate_variantA\"\"\"";
                    str5[2] = "\"tm_pirate_variantB\"\"\"";
                    str5[3] = "\"tm_pirate_variantC\"\"\"";
                    str5[4] = "\"tm_pirate_variantD\"\"\"";
                    return str5;
                case 5:
                    string[] str6 = new string[5];
                    str6[0] = "\"tm_professional\"\"\"";
                    str6[1] = "\"tm_professional_var1\"\"\"";
                    str6[2] = "\"tm_professional_var2\"\"\"";
                    str6[3] = "\"tm_professional_var3\"\"\"";
                    str6[4] = "\"tm_professional_var4\"\"\"";
                    return str6;
                case 6:
                    string[] str7 = new string[5];
                    str7[0] = "\"tm_separatist\"\"\"";
                    str7[1] = "\"tm_separatist_variantA\"\"\"";
                    str7[2] = "\"tm_separatist_variantB\"\"\"";
                    str7[3] = "\"tm_separatist_variantC\"\"\"";
                    str7[4] = "\"tm_separatist_variantD\"\"\"";
                    return str7;
                case 7:
                    string[] str8 = new string[5];
                    str8[0] = "\"ctm_fbi\"\"\"";
                    str8[1] = "\"ctm_fbi_variantA\"\"\"";
                    str8[2] = "\"ctm_fbi_variantB\"\"\"";
                    str8[3] = "\"ctm_fbi_variantC\"\"\"";
                    str8[4] = "\"ctm_fbi_variantD\"\"\"";
                    return str8;
                case 8:
                    string[] str9 = new string[5];
                    str9[0] = "\"ctm_gign\"\"\"";
                    str9[1] = "\"ctm_gign_variantA\"\"\"";
                    str9[2] = "\"ctm_gign_variantB\"\"\"";
                    str9[3] = "\"ctm_gign_variantC\"\"\"";
                    str9[4] = "\"ctm_gign_variantD\"\"\"";
                    return str9;
                case 9:
                    string[] str10 = new string[5];
                    str10[0] = "\"ctm_gsg9\"\"\"";
                    str10[1] = "\"ctm_gsg9_variantA\"\"\"";
                    str10[2] = "\"ctm_gsg9_variantB\"\"\"";
                    str10[3] = "\"ctm_gsg9_variantC\"\"\"";
                    str10[4] = "\"ctm_gsg9_variantD\"\"\"";
                    return str10;
                case 10:
                    string[] str11 = new string[6];
                    str11[0] = "\"ctm_idf\"\"\"";
                    str11[1] = "\"ctm_idf_variantB\"\"\"";
                    str11[2] = "\"ctm_idf_variantC\"\"\"";
                    str11[3] = "\"ctm_idf_variantD\"\"\"";
                    str11[4] = "\"ctm_idf_variantE\"\"\"";
                    str11[5] = "\"ctm_idf_variantF\"\"\"";
                    return str11;
                case 11:
                    string[] str12 = new string[6];
                    str12[0] = "\"ctm_sas\"\"\"";
                    str12[1] = "\"ctm_sas_variantA\"\"\"";
                    str12[2] = "\"ctm_sas_variantB\"\"\"";
                    str12[3] = "\"ctm_sas_variantC\"\"\"";
                    str12[4] = "\"ctm_sas_variantD\"\"\"";
                    str12[5] = "\"ctm_sas_variantE\"\"\"";
                    return str12;
                case 12:
                    string[] str13 = new string[5];
                    str13[0] = "\"ctm_st6\"\"\"";
                    str13[1] = "\"ctm_st6_variantA\"\"\"";
                    str13[2] = "\"ctm_st6_variantB\"\"\"";
                    str13[3] = "\"ctm_st6_variantC\"\"\"";
                    str13[4] = "\"ctm_st6_variantD\"\"\"";
                    return str13;
                case 13:
                    string[] str14 = new string[5];
                    str14[0] = "\"ctm_swat\"\"\"";
                    str14[1] = "\"ctm_swat_variantA\"\"\"";
                    str14[2] = "\"ctm_swat_variantB\"\"\"";
                    str14[3] = "\"ctm_swat_variantC\"\"\"";
                    str14[4] = "\"ctm_swat_variantD\"\"\"";
                    return str14;
                case 14:
                    string[] str15 = new string[3];
                    str15[0] = "\"tm_jumpsuit_varianta\"\"\"";
                    str15[1] = "\"tm_jumpsuit_variantb\"\"\"";
                    str15[2] = "\"tm_jumpsuit_variantc\"\"\"";
                    return str15;
                case 15:
                    string[] str16 = new string[1];
                    str16[0] = "\"tm_phoenix_heavy\"\"\"";
                    return str16;
                case 16:
                    string[] str17 = new string[1];
                    str17[0] = "\"zombie\"\"\"";
                    return str17;
                default:
                    string[] str18 = new string[5];
                    str18[0] = "\"tm_phoenix\"\"\"";
                    str18[1] = "\"tm_phoenix_variantA\"\"\"";
                    str18[2] = "\"tm_phoenix_variantB\"\"\"";
                    str18[3] = "\"tm_phoenix_variantC\"\"\"";
                    str18[4] = "\"tm_phoenix_variantD\"\"\"";
                    return str18;
            }
        }
    }

}

