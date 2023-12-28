using System;

public class Solution
{
    public int solution(int n, string control)
    {
        char[] conCha = control.ToCharArray();
        int answer = 0;
        foreach (char c in conCha)
        {
            if (c == char.Parse("w"))
            {
                n++;
            }
            else if (c == char.Parse("s"))
            {
                n--;
            }
            else if (c == char.Parse("d"))
            {
                n += 10;
            }
            else
            {
                n -= 10;
            }
        }
        answer = n;

        return answer;
    }
}