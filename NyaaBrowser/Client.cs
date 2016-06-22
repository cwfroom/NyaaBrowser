using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyaaBrowser
{
    public class Client
    {
        public MainScr mainScr;
        public Data data;
        public WebFetch webFetch;

        public Client()
        {
            data = new Data(this);
            webFetch = new WebFetch();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainScr = new MainScr(this);
            Application.Run(mainScr);
        }

    }
}
