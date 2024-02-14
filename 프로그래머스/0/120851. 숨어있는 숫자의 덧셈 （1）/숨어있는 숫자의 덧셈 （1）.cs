using System;

public class Solution
{
    public int solution(string my_string)
    {
        int answer = 0;
        char[] cha = my_string.ToCharArray();

        foreach (char ch in cha)
        {
            int intVal = (int)ch;
            if (intVal <= 57)
            {
                answer += int.Parse(ch.ToString());
            }
        }

        return answer;
    }
}