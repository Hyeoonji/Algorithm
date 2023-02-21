public class Program
{
    static void Main(string[] args)
    {
        // 문제의 정수 N
        int N = int.Parse(Console.ReadLine());

        // 정수 자료형 1개 당 4
        int num = N / 4;

        for(int i = 0; i < num; i++)
        {
            Console.Write("long ");
        }
        Console.Write("int");

    }
}