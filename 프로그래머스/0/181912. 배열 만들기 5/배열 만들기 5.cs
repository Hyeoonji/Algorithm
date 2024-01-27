using System;
using System.Collections.Generic;
public class Solution
{
    public int[] solution(string[] intStrs, int k, int s, int l)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < intStrs.Length; i++)
        {
            string st = intStrs[i].Substring(s, l);
            int num = int.Parse(st);
            if (num > k)
            {
                result.Add(num);
            }
        }
        int[] answer = result.ToArray();
        return answer;
    }
}