using System;
public class Solution
{
    public int solution(int[] arr)
    {
        int answer = -1;
        bool isSame = false;

        while (!isSame)
        {
            isSame = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                if (arr[i] >= 50 && arr[i] % 2 == 0)
                {
                    arr[i] = arr[i] / 2;
                }
                else if (arr[i] < 50 && arr[i] % 2 != 0)
                {
                    arr[i] = (arr[i] * 2) + 1;
                }

                if (temp != arr[i])
                {
                    isSame = false;
                }
            }
            answer++;
        }

        return answer;
    }
}