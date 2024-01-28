using System;

public class Solution
{
    public int[] solution(string my_string)
    {
        char[] asc = new char[52];
        int[] answer = new int[52];
        for (int i = 0; i < 52; i++)
        {
            answer[i] = 0;
            int ten = i + 65;
            if (ten > 90)
            {
                ten += 6;
            }

            asc[i] = (char)ten;
        }

        char[] cha = my_string.ToCharArray();
        for (int i = 0; i < cha.Length; i++)
        {
            int index = Array.IndexOf(asc, cha[i]);
            answer[index]++;
        }
        return answer;
    }
}