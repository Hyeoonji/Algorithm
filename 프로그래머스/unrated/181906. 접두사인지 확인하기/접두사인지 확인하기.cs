using System;

public class Solution
{
    public int solution(string my_string, string is_prefix)
    {
        int answer = 0;

        char[] strCha = my_string.ToCharArray();
        char[] preCha = is_prefix.ToCharArray();
        if (strCha.Length >= preCha.Length)
        {
            for (int i = 0; i < preCha.Length; i++)
            {
                answer = 1;
                if (strCha[i] != preCha[i])
                {
                    answer = 0;
                    break;
                }


            }

        }
        return answer;
    }
}
