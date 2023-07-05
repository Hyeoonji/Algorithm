public class Solution
{
    //피보나치 수열 활용
    long fibo = 1;
    long num = 1;
    public long solution(int n)
    {
        long answer = 0;
        if(n == 0 || n == 1)
        {
            answer = 1;
        }
        else
        {
            for(int i = 2; i <= n; i++)
            {
                answer = (fibo + num) % 1234567;
                fibo = num;
                num = answer;
            }
        }

        return answer;
    }
}