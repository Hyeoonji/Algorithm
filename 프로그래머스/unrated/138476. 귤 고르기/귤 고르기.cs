using System;
using System.Collections;
using System.Collections.Generic;

// 귤 고르기
public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        int answer = 0;
        Array.Sort(tangerine);                      //12233455
        List<int> count = new List<int>();
        int compare = tangerine[0];                 //1
        int num = 1;

        for (int i = 1; i < tangerine.Length; i++)
        {
            if (compare != tangerine[i])            // 1==2 ? 
            {
                count.Add(num);                     //{1,2,2,1,2}
                compare = tangerine[i];
                num = 1;
            } else            
            {
                num++;
            }
        }

        count.Add(num);
        count.Sort();                               //{1,1,2,2,2}
        count.Reverse();                            //{2,2,2,1,1}

        foreach (int i in count)
        {
            if (k < i)
            {
                answer++;
                break;
            }
            else if (k >= i)
            {
                k -= i;
                answer++;
                if (k <= 0) break;
            }
        }

        return answer;
    }
}