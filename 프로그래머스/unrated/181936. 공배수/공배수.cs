using System;

public class Solution
{
    public int solution(int number, int n, int m)
    {
        int answer = 0;
        if(number %n == 0) 
        {
            if(number %m == 0)
            {
                answer = 1;
            }
        } else if(number %m == 0)
        {
            if(number %n == 0)
            {
                answer = 1;
            }
        }

        return answer;
    }
}