using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;
        char[] chars = myString.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == 'B')
            {
                chars[i] = 'A';
            }
            else { chars[i] = 'B'; }
        }

        myString = new string(chars);

        if (myString.Contains(pat))
        {
            answer = 1;
        }
        else {  answer = 0; }

        return answer;
    }
}