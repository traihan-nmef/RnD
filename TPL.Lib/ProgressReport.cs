using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL.Lib
{
    public class ProgressReport
    {
        public ProgressReport(int index, string address)
        {
            this.Index = index;
            this.Address = address;
        }

        public int Index { get; set; }
        public string Address { get; set; }
        public string LogMessage { get; set; }

    }
}
