using System;

public class Solution
{
    public int solution(string[] order)
    {
        int answer = 0;

        int aa = 4500;
        int cafe = 5000;

        foreach (string s in order)
        {
            if (s.Contains("americano"))
            {
                answer += aa;
            } else if (s.Contains("cafe"))
            {
                answer += cafe;
            }
            else
            {
                answer += aa;
            }
        }
        return answer;
    }
}