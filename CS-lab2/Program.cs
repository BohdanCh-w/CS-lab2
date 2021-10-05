using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab2 {
    class Program {
        public static void printData(List<Doctor> doctors, List<Client> clients) {
            foreach (var client in clients) {
                Console.WriteLine(client.ToString());
            }
            Console.WriteLine();
            foreach (var doctor in doctors) {
                Console.WriteLine(doctor.ToString());
            }
            Console.WriteLine();
        }

        public static void createDictionaries(List<Doctor> doctors, List<Client> clients) {
            var clientTable = clients.OrderBy(c => c.userID).ToDictionary(c => c.userID, c => c);
            foreach (var client in clientTable) {
                Console.WriteLine(client);
            }
            Console.WriteLine();
            var doctorTable = doctors.OrderBy(d => d.userID).ToDictionary(
                d => d.userID, d => clients.Where(c => c.assignedDoctor == d.userID));
            foreach (var doctor in doctorTable) {
                Console.WriteLine("Doctor id-" + doctor.Key);
                foreach (var client in doctor.Value) {
                    Console.WriteLine("\t" + client.ToString());
                }
            }
            Console.WriteLine();
        }

        public static void groupByBlood(List<Client> clients) {
            var clientsByBloodType = 
                from client in clients
                group client by client.bloodType into bloodGroup
                orderby bloodGroup.Key
                select bloodGroup;
            foreach (var client in clientsByBloodType) {
                Console.WriteLine("Blood type - " + client.Key);
                foreach (var cl in client) {
                    Console.WriteLine("\t" + cl.ToString());
                }
            }
            Console.WriteLine();
        }

        public static void  orderDoctorsByNumberOfClients(List<Doctor> doctors, List<Client> clients) {
            var doctorsSortedByNumberOfClients = doctors.OrderBy(d => clients.Where(c => c.assignedDoctor == d.userID).Count());
            foreach (var doctor in doctorsSortedByNumberOfClients) {
                Console.WriteLine(doctor.ToString());
            }
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
