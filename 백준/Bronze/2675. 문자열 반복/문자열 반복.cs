public class Program
{
    static void Main(string[] args)
    {
        // 첫째줄에 테스트 케이스의 개수
        int test = int.Parse(Console.ReadLine());

        // 케이스 만큼 반복
        for(int i =0; i < test; i++)
        {
            // 반복 횟수 R + 공백 + 반복할 문자열 S
            // 테스트할 문자열 받기
            string[] str = Console.ReadLine().Split();
            // 반복횟수
            int r = int.Parse(str[0]);
            
            // str[i]을
            for(int j =0; j < str[1].Length; j++)
            {
                // r만큼 반복
                for(int k = 0; k < r; k++)
                {
                    Console.Write(str[1][j]);
                }
            }
            Console.WriteLine();

        }
    }
}