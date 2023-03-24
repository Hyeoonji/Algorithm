using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        float num = (float) num1 / num2 * 1000;
        answer = (int) num;
        
        return answer;
    }
}