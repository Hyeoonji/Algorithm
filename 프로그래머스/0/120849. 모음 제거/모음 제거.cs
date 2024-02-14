using System;
using System.Collections.Generic;


public class Solution
{
    public string solution(string my_string)
    {
        string answer = "";
        List<char> removelist = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

        foreach (char c in removelist)
        {
            my_string = my_string.Replace(c.ToString(), string.Empty);
        }

        answer = my_string;

        return answer;
    }
}