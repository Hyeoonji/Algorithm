using System;

using System.Collections.Generic;
public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> list = new List<int>();

        int start = -1;
        int end = -1;
        start = Array.IndexOf(arr, 2);
        end = Array.LastIndexOf(arr, 2);
        if (start > -1)
        {
            for (int i = start; i <= end; i++)
            {
                list.Add(arr[i]);
            }
        }
        else { list.Add(-1); }

        int[] answer = list.ToArray();


        return answer;
    }
}