using System;
using System.Collections.Generic;

namespace Program {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual será a ordem da matriz? ");
            int N = int.Parse(Console.ReadLine());
            double[,] mat = new double [N,N];

            for (int i=0; i<N; i++){
            string[] valores = Console.ReadLine().Split(' ');
                for (int j=0; j<N; j++){
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Diagonal Principal: ");
            for (int i=0; i<N; i++){
                Console.Write(mat[i,i] + " ");
            }

            Console.WriteLine();
            int neg = 0;
            for (int i=0; i<N; i++){
                for (int j=0; j<N; j++){
                    if (mat[i,j] < 0){
                        neg++;
                    }
                }
            }
            Console.Write("Número de negativos: " + neg);

}
}
}
