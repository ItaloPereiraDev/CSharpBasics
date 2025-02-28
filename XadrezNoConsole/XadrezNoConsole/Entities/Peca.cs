using XadrezNoConsole.Entities.Enums;

namespace XadrezNoConsole.Entities
{
    class Peca
    {
        public Posicao Position { get; set; }
        public Cor Color { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor color)
        {
            Position = null;
            Color = color;
            Tab = tab;
            QtdMovimentos = 0;
        }
    }
}
