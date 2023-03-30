using System;
public class Solution
{
    public int solution(int[] sides)
    {
        int answer = 0;
        Array.Sort(sides);
        if (sides[2] < sides[1] + sides[0])
        {
            answer = 1;
        }
        else
        {
            answer = 2;
        }
        return answer;
    }
}