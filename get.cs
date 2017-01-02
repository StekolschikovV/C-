using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class get
    {
        public string s = "";
        public string r = "";

        public get(string s)
        {
            this.s = s;
            string Url = this.s;
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            this.r = sr.ReadToEnd();
            sr.Close();
        }

        public string getR()
        {
            return this.r;
        }

    }
}
