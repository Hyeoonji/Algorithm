using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] num_list, int n)
    {

        List<int> list = new List<int>();
        int count = 0;
        if (num_list.Length % n > 0)
        {
            count = num_list.Length / n+1;
        }
        else
        {
            count = num_list.Length / n;
        }

        for (int i = 0; i < count; i++)
        {
            list.Add(num_list[n * i]);
        }

        int[] answer = new int[list.Count];

        answer = list.ToArray();

        return answer;
    }
}