using System;

namespace Car_Exercise
{
    class Pessoa{
        private string  nome;
        private string  telefone;
        private string  cpf;

        public  string getNome(){
            return nome;
        }

        public  string getTelefone(){
            return  telefone;
        }

        public  string getCPF(){
            return  cpf;
        }

        public  void setNome(string name){
            return nome;
        }

        public  void setTelefone(string tel){
            return  telefone;
        }
        /// Valida se a String não está vazia , e também se o tamanho dela é equivalente ao de um CPF
        public  void setCPF(string cod){
            if  ((!String.IsNullOrEmpty(cod))&&(cod.Length < 11)) {
                cpf = cod;
            }   else    throw new Exception("CPF informado '"+cod+"' é inválido");
        }
    }
}