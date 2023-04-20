using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc1
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        // ---------------------> ORDEM CORRETA DE ESCREVER O CÓDIGO <---------------------------- //

            //  1 -> Atributos Privados 2 -> Auto Props 3 -> Construtores 4 -> Propriedades customizadas
            //  5 -> Outros métodos da classe

        // ---------------------> SOBRECARGA <---------------------- //
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarEstoque(int qtd)
        {
            Quantidade += qtd;
        }

        public void removerEstoque(int qtd)
        {
            Quantidade -= qtd;
        }
        public override string ToString()
        {
            return
                Nome
                + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidade(s), Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
