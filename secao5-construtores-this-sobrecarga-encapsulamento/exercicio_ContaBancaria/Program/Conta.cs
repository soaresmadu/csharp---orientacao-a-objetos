using System;
using System.Globalization;

namespace Program {
    class Conta {

        CultureInfo CI = CultureInfo.InvariantCulture;

        private int NumeroConta;
        public string Nome{get; set;}
        public double Saldo{get; private set;}

        public Conta(int numeroConta, string nome){
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public Conta(int numeroConta, string nome, double depositoInicial):this(numeroConta, nome){
            Saldo = depositoInicial;
        }

        public void Deposito(double valor){
            Saldo += valor;
        }
        
        public void Saque(double valor){
            Saldo = Saldo - valor - 5.0;
        }

        public override string ToString(){
                return "Conta "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CI);
            }
        }
}
