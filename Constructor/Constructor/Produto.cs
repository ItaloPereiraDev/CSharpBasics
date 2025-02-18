using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaAulaObjetos
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantia;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantia = quantidade;
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantia = 5;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantia;
        }

        public void adicionarQuantidade(int quantidade)
        {
            Quantia += quantidade;
        }
        public void removerQuantidade(int quantidade)
        {
            Quantia -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", com cada unidade valendo $"
                + Preco.ToString("F2")
                + ", e contendo "
                + Quantia
                + " unidades, Totalizando: $"
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
