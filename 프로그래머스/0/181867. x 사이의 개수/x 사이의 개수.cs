using System;

public class Solution
{
    public int[] solution(string myString)
    {
        string[] str = myString.Split('x');

        int[] answer = new int[str.Length];

        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = str[i].Length;
        }

        return answer;
    }
}