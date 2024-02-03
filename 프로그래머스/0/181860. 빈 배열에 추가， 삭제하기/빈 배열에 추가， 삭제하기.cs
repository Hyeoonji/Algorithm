using System;
using System.Collections.Generic;
public class Solution
{
    public int[] solution(int[] arr, bool[] flag)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < flag.Length; i++)
        {
            if (flag[i] == true)
            {
                int a = arr[i];
                for (int j = 0; j < a * 2; j++)
                {
                    result.Add(a);
                }
            }
            else
            {
                int a = arr[i];
                result.RemoveRange(result.Count-a, a);
            }
        }


        int[] answer = result.ToArray();
        return answer;
    }
}
