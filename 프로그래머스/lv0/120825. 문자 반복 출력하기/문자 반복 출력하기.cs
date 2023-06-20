using System;

public class Solution
{
    public string solution(string my_string, int n)
    {
        string answer = "";

        char[] cha = my_string.ToCharArray();

        for (int i = 0; i < cha.Length; i++)
        {
            string word = new string(cha[i], n);
            answer += word;
        }

        return answer;
    }
}