using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_lab2 {
    class User {
        private uint userID { get; set; }
        private string name { get; set; }
        private DateTime birthDate { get; set; }
        private string gender { get; set; }
        private DateTime registerDateTime { get; set; }

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
    }
}
