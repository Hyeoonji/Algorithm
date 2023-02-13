public class Program
{
    static void Main(string[] args)
    {
        // 한수: 등차수열 an = a1 + (n-1)d
        // 1- 99까지는 모두 등차수열
        // 1-99 100- 으로 구분해야 함

        // 첫째줄에 자연수 N
        int n = int.Parse(Console.ReadLine());
        // 한수의 개수를 기록할 변수
        int count = 0;

        // 1 <= 한수 >= N / 한수의 개수 출력
        for(int i = 1; i <= n; i++)
        {
            // 만약 한수라면 count
            if (IsHansu(i.ToString()))
            {
                count++;
            }
        }
        Console.WriteLine(count);

        // 한수를 구할 공식작성
        // Bool을 통해 맞는지 아닌지 확인
        static bool IsHansu(string num)
        {
            // 100 미만은 모두 한수
            if(int.Parse(num) < 100)
            {
                return true;
            }
            
            // 3자리를 각각 구분
            int[] number = new int[num.Length];
            for(int i = 0; i<number.Length; i++) 
            {
                number[i] = int.Parse(num[i].ToString());
            }
            // 백의 자리 - 십의 자리 == 십의자리 - 일의자리
            if (number[0] - number[1] == number[1] - number[2]) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}