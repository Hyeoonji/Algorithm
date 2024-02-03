using System;
using System.Linq;

public class Solution
{
    public string[] solution(string myStr)
    {
        char[] cha = { 'a', 'b', 'c' };
        string[] spl = myStr.Split(cha);

        spl = spl.Where(x => x != string.Empty).ToArray(); 

        string[] answer = new string[] { };
        if(spl.Length == 0)
        {
            answer = new string[1];
            answer[0] = "EMPTY";
        }
        else {  answer = spl; }

        return answer;
    }
}