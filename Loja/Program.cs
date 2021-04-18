using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Models;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i = new Item();
            
            Item i1 = new Item("Xpto", 10.5M, 5.7M);
            
            Produto p1 = new Produto();
            
            Produto p2 = new Produto("HD 2GB", 5.7M, 75.5M, 80.0M);
            
            Servico s1 = new Servico();
            
            Servico s2 = new Servico("Instalação de Rede", 10.0M, 45.4M, "Xico", "Rua da Alegria");

            Fatura f1 = new Fatura();
            f1.Add(s2);
            f1.Add(s1);
            f1.Add(p2);
            f1.Add(p1);
            f1.Add(i);
            f1.Add(i1);

            List<Item> supermercado = new List<Item>();
            supermercado.Add(i);
            supermercado.Add(i1);
            supermercado.Add(p1);
            supermercado.Add(p2);
            supermercado.Add(s1);
            supermercado.Add(s2);
            
            foreach(Item x in supermercado)
            {
                Console.WriteLine(x.getInfo()); //polimorfismo
            }

            Console.WriteLine(f1.getInfo());

            Console.ReadLine();
        }


    }
}