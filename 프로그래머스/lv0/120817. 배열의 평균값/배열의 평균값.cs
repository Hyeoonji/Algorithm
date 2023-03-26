using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        double num = 0;
        for(int i = 0; i< numbers.Length; i++ ){
            num += numbers[i];
        }
        answer = num/numbers.Length;
        
        return answer;
    }
}