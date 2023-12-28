using System;
using System.Collections.Generic;


public class Solution
{
    public int solution(string my_string, string is_suffix)
    {
        int answer = 0;
        char[] strCha = my_string.ToCharArray();
        List<string> strList = new List<string>();
        for (int i = 0; i < strCha.Length; i++)
        {
            strList.Add(my_string.Substring(i));
        }

        if (strList.Contains(is_suffix))
        {
            answer = 1;
        }
        else { answer = 0; }


        return answer;
    }
}