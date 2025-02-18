using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;
            //Conversão implícita de tipos. A variável y, que é double, recebeu um float, porquê 4 bytes cabem dentro de 8.
            //Se você tenta fazer o contrário (colocar 8 em 4), você pode perder dados. Ainda dá, e pra isso se usa o casting.

            double a;
            int b;
            a = 5.1;
            b = (int)a; //Esse (int) é o casting.
            Console.WriteLine(b);

            int alpha = 5, beta = 2; //Pode-se criar várias variáveis do mesmo tipo (nesse caso, int) assim.
            float resultado = (float)alpha / beta;
            //O resultado é 2,5. Mas como são inteiros, ele dá 2 (que é int). Tem q botar o float. OU só escrever .0 nos números.
            float resultado2 = 5.0f/2.0f;
            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);
        }
    }
}