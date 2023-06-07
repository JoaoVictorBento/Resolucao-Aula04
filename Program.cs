using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolução_da_aula_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variáveis

            string nome; string produto; string produto2;

            int quantidade; int quantidade2;

            //Boas-vindas

            Console.WriteLine(" Bem-vindo ao sistema de estoque do Conradito");

            Console.Write(" Digite o nome do funcionário responsável:");
            nome = Console.ReadLine();

            //Espaço

            Console.Write("\n\n");

            Console.Write($" O cadastro de estoque será feito no nome de {nome}");

            //Espaço

            Console.Write("\n\n");

            // Produtos cadastrados

            Console.WriteLine(" -- Cadastro de produtos -- ");

            //Primeiro produto 

            Console.Write(" Digite o nome do Produto :");

            produto = Console.ReadLine();

            //Espaço

            Console.Write("\n\n");

            Console.Write($" Digite a quantidade em estoque de {produto}");

            quantidade = Int32.Parse(Console.ReadLine());

            //Produto 2

            Console.Write(" Digite o nome do Produto 2:");

            produto2 = Console.ReadLine();

            //Espaço

            Console.Write("\n\n");

            Console.Write($" Digite a quantidade em estoque de {produto2}");

            quantidade2 = Int32.Parse(Console.ReadLine());

            //Variável do total de produtos

            int total_produtos = quantidade + quantidade2;

            //Espaço

            Console.Write("\n");

            //Produtos cadastrados

            Console.Write(" - Os produtos foram cadastrados com sucesso!");

            //Espaço

            Console.Write("\n");

            Console.WriteLine($" -- LISTA DE PRODUTOS CADASTRADOS POR {nome}");

            //Produto 

            Console.WriteLine($" {produto} contém {quantidade} itens em estoque");

            //Produto 2

            Console.WriteLine($" {produto2} contém {quantidade2} itens em estoque");

            //Total de produtos

            Console.WriteLine($" Total de itens no estoque: {total_produtos}");

            //Espaço

            Console.Write("\n");

            //Fim

            Console.Write(" ----- FIM DO SISTEMA -----");

            Console.ReadKey();

        }
    }
}
