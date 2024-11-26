using System;
using System.Globalization;
using System.Collections.Generic;

namespace Program {
    class Program {
        static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        List<Employee> list = [];

        Console.Write("How many employees will be registered? ");
        int N = int.Parse(Console.ReadLine());

        for (int i=1; i<=N; i++){
            Console.WriteLine("Employee #" + i);
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CI);

            list.Add(new Employee(id, name, salary));
            Console.WriteLine();
        }

        Console.Write("Enter the employee id that will have salary increase: ");
        int searchId = int.Parse(Console.ReadLine());

        Employee emp = list.Find(x => x.Id == searchId);
        if (emp != null) {
            Console.Write("Enter the percentage: ");
            double percent = double.Parse(Console.ReadLine(), CI);
            emp.IncreaseSalary(percent);
        }
        else {
            Console.WriteLine("This id does not exist!");
        }

        Console.WriteLine();
        Console.WriteLine("Updated list of employees: ");
        foreach(Employee obj in list) {
            Console.WriteLine(obj);
        }
        

        

}
}
}
