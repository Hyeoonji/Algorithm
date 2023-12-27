using System;

public class Solution
{
    public int solution(int a, int b)
    {
        int answer = 0;
        int ab, ba;

        string stA = a.ToString();
        string stB = b.ToString();
        ab = int.Parse($"{stA}{stB}");
        ba = int.Parse($"{stB}{stA}");

        if(ab >= ba)
        {
            answer = ab;
        } else
        {
            answer = ba;
        }

        return answer;
    }
}