using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum BLOOD_TYPE {
    Group_A,
    Group_B,
    Group_AB,
    Group_O,
    UNSET
}

namespace CS_lab2 {
    class Client : User {
        private uint clientID { get; set; }
        private BLOOD_TYPE bloodType { get; set; }
        private uint assignedDoctor { get; set; }

        public Client() : base() {
            clientID = 0;
            bloodType = BLOOD_TYPE.UNSET;
            assignedDoctor = 0;
        }

        public Client(User _baseUser, uint _clientID, BLOOD_TYPE _bloodType, uint _assignedDoctor) : base(_baseUser) {
            clientID = _clientID;
            bloodType = _bloodType;
            assignedDoctor = _assignedDoctor;
        }
    }
}
