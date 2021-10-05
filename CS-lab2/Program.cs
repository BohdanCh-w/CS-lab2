using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab2 {
    class Program {
        public static void printData(List<Doctor> doctors, List<Client> clients) {
            clients.ToList().ForEach(c => { Console.WriteLine(c.ToString()); });
            Console.WriteLine();
            doctors.ToList().ForEach(d => { Console.WriteLine(d.ToString()); });
            Console.WriteLine();
        }

        public static void createDictionaries(List<Doctor> doctors, List<Client> clients) {
            var clientTable = clients.OrderBy(c => c.userID).ToDictionary(c => c.userID, c => c);
            clientTable.ToList().ForEach(c => { Console.WriteLine(c.ToString()); });
            Console.WriteLine();

            var doctorTable = doctors.OrderBy(d => d.userID).ToDictionary(
                d => d.userID, d => clients.Where(c => c.assignedDoctor == d.userID));

            doctorTable.ToList().ForEach(d => { Console.WriteLine("Doctor id-" + d.Key);
                d.Value.ToList().ForEach(c => { Console.WriteLine("\t" + c.ToString()); });
            });
            Console.WriteLine();
        }

        public static void groupByBlood(List<Client> clients) {
            var clientsByBloodType = 
                from client in clients
                group client by client.data.bloodType into bloodGroup
                orderby bloodGroup.Key
                select bloodGroup;

            clientsByBloodType.ToList().ForEach(c => { Console.WriteLine("Blood type - " + c.Key);
                c.ToList().ForEach(cl => { Console.WriteLine("\t" + cl.ToString()); });
            });
            Console.WriteLine();
        }

        public static void  orderDoctorsByNumberOfClients(List<Doctor> doctors, List<Client> clients) {
            var doctorsSortedByNumberOfClients = doctors.OrderBy(d => clients.Where(c => c.assignedDoctor == d.userID).Count());      
            doctorsSortedByNumberOfClients.ToList().ForEach(d => { Console.WriteLine(d.ToString()); });
            Console.WriteLine();
        }

        static void Main(string[] args) {
            var testData = new ModelTest(); 
            var doctors = testData.Doctors;
            var clients = testData.Clients;

            
            printData(doctors, clients);
            createDictionaries(doctors, clients);
            groupByBlood(clients);
            orderDoctorsByNumberOfClients(doctors, clients);
            
        }
    }
}
