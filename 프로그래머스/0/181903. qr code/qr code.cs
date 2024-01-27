using System;

public class Solution
{
    public string solution(int q, int r, string code)
    {
        string answer = "";
        char[] cha = code.ToCharArray();
        for (int i = 0; i < cha.Length; i++)
        {
            if(i%q == r)
            {
                answer += cha[i];
            }
        }
        return answer;
    }
}