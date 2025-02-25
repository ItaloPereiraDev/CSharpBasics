try
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int result = n1 / n2;
    Console.WriteLine(result);
} catch (DivideByZeroException)
{
    Console.WriteLine("Division by 0 isn't allowed!");
} catch (FormatException)
{
    Console.WriteLine("Only numbers allowed!");
}