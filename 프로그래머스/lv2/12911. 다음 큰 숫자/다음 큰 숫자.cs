using System;

public class Solution
{
    //다음 큰 숫자: 2진수일때, 1의 개수가 동일한 숫자 중 가장 작은 수
    public int solution(int n)
    {
        int answer = 0;
        string num = Convert.ToString(n, 2);            //주어진 수를 2진수로 변환
        int countNum = 0;                               //주어진 수의 1의 개수
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == '1')
            {
                countNum++;
            }
        }

        answer = n;                                 //n의 다음 수
        while (true)
        {
            answer++;
            int countOne = 0;                           //1의 개수
            string binary = Convert.ToString(answer, 2);
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    countOne++;
                }
            }
            if(countOne == countNum)
            {
                break;
            }
        }

        return answer;
    }
}