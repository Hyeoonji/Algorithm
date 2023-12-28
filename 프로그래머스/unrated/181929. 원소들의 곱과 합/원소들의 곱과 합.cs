using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int mul = 1;
        int plus = 0;
        
        foreach(int n in num_list)
        {
            mul *= n;
            plus += n;
        }
        
        plus = plus*plus;
        
        if(mul < plus)
        {
           answer = 1; 
        } else { answer = 0; }
        
        return answer;
    }
}