using System;
using System.Globalization;

namespace Program {
    class Employee {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public int Id{get;set;}
        public string Name{get;set;}
        public double Salary{get; private set;}

        public Employee(int id, string name, double salary){
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percent){
            double increase = (Salary * percent) / 100;
            Salary += increase;
        }

        public override string ToString(){
            return Id
            + ", "
            + Name
            + ", $"
            + Salary.ToString("F2", CI);
        }

    }
}
