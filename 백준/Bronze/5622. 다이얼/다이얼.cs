public class Program
{
    static void Main(string[] args)
    {
        // 첫째 줄에 대문자로 이루어진 단어
        string word = Console.ReadLine();

        int[] asword = new int[word.Length];
        // 단어를 아스키코드로 변환
        for (int i = 0; i < word.Length; i++)
        {
            asword[i] = Convert.ToInt32(word[i]);
        }

        int time = 0;
        int total = 0;

        // ABC(67) 2 / DEF(70) 3 / GHI(73) 4 / JKL(76) 5 / MNO(79) 6 / PQRS(83) 7 / TUV(86) 8 / WXYZ(90) 9
        // 다이얼 돌리는 데 걸리는 시간 = 숫자 *2
        // 각 문자에 걸리는 시간을 구함

        for (int i = 0; i < asword.Length; i++)
        {
            if (asword[i] <= 67)
            {
                time = 2+1;
                total += time;
            }
            else if (asword[i] <= 70)
            {
                time = 3+1;
                total += time;
            }
            else if (asword[i] <= 73)
            {
                time = 4+1;
                total += time;
            }
            else if (asword[i] <= 76)
            {
                time = 5+1;
                total += time;
            }
            else if (asword[i] <= 79)
            {
                time = 6+1;
                total += time;
            }
            else if (asword[i] <= 83)
            {
                time = 7+1;
                total += time;
            }
            else if (asword[i] <= 86)
            {
                time = 8+1;
                total += time;
            }
            else
            {
                time = 9+1;
                total += time;
            }

        }

        Console.WriteLine(total);
    }
}