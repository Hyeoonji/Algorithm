using System;
using System.Linq;

public class Solution
{
    public string[] solution(string myString)
    {

        string[] str = myString.Split('x');
        string[] answer = str.Where(x => x != string.Empty).ToArray();
        Array.Sort(answer);

        return answer;
    }
}