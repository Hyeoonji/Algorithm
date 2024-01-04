using System;

public class Solution {
    public string solution(int[] numLog) {
        string answer = "";
        for(int i = 1; i < numLog.Length; i++)
        {
            int min = numLog[i-1] - numLog[i];
            
            if(min == -1)
            {
                answer += "w";
                
            } else if( min == 1)
            {
                answer += "s";
            } else if(min == -10)
            {
                answer += "d";
            } else if(min == 10)
            {
                answer += "a";
            }
        }
        return answer;
    }
}