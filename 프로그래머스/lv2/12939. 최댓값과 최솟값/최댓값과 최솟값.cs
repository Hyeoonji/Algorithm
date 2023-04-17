public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        // 최대 최소
        int max = int.MinValue;
        int min = int.MaxValue;

        // 문자열 자르기
        string[] str = s.Split(' ');
        // 정수배열
        int[] num = new int[str.Length];

        for(int i = 0; i < str.Length; i++)
        {
            num[i] = int.Parse(str[i]);
        }

       
        for(int j =0; j < num.Length; j++)
        {
            if (num[j] > max)
            {
                max = num[j];
            }
            if (num[j] < min)
            {
                min = num[j];
            }
        }

        answer = $"{min} {max}";
        return answer;
    }
}