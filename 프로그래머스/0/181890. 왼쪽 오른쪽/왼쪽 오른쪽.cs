using System;
using System.Collections.Generic;
public class Solution
{
    public string[] solution(string[] str_list)
    {
        List<string> list = new List<string>();
        int lpos = -1;
        int rpos = -1;

        lpos = Array.IndexOf(str_list, "l");
        rpos = Array.IndexOf(str_list, "r");

        if (lpos > -1)
        {
            if (rpos > -1)
            {
                if (lpos < rpos)
                {
                    for (int i = 0; i < lpos; i++)
                    {
                        list.Add(str_list[i]);
                    }
                }
                else
                {
                    for (int i = rpos + 1; i < str_list.Length; i++)
                    {
                        list.Add(str_list[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < lpos; i++)
                {
                    list.Add(str_list[i]);
                }
            }
        }
        else if (rpos > -1)
        {
            for (int i = rpos + 1; i < str_list.Length; i++)
            {
                list.Add(str_list[i]);
            }
        }

        string[] answer = list.ToArray();

        return answer;
    }
}