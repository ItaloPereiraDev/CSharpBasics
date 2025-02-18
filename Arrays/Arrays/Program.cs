// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
double[] vect = new double[n];
double sum = 0;
for (int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine());
    sum += vect[i];
}
double avg = sum / n;
Console.WriteLine($"A altura média é de: {avg.ToString("F2")}m");
