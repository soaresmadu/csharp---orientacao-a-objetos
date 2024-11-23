using System;
namespace Program {
    class ConversorDeMoeda {
            public static double IOF = 6.0;
            public static double DolarReal(double cotacaoDolar, double quantia) {
                double valorTotal = cotacaoDolar * quantia;
                return ((valorTotal * IOF)/100) + valorTotal;
            }

 }
}
