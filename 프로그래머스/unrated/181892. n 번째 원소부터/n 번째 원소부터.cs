using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        List<int> temp = new List<int>();
        for (int i = n - 1; i < num_list.Length; i++)
        {
            temp.Add(num_list[i]);
        }

        int[] answer = new int[temp.Count];
        for (int i = 0; i < temp.Count; i++)
        {
            answer[i] = temp[i];
        }
        return answer;
    }
}