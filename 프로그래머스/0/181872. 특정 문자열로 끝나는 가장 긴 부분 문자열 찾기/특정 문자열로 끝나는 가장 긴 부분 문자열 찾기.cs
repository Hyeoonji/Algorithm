using System;

public class Solution
{
    public string solution(string myString, string pat)
    {
        string answer = "";
        int index = myString.LastIndexOf(pat);

        answer = myString.Substring(0, index)+pat;

        return answer;
    }
}