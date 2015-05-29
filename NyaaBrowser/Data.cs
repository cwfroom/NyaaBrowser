using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaaBrowser
{
    //load config file and save data
    public class Data
    {
        public bool isSukebei;
        public string[] normalCategories;
        public string[] sukebeiCategories;

        public Data()
        {
            isSukebei = false;
            
            //default catagory values
            normalCategories = new string[]{"All categories",
                                            "Anime",
                                            "Anime - Anime Music Video",
                                            "Anime - English-translated Anime",
                                            "Anime - Non-English-translated Anime",
                                            "Anime - Raw Anime",
                                            "Audio",
                                            "Audio - Lossless Audio",
                                            "Audio - Lossy Audio",
                                            "Literature",
                                            "Literature - English-translated Literature",
                                            "Literature - Non-English-translated Literature",
                                            "Literature - Raw Literature",
                                            "Live Action",
                                            "Live Action - English-translated Live Action",
                                            "Live Action - Live Action Promotional Video",
                                            "Live Action - Non-English-translated Live Action",
                                            "Live Action - Raw Live Action",
                                            "Pictures",
                                            "Pictures - Graphics",
                                            "Pictures - Photos",
                                            "Software",
                                            "Software - Applications",
                                            "Software - Games"};


            sukebeiCategories = new string[]{"All categories",
                                             "Art",
                                             "Art - Anime",
                                             "Art - Doujinshi",
                                             "Art - Games",
                                             "Art - Pictures",
                                             "Real Life",
                                             "Real Life - Photobooks & Pictures",
                                             "Real Life - Videos"
                                            };
            //load files
        }

        public string categoryCode(string category)
        {
            switch (category)
            {
                case "All categories":
                    return "0_0";
                case "Anime":
                    return "1_0";
                case "Anime - Anime Music Video":
                    return "1_32";
                case "Anime - English-translated Anime":
                    return "1_37";
                case "Anime - Non-English-translated Anime":
                    return "1_38";
                case "Anime - Raw Anime":
                    return "1_11";
                case "Audio":
                    return "3_0";
                case "Audio - Lossless Audio":
                    return "3_14";
                case "Audio - Lossy Audio":
                    return "3_15";
                case "Literature":
                    return "2_0";
                case "Literature - English-translated Literature":
                    return "2_12";
                case "Literature - Non-English-translated Literature":
                    return "2_39";
                case "Literature - Raw Literature":
                    return "2_13";
                case "Live Action":
                    return "5_0";
                case "Live Action - English-translated Live Action":
                    return "5_19";
                case "Live Action - Live Action Promotional Video":
                    return "5_22";
                case "Live Action - Non-English-translated Live Action":
                    return "5_21";
                case "Live Action - Raw Live Action":
                    return "5_20";
                case "Pictures":
                    return "4_0";
                case "Pictures - Graphics":
                    return "4_18";
                case "Pictures - Photos":
                    return "4_17";
                case "Software":
                    return "6_0";
                case "Software - Applications":
                    return "6_23";
                case "Software - Games":
                    return "6_24";
                case "Art":
                    return "7_0";
                case "Art - Anime":
                    return "7_25";
                case "Art - Doujinshi":
                    return "7_33";
                case "Art - Games":
                    return "7_27";
                case "Art - Pictures":
                    return "7_26";
                case  "Real Life":
                    return "8_0";
                case "Real Life - Photobooks & Pictures":
                    return "8_31";
                case "Real Life - Videos":
                    return "8_30";
                default:
                    return null;
            }
            
       }
        
        
    }
}
