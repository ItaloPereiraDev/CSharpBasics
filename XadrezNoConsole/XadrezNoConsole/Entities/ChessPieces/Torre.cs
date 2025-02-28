using XadrezNoConsole.Entities.Enums;

namespace XadrezNoConsole.Entities.ChessPieces
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
