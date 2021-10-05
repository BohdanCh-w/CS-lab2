using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab2 {
    class AnalisisResult {
        public uint analisisID { get; set; }
        public double temparature { get; set; }
        public string bloodTest { get; set; }
        public Dictionary<string,string> other { get; set; }

        public AnalisisResult() {
            analisisID = 0;
            temparature = 0;
            bloodTest = "";
            other = null;
        }

        public AnalisisResult(uint _analisisID, double _temparature, string _bloodTest, Dictionary<string,string> _other) {
            analisisID = _analisisID;
            temparature = _temparature;
            bloodTest = _bloodTest;
            other = _other;
        }
    }
}
