using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> list = new List<int>();
        int i = 0;
        while (i < arr.Length)
        {
            if (list.Count == 0)
            {
                list.Add(arr[i]);
                i++;
            }
            else
            {
                if (list[list.Count - 1] < arr[i])
                {
                    list.Add(arr[i]);
                    i++;
                }
                else
                {
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
        
        int[] stk = list.ToArray();

        return stk;
    }
}