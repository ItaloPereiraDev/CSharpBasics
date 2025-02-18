// See https://aka.ms/new-console-template for more information
using ExercicioVetores;

Console.WriteLine("Digite a quantidade de quartos no hotel:");
int numeroDeQuartosNoHotel = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de estudantes para alugar quartos:");
int numeroEstudantes = int.Parse(Console.ReadLine());
DadosAluguel[] vect = new DadosAluguel[numeroDeQuartosNoHotel];

for (int i = 0; i < numeroEstudantes; i++)
{
    Console.WriteLine("Digite o nome do estudante:");
    string name = Console.ReadLine();
    Console.WriteLine("Digite o email do estudante:");
    string email = Console.ReadLine();
    Console.WriteLine("Qual quarto o estudante quer ficar?");
    int n = int.Parse(Console.ReadLine());
    vect[n] = new DadosAluguel { Name = name, Email = email };
}
Console.WriteLine($"Quartos alugados = ");
for (int i = 0; i < numeroDeQuartosNoHotel; i++)
{
    if (vect[i] != null)
    {
        Console.WriteLine($"Quarto {i}: Alugado por {vect[i].Name}, de email: {vect[i].Email}");
    }
    else { }
}