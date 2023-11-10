using System;

// 정사각형으로 만들기
public class Solution
{
    public int[,] solution(int[,] arr)
    {
        int col = arr.GetLength(0); //행의 길이
        int low = arr.GetLength(1); //열의 길이
        int length = 0;

        if (col > low) { length = col; }
        else { length = low; }

        int[,] answer = new int[length, length];


        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                answer[i, j] = 0;
                if (i < col && j < low)
                {
                    answer[i, j] = arr[i, j];
                }
            }
        }

        return answer;
    }
}