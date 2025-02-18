using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaAulaObjetos
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantia { get; private set; }

        public Produto(string nome, double preco, int quantia)
        {
            _nome = nome;
            Preco = preco;
            Quantia = quantia;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome
                + ", com cada unidade valendo $"
                + Preco.ToString("F2")
                + ", e contendo "
                + Quantia
                + " unidades, Totalizando: $"
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
