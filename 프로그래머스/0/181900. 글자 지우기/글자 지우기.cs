using System;

using System.Linq;
public class Solution
{
    public string solution(string my_string, int[] indices)
    {
        string answer = "";
        char[] cha = my_string.ToCharArray();
        for(int i = 0; i < indices.Length; i++)
        {
            cha[indices[i]] = '0';
        }

        cha = cha.Where(x => x != '0').ToArray();
        answer = string.Concat(cha);

        return answer;
    }
}