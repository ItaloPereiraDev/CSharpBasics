using System;
using XadrezNoConsole;
using XadrezNoConsole.Entities;
using XadrezNoConsole.Entities.ChessPieces;
using XadrezNoConsole.Entities.Enums;
using XadrezNoConsole.Entities.Exceptions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro Tab = new Tabuleiro(8, 8);
                Tab.colocarPeca(new Torre(Tab, Cor.Preta), new Posicao(0, 0));
                Tab.colocarPeca(new Torre(Tab, Cor.Preta), new Posicao(1, 3));
                Tab.colocarPeca(new Rei(Tab, Cor.Preta), new Posicao(2, 4));
                Tela.imprimirTabuleiro(Tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}