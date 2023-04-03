using System;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[2];
        int cup = 0;
        
        while(money-5500>=0){
            cup ++;
            money -= 5500;
        }
        
        answer[0] = cup;
        answer[1] = money;
        return answer;
    }
}