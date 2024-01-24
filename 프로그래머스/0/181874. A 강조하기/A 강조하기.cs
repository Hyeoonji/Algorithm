using System;

public class Solution
{
    public string solution(string myString)
    {
        string answer = "";
        char[] chars = myString.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            int num = (int)chars[i];
            if (num < 97 && num > 65)
            {
                num += 32;
                answer += (char)num;
            }
            else if (num == 97)
            {
                num -= 32;
                answer += (char)num;
            }
            else
            {
                answer += (char)num;
            }

        }

        return answer;
    }
}