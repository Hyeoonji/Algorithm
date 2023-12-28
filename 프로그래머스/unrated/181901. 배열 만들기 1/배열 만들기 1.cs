using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n, int k)
    {
        List<int> list = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (n >= k * i)
            {
                list.Add(k*i);
            }
        }

        int[] answer = new int[list.Count];
        
        for(int i = 0; i < list.Count; i++)
        {
            answer[i] = list[i];
        }

        return answer;
    }
}