using System;

class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int k = 0;
        while(true)
        {
            if(n == 0)
            {
                break;
            }
            if(n%2 != 0)
            {
                n--;
                k++;
            }
            else
            {
                n = n / 2;
            }
        }
        answer = k;
        return answer;
    }
}