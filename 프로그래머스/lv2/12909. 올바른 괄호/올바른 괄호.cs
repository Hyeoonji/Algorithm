using System;

// 올바른 괄호
public class Solution
{
    public bool solution(string s)
    {
        bool answer = true;
        char[] chars = s.ToCharArray();
        int countFront = 0;
        int countBack = 0;


        // ()로 이루어진다는 것 = ( 와 ) 의 개수가 같아야 함
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[0] == ')')
            {
                answer = false;
                return answer;
            }
            else if (chars[chars.Length - 1] == '(')
            {
                answer = false;
                return answer;
            }
            else
            {
                if (chars[i] == '(') countFront++;
                else countBack++;

                // 순서대로 진행하는 도중에 )가 (보다 많다는 것 => ()()))이런식으로 갯수가 맞지 않는다는 것
                if (countFront < countBack)
                {
                    answer = false;
                    return answer;
                }
                
            }
        }

        if (countFront != countBack)
        {
            answer = false;
        }

        return answer;
    }
}