namespace MembrosEstaticos
{
    internal class Calculadora
    {
        public static double Circunf(double r)
        {
            return (Math.PI * r * 2.0);
        }
        public static double Vol(double r)
        {
            return (4.0 / 3.0) * (Math.PI * Math.Pow(r, 3.0));
        }
    }
}
