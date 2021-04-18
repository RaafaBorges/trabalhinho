using System;
using System.Collections.Generic;
using loja.model;
namespace loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatura f1 = new Fatura();
            Fatura f2 = new Fatura();
            Fatura f3 = new Fatura();

            Console.Clear();
            Console.WriteLine("\tProgram started" + DateTime.Now + "");
            // public Produto(string nome, decimal pu, decimal qtd, decimal stock) 
            Produto produto_1 = new Produto("HD 2GB", 5.1M, 75.5M, 80.0M);
            Produto produto_2 = new Produto("Pendrive 16GB", 10.2M, 75.5M, 80.0M);
            Produto produto_3 = new Produto("Motherboard", 9.3M, 75.5M, 80.0M);
            Produto produto_4 = new Produto("RAM memory 32GB", 80.4M, 75.5M, 80.0M);
            Produto produto_5 = new Produto("Case", 23.6M, 75.5M, 80.0M);
            Produto produto_6 = new Produto("Processor i7 8200 4.0Ghz", 3.7M, 75.5M, 80.0M);
            //  public Servico(string nome, decimal pu, decimal qtd, string responsavel, string morada)
            Servico servico_1 = new Servico("Network instalation", 80.0M, 5, "Xico", "Rua da Alegria");
            Servico servico_2 = new Servico("Swap memory", 195.0M, 9, "Marco", "Rua da Tristeza");
            Servico servico_3 = new Servico("Oil change", 30.0M, 10, "Lais", "Rua da Melancolia");
            Servico servico_4 = new Servico("Wheel refinement", 219, 45.4M, "Rafa", "Rua da Esperanca");
            Servico servico_5 = new Servico("Do supermarket buys", 9, 45.4M, "Rubens", "Rua do Amor");
            Servico servico_6 = new Servico("Uber run", 150.0M, 1, "Vitoria", "Rua da Luxuria");
            //inserindo na lista
            f1.Add(produto_1);
            f2.Add(produto_2);
            f2.Add(produto_3);
            f3.Add(produto_4);
            f1.Add(produto_5);
            f3.Add(produto_6);
            //inserindo na lista
            f2.Add(servico_1);
            f2.Add(servico_2);
            f1.Add(servico_3);
            f1.Add(servico_4);
            f3.Add(servico_5);
            f3.Add(servico_6);

            f1.getInfo();
            f2.getInfo();
            f3.getInfo();
            Console.ReadLine();



        }
    }
}
