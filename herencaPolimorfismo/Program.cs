using System;
using herencaPolimorfismo.Entities;

namespace Websupply {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>(n);

            for(int i = 1; i <=n; i++) {
                Console.WriteLine($"Employee #{i} data:");

                Console.Write("Outsourced (y/n)? ");
                char yesNo = char.Parse(Console.ReadLine());

                if (yesNo == 'y') {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    Employee outsourcedEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);

                    list.Add(outsourcedEmployee);
                } else {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    Employee employee = new Employee(name, hours, valuePerHour);
                    list.Add(employee);
                }

                Console.WriteLine("Payments: ");
                Console.WriteLine();

            }

        }
    }
}