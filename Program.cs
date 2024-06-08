using System;
 
namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Sistema de Cadastro de produtos");
            Console.WriteLine("1)cadastrar \n 2)verificar estoque\n 3)sair");
            string opcao = Console.ReadLine();
            switch(opcao)
            {
                case 1 :
                {
                    Console.WriteLine("Digite o nome do produto :");
                    Produto.NomeProduto = Console.ReadLine();
                    Console.WriteLine("Digite a categoria :");
                    Produto.categoria = Console.ReadLine();
                    Console.WriteLine("Digite o valor :");
                    Produto.valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o código de barraas :");
                    produto.codigobarras = int.Parse(Console.ReadLine());
                    break;

                }
                case 2 :
                {
                    
                }
            }




        }
        }
        }