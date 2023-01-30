public class Program
{
    static void Main(string[] args)
    {
        // 자연수 9개를 받음
        int[] num = new int[9];
        int max =0; //최댓값
        int count =0; // 순서

        for (int i = 0; i < 9; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
            // 만약 max가 num 보다 작다면
            if(max < num[i])
            {
                max = num[i]; // 그 숫자가 최대값
                count = i + 1; // 순서는 +1
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(count);
        
    }

}