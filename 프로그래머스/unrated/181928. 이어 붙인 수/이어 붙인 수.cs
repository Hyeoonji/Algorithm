using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int answer = 0;
        string stOdd = "";
        string stEven = "";

        foreach (int num in num_list)
        {
            if (num % 2 > 0)
            {
                stEven += num.ToString();
            }
            else
            {
                stOdd += num.ToString();
            }
        }

        answer = int.Parse(stEven) + int.Parse(stOdd);
        return answer;
    }
}