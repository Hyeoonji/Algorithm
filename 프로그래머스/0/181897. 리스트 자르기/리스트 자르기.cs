using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n, int[] slicer, int[] num_list)
    {
        int start = 0;
        int end = 0;
        int jump = 0;

        if (n == 1)
        {
            start = 0;
            end = slicer[1];
        }
        else if (n == 2)
        {
            start = slicer[0];
            end = num_list.Length - 1;
        }
        else if (n == 3)
        {
            start = slicer[0];
            end = slicer[1];
        }
        else
        {
            start = slicer[0];
            end = slicer[1];
            jump = slicer[2];
        }

        List<int> list = new List<int>();
        if (jump != 0)
        {
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (start + count * jump <= end)
                {
                    list.Add(num_list[start + count * jump]);
                    count++;
                }
            }
        }
        else
        {
            for (int i = start; i <= end; i++)
            {
                list.Add(num_list[i]);
            }
        }


        int[] answer = list.ToArray();
        return answer;
    }
}