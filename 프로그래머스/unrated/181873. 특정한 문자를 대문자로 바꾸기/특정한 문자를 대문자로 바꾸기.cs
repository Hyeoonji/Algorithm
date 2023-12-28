using System;

public class Solution
{
    public string solution(string my_string, string alp)
    {
        string answer = "";
        char[] strCha = my_string.ToCharArray();
        for (int i = 0; i < strCha.Length; i++)
        {
            if (strCha[i] == char.Parse(alp))
            {
                strCha[i] = char.Parse(string.Concat(strCha[i]).ToUpper());
            }
        }

        answer = new string(strCha);

        return answer;
    }
}