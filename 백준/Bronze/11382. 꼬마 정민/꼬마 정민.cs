public class Program
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split(" ");
        double A = double.Parse(str[0]);
        double B = double.Parse(str[1]);
        double C = double.Parse(str[2]);

        Console.WriteLine(A + B + C);
    }
}