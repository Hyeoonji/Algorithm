using System;
public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;

        for (int i = 0; i < myString.Length; i++)
        {
            int index = -1;
            index = myString.IndexOf(pat, i);
            if (index >= 0 && index == i)
            {
                answer++;
            }
        }

        return answer;
    }
}