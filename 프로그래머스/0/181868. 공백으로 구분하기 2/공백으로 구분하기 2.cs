using System;

using System.Collections.Generic;
public class Solution
{
    public string[] solution(string my_string)
    {
        List<string> list = new List<string>();
        my_string = my_string.TrimStart(' ');
        my_string = my_string.TrimEnd(' ');
        string[] temp = my_string.Split(' ');
        for(int i = 0; i < temp.Length; i++)
        {
            if (temp[i] != string.Empty)
            {
                list.Add(temp[i]);
            }
        }
        string[] answer = list.ToArray();

        return answer;
    }
}