using System;

public class Solution
{
    public string solution(string my_string, string letter)
    {
        string answer = "";
        foreach (char text in my_string)
        {
            if (text.ToString() == letter)
            {
                continue;
            }
            answer += $"{text}";
        }
        return answer;
    }
}