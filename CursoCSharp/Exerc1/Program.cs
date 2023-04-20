using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500, 10);
            Console.WriteLine(p);
            //Console.WriteLine("Entre os dados do produto: ");
            //Console.Write ("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine());
            //Console.Write("Quantidade: ");
            //p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque");
            //int add = int.Parse(Console.ReadLine());
            //p.AdicionarEstoque(add);
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine("Digite o número de produtos a ser removido do estoque");
            //int remove = int.Parse(Console.ReadLine());
            //p.removerEstoque(remove);
            //Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
