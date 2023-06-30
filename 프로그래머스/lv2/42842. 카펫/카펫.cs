using System;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[2];
        int row = 0;
        int col = 0;

        int around = (brown + 4) / 2;               //둘레
        int tile = brown + yellow;                  //면적

        List<int> div_list = new List<int>();

        for (int i = 1; i <= tile; i++)               // 약수를 리스트에 담음
        {
            if (tile % i == 0)
            {
                div_list.Add(i);
            }
        }
        
        foreach(int a  in div_list)
        {
            int b = tile / a;
            if(a + b == around) 
            {
                row = a;
                col = b;
            }
        }

        answer[0] = row;
        answer[1] = col;
        return answer;
    }
}