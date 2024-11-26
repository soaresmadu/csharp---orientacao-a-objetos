using System;

namespace Program {
    class Estudante {

        public string Nome;
        public string Email;

        public Estudante(string nome, string email){
            Nome = nome;
            Email = email;
        }

        public override string ToString(){
            return Nome
            + ", "
            + Email;
        }

    }
}
