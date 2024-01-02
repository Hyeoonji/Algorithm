using System;

public class Solution {
    public string solution(string str1, string str2)
    {
        string answer = "";

        char[] cha1 = str1.ToCharArray();
        char[] cha2 = str2.ToCharArray();

        for(int i = 0;i<cha1.Length; i++)
        {
            answer += cha1[i];
            answer += cha2[i];
        }


        return answer;
    }
}