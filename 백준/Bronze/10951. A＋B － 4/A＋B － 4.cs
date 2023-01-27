public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            string input = Console.ReadLine();
            if (input == null)
            {
                break;
            }

            string[] str = input.Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int sum = a + b;

            Console.WriteLine(sum);
        }
    }
}