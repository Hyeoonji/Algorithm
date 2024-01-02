using System;
using System.Collections.Generic;
public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        int[] answer = new int[num_list.Length];
        List<int> front = new List<int>();
        List<int> back = new List<int>();

        for (int i = 0; i < num_list.Length; i++)
        {
            if (i < n)
            {
                front.Add(num_list[i]);
            }
            else
            {
                back.Add(num_list[i]);
            }
        }


        for (int i = 0; i < back.Count; i++)
        {
            answer[i] = back[i];
        }
        for (int i = 0; i< front.Count; i++)
        {
            answer[i+back.Count] = front[i];
        }

        return answer;
    }
}