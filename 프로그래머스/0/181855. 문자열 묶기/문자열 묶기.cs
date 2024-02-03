using System;

public class Solution
{
    public int solution(string[] strArr)
    {
        int[] num = new int[31];

        for(int i = 0; i < num.Length; i++)
        {
            num[i] = 0;
        }

        for (int i = 0; i < strArr.Length; i++)
        {
            for (int j = 0; j <= num.Length; j++)
            {
                if (strArr[i].Length == j)
                {
                    num[j]++;
                }
            }
        }

        Array.Sort(num);
        int answer = num[num.Length-1];

        return answer;
    }
}