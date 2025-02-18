namespace ParamsRefeOut
{
    internal class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
        public static void Triplicar(int origin, out int result)
        {
            result = origin*3;
        }
    }
}
