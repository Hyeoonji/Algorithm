public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse((Console.ReadLine())); // 첫째줄에 받기
        int m = n;
        int count = 0; // 횟수
        while (true)
        {
            int t = m / 10; // 십의 자리
            int a = m % 10; // 일의 자리

            m = ((a * 10) + (t + a)%10); 
            // 일의 자리가 12가 된다면 2만 가져가기
            count++;
            if (m == n)
            {
                break;
            }
        }
        Console.WriteLine(count);
        
    }
}