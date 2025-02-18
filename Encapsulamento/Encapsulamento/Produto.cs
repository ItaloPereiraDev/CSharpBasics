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
        private double _preco;
        private int _quantia;

        public Produto(string nome, double preco, int quantia)
        {
            _nome = nome;
            _preco = preco;
            _quantia = quantia;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantia()
        {
            return _quantia;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantia;
        }

        public void adicionarQuantidade(int quantidade)
        {
            _quantia += quantidade;
        }
        public void removerQuantidade(int quantidade)
        {
            _quantia -= quantidade;
        }
        public override string ToString()
        {
            return _nome
                + ", com cada unidade valendo $"
                + _preco.ToString("F2")
                + ", e contendo "
                + _quantia
                + " unidades, Totalizando: $"
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
