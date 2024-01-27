using System;

public class Solution
{
    public string solution(string my_string, int s, int e)
    {
        string answer = "";
        string temp = "";
        char[] chars = my_string.ToCharArray();
        for(int i = e; i >= s; i--)
        {
            temp += chars[i];
        }

        answer = my_string.Substring(0, s) + temp + my_string.Substring(e+1);

        return answer;
    }
}