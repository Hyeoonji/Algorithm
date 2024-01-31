using System;

using System.Collections.Generic;
public class Solution
{
    public int[] solution(int[] arr, int k)
    {
        List<int> list = new List<int>();

        foreach (int i in arr)
        {
            if (!list.Contains(i))
            {
                list.Add(i);

                if(list.Count == k)
                {
                    break;
                }
            }
        }

        if(list.Count < k)
        {
            for (int i = list.Count; i < k; i++)
            {
                list.Add(-1);
            }
        }

        int[] answer = list.ToArray();

        return answer;
    }
}