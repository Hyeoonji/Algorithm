using System;

public class Solution
{
    public int solution(string binomial)
    {
        string[] str = binomial.Split(' ');
        int a = int.Parse(str[0]);
        string op = str[1];
        int b = int.Parse(str[2]);

        int answer = 0;
        if(op == "+")
        {
            answer = a + b;
        } else if(op == "-")
        {
            answer = a - b;
        } else if (op == "*")
        {
            answer = a * b;
        }

        return answer;
    }
}