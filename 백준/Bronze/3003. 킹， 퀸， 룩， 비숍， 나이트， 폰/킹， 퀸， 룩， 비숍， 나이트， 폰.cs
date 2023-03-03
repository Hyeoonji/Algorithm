public class Program
{
    static void Main(string[] args)
    {
        // 킹(1), 퀀(1), 룩(2), 비숍(2), 나이트(2), 폰(8)
        string[] str = Console.ReadLine().Split();
        int[] che = { 1, 1, 2, 2, 2, 8 };
        for(int i = 0; i < str.Length; i++)
        {
            che[i] -= int.Parse(str[i]);
        }
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write(che[i]);
            Console.Write(" ");
        }
        
    }
}