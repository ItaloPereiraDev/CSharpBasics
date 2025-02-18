// See https://aka.ms/new-console-template for more information
//Matrizes são praticamente vetores bidimensionais
double[,] matriz = new double[2, 3]; //Instanciou na memória uma matriz de 2 linhas e 3 colunas.
Console.WriteLine(matriz.Length); //6, porquê mostra a quantidade total de elementos
Console.WriteLine(matriz.Rank); //2, mostra a primeira dimensão da matriz, no caso, a quantia de linhas
Console.WriteLine(matriz.GetLength(0));// 2, mostra a quantia de linhas, mesma coisa (?)
Console.WriteLine(matriz.GetLength(1));// 3, mostra a quantia de colunas
