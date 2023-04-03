using System;

public class Solution
{
    public int[] solution(int n)
    {
        int count;
        if (n % 2 == 0) { count = n / 2;}
        else { count = n / 2 + 1;}
        
        int[] answer = new int[count];

        for(int i =0; i < count ; i++){
            answer[i] = (i*2)+1;
        }

        return answer;
    }
}