using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace NyaaBrowser
{
    public class WebFetch
    {

        string keyword;
        Dictionary<string, string> htmlCode;

        public WebFetch()
        {
            htmlCode = new Dictionary<string, string>();
            htmlCode.Add("&#32;", " ");
            htmlCode.Add("&#33;", "!");
            htmlCode.Add("&#34;", "\"");
            htmlCode.Add("&#35;", "#");
            htmlCode.Add("&#36;", "$");
            htmlCode.Add("&#37;", "%");
            htmlCode.Add("&#38;", "&");
            htmlCode.Add("&#39;", "'");           
            htmlCode.Add("&#40;", "(");
            htmlCode.Add("&#41;", ")");         
            htmlCode.Add("&#42;", "*");
            htmlCode.Add("&#43;", "+");
            htmlCode.Add("&#44;", ",");
            htmlCode.Add("&#45;", "-");
            htmlCode.Add("&#46;", ".");
            htmlCode.Add("&#47;", "/");
            htmlCode.Add("&#58;", ":");
            htmlCode.Add("&#59;", ";");
            htmlCode.Add("&#60;", "<");
            htmlCode.Add("&#61;", "=");
            htmlCode.Add("&#62;", ">");
            htmlCode.Add("&#63;", "?");
            htmlCode.Add("&#64;", "@");
            
        }

        public List<string> fetch(string[] filter)
        {
            // string url =  "http://www.nyaa.se/?page=search&";
            WebClient webclient = new WebClient();
            //string html = webclient.DownloadString("http://www.nyaa.se/");
            string html = webclient.DownloadString("http://www.nyaa.se/?page=search&cats=0_0&filter=0&term=%5BOhys-Raws%5D+Macross+Delta");
            //Console.Write(html);

            keyword = "[Ohys-Raws] Macross Delta";

            List<string> results = new List<string>();
            parsehtml(html,ref results);

            return results;
          }

        public void parsehtml(string source, ref List<string> results)
        {
            char[] separatingTags = {'<', '>'};

            string[] temp = source.Split(separatingTags);
            string downloadLink = "a href=\"//www.nyaa.se/?page=download";
            for(int i=0;i<temp.Length;i++){
                //filter short strings to save time
                if (temp[i].Length >= keyword.Length || temp[i].Length >= downloadLink.Length)
                {
                     if (partialStringMatch(keyword, temp[i])){
                        //save keyword
                        //download link should be saved at keyword[+7]    
                        //should be be an issue if webpage is downloaded properly, just in case
                        if (i+7 <= temp.Length)
                        {
                            if (partialStringMatch(downloadLink, temp[i + 7]))
                            {
                                //download link matched
                                //TODO: parse file name and tid
                                results.Add(htmlCodeReplace(temp[i]));
                                results.Add(getTid(temp[i + 7]));
                            }

                        }

                    }
                }
            }
            
        }

        private bool partialStringMatch(string key, string other)
        {
            for (int i=0;i<key.Length;i++)
            {
                if (key[i] != other[i])
                {
                    return false;
                }
            }
            return true;
        }

        private string htmlCodeReplace(string str)
        {
            foreach (KeyValuePair<string, string> entry in htmlCode)
            {
                str = str.Replace(entry.Key, entry.Value);
            }
            return str;
        }

        private string getTid(string str)
        {
            char[] seperator = {'=','\"'};
            string[] temp =  str.Split(seperator);
            return temp[4];
        }
    }
}
