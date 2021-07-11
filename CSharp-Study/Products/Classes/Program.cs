using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXS_PRODUTO
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_Escolha;
            int v_garantia;
            double v_Preco;
            string v_descri;
            string v_fabricante;
            string v_dt_valid;
            string v_dt_fabri;

            Random v_codigo  = new Random();
            int rand_codigo = v_codigo.Next();

            Console.WriteLine("Qual o tipo de produto ?\n" +
                                "1 - Perecivel\t" +
                                "2- Nao Perecivel\n"
                              );

            v_Escolha = int.Parse(Console.ReadLine());

            switch (v_Escolha)
            {
                case 1:
                    Console.WriteLine("Informe o Preço :\t");
                    v_Preco = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a Descrição :\t");
                    v_descri = Console.ReadLine();
                    Console.WriteLine("Informe o Fabricante :\t");
                    v_fabricante = Console.ReadLine();

                    Console.WriteLine("Informe a Validade :\t");
                    v_dt_valid = Console.ReadLine();
                    Console.WriteLine("Informe a Fabricacao :\t");
                    v_dt_fabri = Console.ReadLine();

                    DateTime v_dt_valid_conv = DateTime.ParseExact(v_dt_valid, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime v_dt_fabri_conv = DateTime.ParseExact(v_dt_fabri, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                    Perecivel Per = new Perecivel(rand_codigo, v_Preco, v_descri, v_fabricante, v_dt_valid_conv, v_dt_fabri_conv);
                    Console.WriteLine(Per);
                    break;

                case 2:
                    Console.WriteLine("Informe o Preço :\t");
                    v_Preco = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a Descrição :\t");
                    v_descri = Console.ReadLine();
                    Console.WriteLine("Informe o Fabricante :\t");
                    v_fabricante = Console.ReadLine();
                    Console.WriteLine("Informe a Garantia :\t");
                    v_garantia = int.Parse(Console.ReadLine());

                    Nao_Perecivel NPer = new Nao_Perecivel(rand_codigo, v_Preco, v_descri, v_fabricante, v_garantia);
                    Console.WriteLine(NPer);
                    break;
            }
            Console.ReadKey();
        }
    }
}
