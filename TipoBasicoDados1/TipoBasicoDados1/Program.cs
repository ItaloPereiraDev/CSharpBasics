using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 127;
            x++;
            int y = 1000;
            int z = 2147483647;
            long alpha = 2147483648L;
            //Todos esses números só tem diferença no tamanho do número e se é positivo ou negativo.
            //Usar L quando usar uma variável long
            float numeroquebrado = 4.5f;
            //Colocar f no final pra dizer que é float.
            //Se não ele identifica como double (mesma coisa, só que mais longo)
            double numeromuitoquebrado = 4.572624542729192;
            string frase = "Maria é viadinha"; // Frase completa é string. É imutável, depois de criada, adeus.
            bool booleano = false;
            char caractere = 'S'; //Pode colocar o código UNICODE do caractere também
            //Toda classe em C# é uma subclasse de um object, então meio que tudo é um objeto. Por exemplo:
            object Objeto1 = "Fulaninho doido";
            object Objeto2 = 4.27f;
            //E pra finalizar, também dá pra pegar os valores mínimos e máximos da cada um sem ter que decorar
            int intmaximo = int.MaxValue;
            int intminimo = int.MinValue;
            sbyte sbyteminimo = sbyte.MinValue;
            sbyte sbytemaximo = sbyte.MaxValue;
            decimal decimalmax = decimal.MaxValue;
            double doublemax = double.MaxValue;
            double minimo = double.MinValue;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(alpha);
            Console.WriteLine(booleano);
            Console.WriteLine(caractere);
            Console.WriteLine(numeroquebrado);
            Console.WriteLine(numeromuitoquebrado);
            Console.WriteLine(frase);
            Console.WriteLine(Objeto1);
            Console.WriteLine(Objeto2);
            Console.WriteLine(intmaximo);
            Console.WriteLine(intminimo);
            Console.WriteLine(sbyteminimo);
            Console.WriteLine(sbytemaximo);
            Console.WriteLine(decimalmax);
            Console.WriteLine(doublemax);
            Console.WriteLine(minimo);
        }
    }
}