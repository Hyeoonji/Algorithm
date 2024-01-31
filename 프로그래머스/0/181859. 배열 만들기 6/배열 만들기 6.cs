using System;

using System.Collections.Generic;
public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> stk = new List<int>();
        stk.Add(arr[0]);

        for (int i = 1; i < arr.Length; i++)
        {
            if (stk.Count == 0) { stk.Add(arr[i]); }
            else if (stk[stk.Count-1] == arr[i])
            {
                stk.RemoveAt(stk.Count-1);
            }
            else
            {
                stk.Add(arr[i]);
            }
        }

        if(stk.Count == 0) 
        {
            stk.Add(-1);
        }

        int[] answer = stk.ToArray();
        return answer;
    }
}