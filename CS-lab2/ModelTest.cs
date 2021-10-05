using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab2 {
    class ModelTest {
        public List<Doctor> Doctors { 
            get {
                return new List<Doctor>() {
                    new Doctor(new User(1, "First"), "Internist"),
                    new Doctor(new User(2, "Second"), "Psychiatrist"),
                    new Doctor(new User(3, "Third"), "Neurologist"),
                    new Doctor(new User(4, "Fourth"), "Anesthesiologist")
                };
            }
        }

        public List<Client> Clients {
            get {
                return new List<Client>() {
                    new Client(new User(5, "Fifth"), BLOOD_TYPE.Group_O, 1),
                    new Client(new User(6, "Sixth"), BLOOD_TYPE.Group_B, 2),
                    new Client(new User(7, "Seventh"), BLOOD_TYPE.Group_AB, 2),
                    new Client(new User(8, "Eighth"), BLOOD_TYPE.Group_A, 1),
                    new Client(new User(9, "Ninth"), BLOOD_TYPE.Group_B, 3),
                    new Client(new User(10, "Tenth"), BLOOD_TYPE.Group_A, 4),
                    new Client(new User(11, "Eleventh"), BLOOD_TYPE.Group_A, 4),
                    new Client(new User(12, "Twelveth"), BLOOD_TYPE.Group_AB,5),
                    new Client(new User(13, "Thirteenth"), BLOOD_TYPE.Group_O, 2),
                    new Client(new User(14, "Fourteenth"), BLOOD_TYPE.Group_A, 5),
                    new Client(new User(15, "Fifteenth"), BLOOD_TYPE.Group_O, 3),
                    new Client(new User(16, "Sixteenth"), BLOOD_TYPE.Group_B, 2),
                    new Client(new User(17, "Seventeenth"), BLOOD_TYPE.Group_AB, 1),
                    new Client(new User(18, "Eighteenth"), BLOOD_TYPE.Group_AB, 4)
                };
            }
        }
    }
}
