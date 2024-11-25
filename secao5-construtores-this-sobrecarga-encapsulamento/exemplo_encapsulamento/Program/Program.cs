using System;
using System.Globalization;
namespace Program {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Produto p = new Produto("TV", 500, 10);

            Console.WriteLine(p.GetNome());
            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());

            Console.WriteLine();
            Console.WriteLine("Preço: " + p.GetPreco().ToString("F2", CI));
            Console.WriteLine("Quantidade: " + p.GetQuantidade());

            Console.WriteLine();
            p.AdicionarProdutos(10);
            Console.WriteLine("Preço: " + p.GetPreco().ToString("F2", CI));
            Console.WriteLine("Quantidade: " + p.GetQuantidade());

            Console.WriteLine();
            p.RemoverProdutos(10);
            Console.WriteLine("Valor total: " + p.ValorTotalEmEstoque().ToString("F2", CI));
            Console.WriteLine("Quantidade: " + p.GetQuantidade());
            
}
}
}
