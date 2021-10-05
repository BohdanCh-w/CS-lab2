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
                    new Client(new User(5, "Fifth"), 1, new PatientData(BLOOD_TYPE.Group_O, "Fifth location", new List<AnalisisResult>() )),
                    new Client(new User(6, "Sixth"), 2, new PatientData(BLOOD_TYPE.Group_B, "Sixth location", new List<AnalisisResult>() )),
                    new Client(new User(7, "Seventh"), 2, new PatientData(BLOOD_TYPE.Group_AB, "Seventh location", new List<AnalisisResult>() )),
                    new Client(new User(8, "Eighth"), 1, new PatientData(BLOOD_TYPE.Group_A, "Eighth location", new List<AnalisisResult>() )),
                    new Client(new User(9, "Ninth"), 3, new PatientData(BLOOD_TYPE.Group_B, "Ninth location", new List<AnalisisResult>() )),
                    new Client(new User(10, "Tenth"), 4, new PatientData(BLOOD_TYPE.Group_A, "Tenth location", new List<AnalisisResult>() )),
                    new Client(new User(11, "Eleventh"), 4, new PatientData(BLOOD_TYPE.Group_A, "Eleventh location", new List<AnalisisResult>() )),
                    new Client(new User(12, "Twelveth"), 2, new PatientData(BLOOD_TYPE.Group_AB, "Twelveth location", new List<AnalisisResult>() )),
                    new Client(new User(13, "Thirteenth"), 2, new PatientData(BLOOD_TYPE.Group_O, "Thirteenth location", new List<AnalisisResult>() )),
                    new Client(new User(14, "Fourteenth"), 4, new PatientData(BLOOD_TYPE.Group_A, "Fourteenth location", new List<AnalisisResult>() )),
                    new Client(new User(15, "Fifteenth"), 3, new PatientData(BLOOD_TYPE.Group_O, "Fifteenth location", new List<AnalisisResult>() )),
                    new Client(new User(16, "Sixteenth"), 2, new PatientData(BLOOD_TYPE.Group_B, "Sixteenth location", new List<AnalisisResult>() )),
                    new Client(new User(17, "Seventeenth"), 1, new PatientData(BLOOD_TYPE.Group_AB, "Seventeenth location", new List<AnalisisResult>() )),
                    new Client(new User(18, "Eighteenth"), 4, new PatientData(BLOOD_TYPE.Group_AB, "Eighteenth location", new List<AnalisisResult>() ))
                };
            }
        }
    }
}
