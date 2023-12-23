using System;

public class Solution
{
    public string solution(string my_string, int n)
    {
        string answer = "";
        char[] chars = my_string.ToCharArray();
        for(int i = 0; i < n; i++)
        {
            answer += chars[i];
        }

        return answer;
    }
}