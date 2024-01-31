using System;

public class Solution
{
    public int solution(int[] rank, bool[] attendance)
    {
        int[] list = new int[rank.Length];
        for (int i = 0; i < rank.Length; i++)
        {
            if (attendance[i] == false)
            {
                list[i] = rank.Length * 20; 
            } else { list[i] = rank[i]; }
        }

        Array.Sort(list);

        int a = Array.IndexOf(rank, list[0]);
        int b = Array.IndexOf(rank, list[1]);
        int c = Array.IndexOf(rank, list[2]);

        int answer = 10000 * a + 100 * b + c;
        return answer;
    }
}