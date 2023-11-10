using System;

// 정수를 나선형으로 배치하기
public class Solution
{
    public int[,] solution(int n)
    {
        int[,] answer = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[i, j] = 0;
            }
        }

        int col = 0;
        int low = -1;
        int a = 1;
        int num = 1;

        while (true)
        {
            for (int i = 0; i < n; i++)
            {
                low += num;
                answer[col, low] = a;
                a++;
            }

            n--;
            if (n <= 0) { break; }

            for (int j = 0; j < n; j++)
            {
                col += num;
                answer[col, low] = a;
                a++;
            }

            num *= -1;
        }

        return answer;
    }
}