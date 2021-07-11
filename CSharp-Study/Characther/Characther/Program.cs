using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characther
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem_bonita(string charactere,int quant)
            {
                string aux = "";
                int i;

                for(i = 0; i < quant; i++)
                {
                    aux += charactere;
                }
                return aux;
            }

            Console.WriteLine(mensagem_bonita("*", 48));
            Personagem luke = new Personagem("Luke Skywalker", 21, true, true);
            Console.WriteLine(luke.Char_Details());

            Console.WriteLine(mensagem_bonita("*", 48));
            Personagem leia = new Personagem("Leia Skywalker", 21, false, true);
            leia.Char_Quebrado();
            leia.Char_Quebrado();
            Console.WriteLine(leia.Char_Details());

            Console.WriteLine(mensagem_bonita("*", 48));
            Personagem han = new Personagem("Han Solo", 26, false, false);
            Console.WriteLine(han.Char_Details());

            Console.ReadKey();
        }
    }
}
