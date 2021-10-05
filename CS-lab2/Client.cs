using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum BLOOD_TYPE {
    Group_O,
    Group_A,
    Group_B,
    Group_AB,
    UNSET
}

namespace CS_lab2 {
    class Client : User {
        public BLOOD_TYPE bloodType { get; set; }
        public uint assignedDoctor { get; set; }

        public Client() : base() {
            bloodType = BLOOD_TYPE.UNSET;
            assignedDoctor = 0;
        }

        public Client(User _baseUser, BLOOD_TYPE _bloodType, uint _assignedDoctor) : base(_baseUser) {
            bloodType = _bloodType;
            assignedDoctor = _assignedDoctor;
        }

        public override string ToString() {
            return String.Format("id-{0} : {1}. Blood - {2}, Assigned to {3}", userID, name, bloodType, assignedDoctor);
        }
    }
}
