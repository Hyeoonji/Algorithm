using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        List<int> li = new List<int>();

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];
            int k = queries[i, 2];

            int min = 1000000;

            for (int j = s; j <= e; j++)
            {
                if (arr[j] > k && arr[j] <= min)
                {
                    min = arr[j];
                }
            }

            if(min == 1000000)
            {
                min = -1;
            }

            li.Add(min);
        }

        int[] answer = new int[li.Count];
        answer = li.ToArray();

        return answer;
    }
}