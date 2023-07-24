using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// 연속 부분 수열 합의 개수
public class Solution
{

    public int Partial(int[] ele, int start, int len)  //부분합을 구하는 식
    {
        int sum = 0;
        for (int i = start; i < start + len; i++)
        {
            sum += ele[i];
        }
        return sum;
    }

    // 연속값을 어떻게 처리할 것인가
    // -> 길이가 작아진다면 앞에서 추가할 수 있도록 해야 함
    // ->> 그러면 길이에 따라 더하는 방식으로 가야 할 듯

    public int solution(int[] elements)
    {
        int answer = 0;
        int[] ele = new int[elements.Length * 2];
        //List<int> result = new List<int>();
        HashSet<int> numset = new HashSet<int>();

        for (int i = 0; i < elements.Length; i++)            //길이가 2배인 배열 준비
        {
            ele[i] = elements[i];
            ele[i + elements.Length] = elements[i];
        }

        int count = elements.Length;

        for (int i = 0; i < elements.Length; i++)
        {
            if (count == 0)
            {
                break;
            }
            for (int j = 0; j < elements.Length; j++)
            {
                numset.Add(Partial(ele, j, count));
            }
            count--;
        }

        answer = numset.Count;

        return answer;
    }
}