using System.Globalization;
using Entities;

namespace Query;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Enter the full file path: ");
        string path = Console.ReadLine()!;

        List<Employee> employees = new();

        using StreamReader sr = File.OpenText(path);
        while (!sr.EndOfStream)
        {
            string[] fields = sr.ReadLine()!.Split(',');
            string name = fields[0];
            string email = fields[1];
            double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

            employees.Add(new Employee(name, email, salary));
        }

        Console.Write("Enter salary: ");
        double salaryQuery = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"\nEmail of people whose salary is more than {salaryQuery:F2}:");
        var firstQuery = from employee in employees
                         where employee.Salary >= salaryQuery
                         select new 
                         {
                            employee.Email
                         };
        foreach (var employee in firstQuery)
        {
            Console.WriteLine(employee);
        }

        var secondQuery = employees.Where(employee => employee.Name![0] == 'M').Sum(employee => employee.Salary);
        Console.Write($"Sum of salary of people whose name starts with 'M': {secondQuery:F2}");



    }
}