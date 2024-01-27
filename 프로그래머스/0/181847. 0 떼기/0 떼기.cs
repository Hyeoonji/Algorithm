using System;

public class Solution
{
    public string solution(string n_str)
    {
        string answer = "";

        char[] chars = n_str.ToCharArray();
        int point = 0;
        for(int i  = 0; i < chars.Length;i++)
        {
            if (chars[i] != '0')
            {
                point = i;
                break;
            }
        }

        answer = n_str.Substring(point);
        return answer;
    }
}