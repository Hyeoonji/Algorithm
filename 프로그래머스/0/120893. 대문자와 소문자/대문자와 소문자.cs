using System;

public class Solution
{
    public string solution(string my_string)
    {
        string answer = "";
        char[] chars = my_string.ToCharArray();
        foreach (char c in chars)
        {
            if((int)c < 97)
            {
                answer += c.ToString().ToLower();
            }
            else
            {
                answer += c.ToString().ToUpper();
            }
        }

        return answer;
    }
}