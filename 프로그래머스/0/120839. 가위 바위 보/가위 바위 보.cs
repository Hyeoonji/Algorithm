using System;

public class Solution
{
    public string solution(string rsp)
    {
        string answer = "";
        char[] cha = rsp.ToCharArray();
        foreach (char ch in cha)
        {
            if (ch == '2')
            {
                answer += '0';
            }
            else if (ch == '0')
            {
                answer += '5';
            }
            else
            {
                answer += '2';
            }
        }
        return answer;
    }
}