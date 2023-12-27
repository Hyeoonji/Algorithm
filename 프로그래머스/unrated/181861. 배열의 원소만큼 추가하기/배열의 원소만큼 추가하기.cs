using System;
using System.Collections.Generic;
using System.Linq;


public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> temp = new List<int>();

        foreach (int num in arr)
        {
            for (int i = 0; i < num; i++)
            {
                temp.Add(num);
            }
        }

        int[] answer = new int[temp.Count];
        for(int i = 0; i < temp.Count; i++)
        {
            answer[i] = temp[i];
        }
        return answer;
    }
}