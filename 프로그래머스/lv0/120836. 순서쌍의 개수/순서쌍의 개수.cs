using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        for(int i = 1; i <= n; i++)
        {
            if(n%i == 0)
            {
                answer++;
            }

            //for(int j = 1; j <= n; j++)
            //{
            //    if(i * j == n)            // i * j == n 을 사용할 경우, 탐색 시간이 길어져 오답으로 판별됨
            //    {
            //        answer++;
            //    }
            //}
        }

        return answer;
    }
}