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
        string normaldownloadURL = "http://www.nyaa.se/?page=download&tid=";
        string sukebeidownloadURL = "http://sukebei.nyaa.se/?page=download&tid=";
        private List<string> results;

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

        public List<string> fetch(string[] filters, bool isSukebei)
        {
            string url;
            if (!isSukebei)
            {
                url = "http://www.nyaa.se/?page=search&cats=" + filters[0] + "&filter=0";
            }else
            {
                url = "http://sukebei.nyaa.se/?page=search&cats=" + filters[0] + "&filter=0";
            }

            
            if (filters[2].Length != 0)
            {
                url = url + "&term=" + filters[2];
            }
            keyword = filters[2];
            url = url + "&user=" + filters[1];

            Console.WriteLine(url);

            WebClient webclient = new WebClient();

            byte[] htmlraw = webclient.DownloadData(url);
            string html = Encoding.UTF8.GetString(htmlraw);
            
            results = new List<string>();
            parsehtml(html,isSukebei,ref results);

            return results;
          }

        public void parsehtml(string source, bool isSukebei, ref List<string> results)
        {
            char[] separatingTags = {'<', '>'};

            string[] temp = source.Split(separatingTags);
            string downloadLink;
            if (!isSukebei)
            {
                downloadLink = "a href=\"//www.nyaa.se/?page=download";
            }else
            {
                downloadLink = "a href=\"//sukebei.nyaa.se/?page=download";
            }
            
            for(int i=0;i<temp.Length;i++){
                //filter short strings to save time when keyword is used
                if (temp[i].Length >= keyword.Length || temp[i].Length >= downloadLink.Length)
                {
                     if (temp[i].Contains(keyword)){
                        //save keyword
                        //download link should be saved at [+7]
                        //size should be at [+16]    
                        //should not be an issue if webpage is downloaded properly, just in case
                        if (i+16 <= temp.Length)
                        {
                            if(temp[i+7].Contains(downloadLink))
                            {
                                //download link matched
                                results.Add(htmlCodeReplace(temp[i]));
                                results.Add(getTid(temp[i + 7]));
                                results.Add(temp[i + 16]);
                            }

                        }

                    }
                }
            }

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

        public void DownloadTorrent(string path, int[] tid, bool isSukebei)
        {
            WebClient webclient = new WebClient();
            if (!isSukebei)
            {
                for (int i=0;i<tid.Length; i++)
                {
                    
                    webclient.DownloadFile(normaldownloadURL + results[tid[i] * 3 + 1], path + "\\" + results[tid[i]*3] + ".torrent");
                    
                }

            }
        }

    }
}
