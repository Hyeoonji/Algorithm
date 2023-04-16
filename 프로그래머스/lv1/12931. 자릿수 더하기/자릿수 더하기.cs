using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        string num = n.ToString();
        for(int i = 0; i < num.Length; i++)
        {
            answer += int.Parse(num[i].ToString());
        }
        return answer;
    }
}