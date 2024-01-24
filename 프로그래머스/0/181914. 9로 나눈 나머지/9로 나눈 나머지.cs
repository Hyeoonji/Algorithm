using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        int temp = 0;
        char[] cha = number.ToCharArray();
        for (int i = 0; i < cha.Length; i++)
        {
            temp += int.Parse(cha[i].ToString());
        }

        answer = temp % 9;
        return answer;
    }
}