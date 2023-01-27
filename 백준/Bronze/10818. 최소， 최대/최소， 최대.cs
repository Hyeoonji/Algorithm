public class Program
{
    static void Main(string[] args)
    {
        // 정수의 개수 N
        int n = int.Parse(Console.ReadLine());
        // 최대 최소
        int max = int.MinValue;
        int min = int.MaxValue;
        // N개의 정수를 공백으로 주어짐
        string[] str = Console.ReadLine().Split();
        // 정수 배열
        int[] s = new int[n];

        for (int i = 0; i < n; i++)
        {
            s[i] = int.Parse(str[i]);
        }

        for (int i = 0; i < n; i++)
        {
            if (s[i] > max)
            {
                max = s[i];
            }
            if (s[i] < min)
            {
                min = s[i];
            }
        }
        Console.WriteLine("{0} {1}", min, max);
    }
}