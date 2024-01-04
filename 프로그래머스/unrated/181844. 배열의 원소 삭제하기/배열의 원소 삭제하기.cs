using System;
using System.Collections.Generic;


public class Solution
{
    public int[] solution(int[] arr, int[] delete_list)
    {
        for (int i = 0; i < delete_list.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == delete_list[i])
                {
                    arr[j] = 0;
                }
            }
        }
        List<int> result = new List<int>();
        for(int i = 0; i <arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                result.Add(arr[i]);
            }
        }

        int[] answer = new int[result.Count];
        answer = result.ToArray();

        return answer;
    }
}