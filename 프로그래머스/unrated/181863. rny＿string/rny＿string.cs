using System;

public class Solution {
    public string solution(string rny_string) {
        string answer = "";
        char[] cha = rny_string.ToCharArray();
        for(int i = 0; i < cha.Length; i++)
        {
            if(cha[i] == char.Parse("m"))
            {
                answer += "rn";
                
            } else { answer += cha[i];}
        }
        
        return answer;
    }
}