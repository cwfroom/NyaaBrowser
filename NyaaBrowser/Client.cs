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

        public Client()
        {
            data = new Data();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainScr = new MainScr(this);
            Application.Run(mainScr);
        }

    }
}
