using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab2 { 
    class Doctor : User {
        private uint doctorID { get; set; }
        private string specialisation { get; set; }

        public Doctor() : base() {
            doctorID = 0;
            specialisation = "";
        }

        public Doctor(User _baseUser, uint _doctorID, string _specialisation) : base(_baseUser) {
            doctorID = _doctorID;
            specialisation = _specialisation;
        }
    }
}
