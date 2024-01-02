using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] todo_list, bool[] finished)
{
    List<string> temp = new List<string>();

    for (int i = 0; i < todo_list.Length; i++)
    {
        if (finished[i] == false)
        {
            temp.Add(todo_list[i]);
        }
    }

    string[] answer = new string[temp.Count];
    for (int i = 0; i < temp.Count; i++)
    {
        answer[i] = temp[i];
    }

    return answer;
}
}