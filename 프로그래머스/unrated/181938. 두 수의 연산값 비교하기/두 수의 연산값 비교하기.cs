using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string ab = "";
        ab += a.ToString();
        ab += b.ToString();
        
        int abNum = int.Parse(ab);
        int abMul = 2 * a * b;
        
        if(abNum > abMul)
        {
            answer = abNum;
        } else if(abNum < abMul)
        {
            answer = abMul;
        } else { answer = abNum;}
        
        return answer;
    }
}