using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_lab2 {
    class User {
        public uint userID { get; set; }
        public string name { get; set; }

        public User() {
            userID = 0;
            name = "";
        }
 
        public User(uint _userID, string _name) {
            userID = _userID;
            name = _name;
        }

        public User(User other) {
            userID = other.userID;
            name = other.name;
        }

        public override string ToString() {
            return String.Format("id-{0}: {1}.", userID, name);
        }
    }
}
