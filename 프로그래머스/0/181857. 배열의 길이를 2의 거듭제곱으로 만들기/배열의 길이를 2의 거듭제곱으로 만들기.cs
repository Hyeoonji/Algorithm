using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int length = 0;
        while (true)
        {
            var pow = Math.Pow(2, length);
            if (pow >= arr.Length)
            {
                length = (int)pow;
                break;
            }
            length++;
        }

        int[] answer = new int[length];
        for (int i = 0; i < answer.Length; i++)
        {
            if (i > arr.Length - 1)
            {
                answer[i] = 0;
            }
            else { answer[i] = arr[i]; }
        }

        return answer;
    }
}