﻿namespace XadrezNoConsole.Entities
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
        public override string ToString()
        {
            return ($"Posição: Linha {Linha}, Coluna {Coluna}");
        }
    }
}
