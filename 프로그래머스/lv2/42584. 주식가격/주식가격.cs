using System;
using System.Collections.Generic;

// 주식가격
public class Solution
{
    public int[] solution(int[] prices)
    {
        //int[] answer = new int[] { };
        List<int> result = new List<int>();

        int time = 0;

        while (true)
        {
            int stock = 0;

            for (int i = time + 1; i < prices.Length; i++)
            {
                stock++;
                if (prices[time] > prices[i])
                {
                    break;
                }
            }

            result.Add(stock);
            time++;

            if (time == prices.Length)
            {
                break;
            }
        }

        return result.ToArray();
    }
}