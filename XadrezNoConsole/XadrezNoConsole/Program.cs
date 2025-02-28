using System;
using XadrezNoConsole;
using XadrezNoConsole.Entities;
using XadrezNoConsole.Entities.ChessPieces;
using XadrezNoConsole.Entities.Enums;
using XadrezNoConsole.Entities.Exceptions;
using XadrezNoConsole.Entities.PosXadrez;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partida = new PartidaXadrez();
                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.executaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}