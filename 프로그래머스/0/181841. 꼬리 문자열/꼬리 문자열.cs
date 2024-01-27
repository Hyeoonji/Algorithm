using System;
using System.Linq;
public class Solution
{
    public string solution(string[] str_list, string ex)
    {
        string[] del = str_list.Where( x => !x.Contains(ex)).ToArray();

        string answer = "";
        foreach (string str in del)
        {
            answer += str;
        }
        return answer;
    }
}