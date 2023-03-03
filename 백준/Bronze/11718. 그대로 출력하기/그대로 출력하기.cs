public class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        for (int i = 0; i < 100; i++)
        {
            list.Add(Console.ReadLine());
        }
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(list[i]);
        }

    }
}