using System;

public class Solution
{
    public int[] solution(int[] arr, int n)
    {
        int[] answer = new int[arr.Length];

        if (arr.Length % 2 == 0)   //짝수라면
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    answer[i] = arr[i] + n;
                }
                else
                {
                    answer[i] = arr[i];
                }
            }
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    answer[i] = arr[i] + n;
                }
                else
                {
                    answer[i] = arr[i];
                }
            }
        }

        return answer;
    }
}