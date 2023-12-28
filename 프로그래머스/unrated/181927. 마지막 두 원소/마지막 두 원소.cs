using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int[] answer = new int[num_list.Length + 1];
        int last = num_list[num_list.Length - 1];
        int before = num_list[num_list.Length - 2];

        
        for (int i = 0; i < num_list.Length; i++)
        {
            answer[i] = num_list[i];
        }

        
        if (last > before)
        {
            answer[num_list.Length] = last - before;
        }
        else
        {
            answer[num_list.Length] = last * 2;
        }



        return answer;
    }
}
