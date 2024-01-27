using System;
public class Solution
{
    public string solution(string my_string, int m, int c)
    {
        string answer = "";

        char[] cha = my_string.ToCharArray();
        for (int i = 0; i < cha.Length; i++)
        {
            if (i%m == c-1)
            {
                answer += cha[i];
            }
        }

        return answer;
    }
}