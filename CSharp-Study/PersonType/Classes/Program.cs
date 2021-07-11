using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_0605
{
    class Program
    {
        static void Main(string[] args)
        {
            PF pf1 = new PF(333, "Luke");
            PF pf2 = new PF(111, "Leia");
            
            PJ pj1 = new PJ(999, "Viceri");
            PJ pj2 = new PJ(333, "LAZco");
            
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Comparando { pf1.GetNome()} com {pf2.GetNome()} = {pf1.CompararCom(pf2)}");
            Console.WriteLine($"A pessoa {pf1.GetNome()} é {pf1.GetTipo()}");
            Console.WriteLine($"A pessoa {pf2.GetNome()} é {pf1.GetTipo()}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Comparando { pj1.GetRazaoSocial()} com {pj2.GetRazaoSocial()} = {pj1.CompararCom(pj2)}");
            Console.WriteLine($"A pessoa {pj1.GetRazaoSocial()} é {pj1.GetTipo()}");
            Console.WriteLine($"A pessoa {pj2.GetRazaoSocial()} é {pj2.GetTipo()}");
            Console.WriteLine("----------------------------------------------------");
            Console.Read();
        }
    }
}
