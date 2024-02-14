using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        string num = n.ToString();
        char[] arr = num.ToCharArray();

        foreach (char c in arr)
        {
            answer += int.Parse(c.ToString());
        }

        return answer;
    }
}