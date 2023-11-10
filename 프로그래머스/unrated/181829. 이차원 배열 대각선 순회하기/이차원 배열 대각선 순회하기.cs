using System;

// 이차원 배열 대각선 순회하기
public class Solution
{
    public int solution(int[,] board, int k)
    {
        int answer = 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (i + j <= k)
                {
                    answer += board[i, j];
                }
                else { break; }
            }
        }
        return answer;
    }
}