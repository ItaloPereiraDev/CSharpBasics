// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a ordem da matriz quadrada N:");
int n = int.Parse(Console.ReadLine());
int[,] matriz = new int[n, n];
for (int i = 0; i < n; i++) //Pra cada uma das linhas...
{
    string[] valores = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)//...Ele percorre as suas colunas
    {
        matriz[i, j] = int.Parse(valores[j]);
    }
}
/*

Console.WriteLine($"Diagonal principal:");

for (int i = 0;i < n; i++)
{
    Console.Write(matriz[i,i] + " ");
}

Esse é o jeito do professor, em baixo é o meu jeito

*/

int[] diagonalPrincipal = new int[n];

for (int i = 0; i < n; i++)
{
    diagonalPrincipal[i] = matriz[i, i];
}

Console.WriteLine($"Diagonal principal: {string.Join(" ", diagonalPrincipal)}");

int contagemNumerosNegativos = 0;

for (int i = 0; i < n; i++) //Repetindo novamente, pra checar números negativos. Essa é a estrutura base pra percorrer uma matriz.
{

    for (int j = 0; j < n; j++)
    {
        if (matriz[i, j] < 0)
        {
            contagemNumerosNegativos++;
        }
    }
}
Console.WriteLine($"Quantidade de números negativos: {contagemNumerosNegativos}");