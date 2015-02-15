using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    class clsSerchedProject
    {
        public int pageNum { get; private set; }
        public cntrlProject control { get; private set; }

        public clsSerchedProject(int pageNum, cntrlProject control)
        {
            this.pageNum = pageNum;
            this.control = control;
        }
    }
}
