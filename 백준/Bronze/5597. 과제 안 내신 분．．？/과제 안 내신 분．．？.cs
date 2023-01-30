public class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[30]; //30개 -> 받는건 28이지만 30까지

        for (int i = 0; i < 28; i++)
        {
            int n = int.Parse(Console.ReadLine()); // 번호에 숫자를 받음
            // num[n] = 1; 숫자를 받으면 1로 표시 --> 에러발생
            // -> 받는건 1부터 시작하는데 0부터 저장하려고 해서 n-1로 수정
            num[n-1] = 1;
        }
        for (int i = 0; i < 30; i++)
        {
            if (num[i] != 1)  // 1~30중에 1이 안들어 있는 번호
            {
                Console.WriteLine(i+1); // 번호 출력
            }
        }
    }
}