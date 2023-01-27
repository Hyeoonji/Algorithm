public class Program // 10952. A + B - 5 
{
    static void Main(string[] args)
    {
        while(true)
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int sum = a + b;

            if(a == 0 && b == 0) 
            {
                break;
            }
            Console.WriteLine(sum);
        }
    }
}