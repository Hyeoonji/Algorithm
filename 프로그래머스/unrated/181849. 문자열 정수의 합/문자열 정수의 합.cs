using System;

public class Solution {
    public int solution(string num_str) {
        int answer = 0;
        char[] cha = num_str.ToCharArray();
        for(int i = 0; i < cha.Length; i++)
        {
            answer += int.Parse(cha[i].ToString());
        }
        
        return answer;
    }
}