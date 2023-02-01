public class Program
{
    static void Main(string[] args)
    {
        // 케이스의 개수
        int num = int.Parse(Console.ReadLine());
        string[] str = new string[num];
        int[] arr = new int[num];

        for (int i = 0; i < str.Length; i++)
        {
            str[i] = Console.ReadLine();

            // 각각의 점수
            int score = 0;
            int count = 1;

            for (int j = 0; j < str[i].Length; j++)
            {
                if (str[i][j] == 'O')
                {
                    score += count;
                    count++;
                }
                if (str[i][j] == 'X')
                {
                    count = 1;
                }
            }
            arr[i] = score;
        }
        foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}