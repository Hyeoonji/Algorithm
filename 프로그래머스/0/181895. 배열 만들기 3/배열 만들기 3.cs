using System;

using System.Collections.Generic;
public class Solution
{
    public int[] solution(int[] arr, int[,] intervals)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < 2; i++)
        {
            for (int j = intervals[i, 0]; j <= intervals[i, 1]; j++)
            {
                result.Add(arr[j]);
            }
        }

        int[] answer = result.ToArray();
        return answer;
    }
}