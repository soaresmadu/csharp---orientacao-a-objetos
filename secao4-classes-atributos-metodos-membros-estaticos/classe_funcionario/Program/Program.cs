//Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

using System;
using System.Globalization;
namespace Program {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            double media;
           
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CI);

            media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salário Médio = R$ " + media.ToString("F2", CI));

 }
 }
}
