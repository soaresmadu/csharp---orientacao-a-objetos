﻿//Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema.

using System;
using System.Globalization;
namespace Program {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CI);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CI);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CI));

            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaFaltante().ToString("F2", CI) + " PONTOS");
            }

 }
 }
}

