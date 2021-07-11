using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characther
{
    class Personagem
    {
        public string nome;
        public int idade;
        public bool jedi;
        public bool vivo;

        public Personagem(string nome, int idade, bool jedi, bool vivo)
        {
            this.nome = nome;
            this.idade = idade;
            this.jedi = jedi;
            this.vivo = vivo;
        }

        public bool isJedi()        {   return this.jedi;           }
        public bool isAlive()       {   return this.vivo;           }
        public void Char_Kill()     {   this.vivo = false;          }
        public void Char_Revive()   {   this.vivo = true;           }
        public void Char_Quebrado() {   this.vivo = !(this.vivo);   }

        public string Char_Details()
        {
            string aux;

            aux = this.nome + " is " + Convert.ToString(this.idade) + " years old";
            aux = aux + "\n";
            aux = this.isJedi() ? aux + this.nome + " is a Jedi" : aux + this.nome + " is not  Jedi";
            aux = aux + "\n";
            aux = this.isAlive() ? aux + this.nome + " is alive" : aux + this.nome + " is not alive D:";
            return aux;
        }
    }
}
