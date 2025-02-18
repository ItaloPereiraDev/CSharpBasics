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
        public double ValorTotalEmEstoque()
        {
            return Preco*Quantia;
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
                +", e contendo "
                + Quantia
                + " unidades, Totalizando: $"
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
