//Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. 

using System;
using System.Globalization;
namespace Program {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Retangulo ret = new Retangulo();

            Console.Write("Largura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Altura do retângulo: ");
            ret.Altura = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine();
            Console.WriteLine("ÁREA = " + ret.Area().ToString("F2", CI));
            Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("F2", CI));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CI));
            
 }
 }
}
