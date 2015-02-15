using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    public class clsFrom
    {
        public Int64 profile_id { get; private set; }
        public string login { get; private set; }
        public string url { get; private set; }
        public string avatar { get; private set; }
        public string fname { get; private set; }
        public string sname { get; private set; }


        public clsFrom(string[] data)
        {
            Int64 _i = 0;
            if (Int64.TryParse(data[0], out _i))
                this.profile_id = _i;
            this.login = data[1];
            this.url = data[2];
            this.avatar = data[3];
            this.fname = data[4];
            this.sname = data[5];

        }

        public clsFrom(clsJSON_block block)
        {
            foreach (string[] line in block.data)
            {
                if (line[0].CompareTo("url") == 0) this.url = line[1];
                if (line[0].CompareTo("profile_id") == 0)
                {
                    Int64 _i = 0;
                    if (Int64.TryParse(line[1], out _i))
                        this.profile_id = _i;
                }
                if (line[0].CompareTo("fname") == 0) this.fname = line[1];
                if (line[0].CompareTo("sname") == 0) this.sname = line[1];
                if (line[0].CompareTo("login") == 0) this.login = line[1];
                if (line[0].CompareTo("avatar") == 0) this.avatar = line[1]; ;
            }
        }
    } 
}
