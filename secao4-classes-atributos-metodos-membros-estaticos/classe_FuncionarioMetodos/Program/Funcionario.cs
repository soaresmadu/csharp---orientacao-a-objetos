using System;
using System.Globalization;

namespace Program {
    class Funcionario {

        CultureInfo CI = CultureInfo.InvariantCulture;
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcent){
            SalarioBruto += (SalarioBruto * (porcent))/100;
        }

        public override string ToString() {
            return Nome
            + ", R$"
            + SalarioLiquido().ToString("F2", CI);
        }
    }
}
