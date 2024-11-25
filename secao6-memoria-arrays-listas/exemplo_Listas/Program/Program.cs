using System;
using System.Collections.Generic;

namespace Program {
    class Program {
        static void Main(string[] args) {
            
        List<string> list = new List<string>();

        //adicionar dados na lista
        list.Add("Maria");
        list.Add("Alex");
        list.Add("Davi");
        list.Add("Ana");
        //adicionar e escolher o indice
        list.Insert(2, "Marco");
        foreach(string obj in list){
            Console.WriteLine(obj);
        }
        Console.WriteLine("-----------------");

        //mostrar tamanho da lista
        Console.WriteLine("Count " + list.Count);
        Console.WriteLine("-----------------");

        //encontrar o primeiro item na lista baseado em algum critério
        string s1 = list.Find(x => x[0] == 'A');
        Console.WriteLine("Primeiro com A: " + s1);
        //encontrar o último item na lista baseado em algum critério
        string s2 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine("Primeiro com A: " + s2);
        //encontrar a posição do primeiro item baseado em algum critério
        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine("Posição primeiro: " + pos1);
        //encontrar a posição do último item baseado em algum critério
        int pos2 = list.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine("Posição último: " + pos2);
        Console.WriteLine("-----------------");

        //filtrar a lista
        List<string> list2 = list.FindAll(x => x.Length == 5);
        foreach (string obj in list2){
            Console.WriteLine(obj);
        }
        Console.WriteLine("-----------------");

        //remover elementos da lista
        list.Remove("Alex");
        foreach(string obj in list){
            Console.WriteLine(obj);
        }
        Console.WriteLine("-----------------");

        //remover todos baseado em um critério
        list.RemoveAll(x => x[0] == 'M');
        foreach(string obj in list){
            Console.WriteLine(obj);
        }
        Console.WriteLine("-----------------");

        //remover de uma posicao especifica
        list.RemoveAt(0);
        foreach(string obj in list){
            Console.WriteLine(obj);
        }
        Console.WriteLine("-----------------");

        //criando uma nova lista
        List<string> list3 = new List<string>(){"Maria", "Ana", "Joao", "Eduardo", "Carlos", "Nayara"};
        foreach(string obj in list3){
            Console.WriteLine(obj);
        }
        Console.WriteLine("-----------------");

        //removendo uma faixa
        list3.RemoveRange(2, 2);
        foreach(string obj in list3){
            Console.WriteLine(obj);
        }
        Console.WriteLine("-----------------");


}
}
}
