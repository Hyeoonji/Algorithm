using System;

using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[] query)
    {
        int[] temp = arr;

        for (int i = 0; i < query.Length; i++)
        {
            int start = 0;
            int end = 0;
            List<int> list = new List<int>();

            if (i % 2 == 0)
            {
                start = 0;
                end = query[i] +1;
            }
            else
            {
                start = query[i];
                end = temp.Length;
            }

            for(int j = start; j < end; j++)
            {
                list.Add(temp[j]);
            }
            temp = list.ToArray();
        }

        int[] answer = temp;
        return answer;
    }
}