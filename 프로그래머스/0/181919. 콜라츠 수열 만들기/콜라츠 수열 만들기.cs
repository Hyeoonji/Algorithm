using System;
using System.Collections.Generic;


public class Solution
{
    public int[] solution(int n)
    {
        List<int> list = new List<int>();

        list.Add(n);
        while (true)
        {
            if (n % 2 == 0)
            {
                n = n / 2;
            }
            else
            {
                n = n * 3 + 1;
            }

            list.Add(n);

            if(n == 1)
            {
                break;
            }
        }

        int[] answer = list.ToArray();
        return answer;
    }
}