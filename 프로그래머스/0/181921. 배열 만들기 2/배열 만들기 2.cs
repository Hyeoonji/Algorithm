using System;

using System.Collections.Generic;

public class Solution
{
    public int[] solution(int l, int r)
    {
        int ten = 0;
        List<int> list = new List<int>();
        while (true)
        {
            char[] ch = Convert.ToString(ten, 2).ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '1')
                {
                    ch[i] = '5';
                }
                else { ch[i] = '0'; }
            }

            int temp = int.Parse(ch);

            if (l <= temp && temp <= r)
            {
                list.Add(temp);
            }

            ten++;

            if (temp > r)
            {
                break;
            }
        }

        int length = list.Count;
        if (length == 0)
        {
            length = 1;
        }

        int[] answer = new int[length];

        if (list.Count == 0)
        {
            answer[0] = -1;
        }
        else
        {
            answer = list.ToArray();
        }

        return answer;
    }
}