using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_29_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pessoa\n");
            Pessoa Pes = new Pessoa();
            Console.WriteLine(Pes);

            Console.WriteLine("\n");

            Console.WriteLine("Empregado\n");
            Empregado Emp = new Empregado();
            Console.WriteLine(Emp);

            Console.WriteLine("\n");

            Console.WriteLine("Operario\n");
            Operario Ope = new Operario();
            Console.WriteLine(Ope);

            Console.WriteLine("\n");

            Console.WriteLine("Vendedor\n");
            Vendedor Ven = new Vendedor();
            Console.WriteLine(Ven);

            Console.WriteLine("\n");

            Console.WriteLine("Administrador\n");
            Administrador Adm = new Administrador();
            Console.WriteLine(Adm);

            Console.WriteLine("\n");

            Console.WriteLine("Fornecedor\n");
            Fornecedor For = new Fornecedor();
            Console.WriteLine(For);
        }
    }
}
