using System;

// 코드 처리하기
// 시작은 mode 0, 문자가 1이면 무조건 mode 변경
// mode가 0일때,
// - code[i] 가 1이 아니면 i가 짝수일때만 ret 맨 뒤에 추가
// - code[i] 가 1이면 mode를 변경
// mode가 1일때,
// - code[i] 가 1이 아니면 i가 홀수일때만 ret 맨 뒤에 추가
// - code[i] 가 1이면 mode를 변경
// ret가 빈 문자열이면 EMPTY 출력

public class Solution
{
    public string solution(string code)
    {
        string answer = "";
        int mode = 0;
        char[] cha = code.ToCharArray();
        for (int i = 0; i < cha.Length; i++)
        {
            if (mode == 0)
            {
                if (cha[i] != char.Parse("1"))
                {
                    if (i % 2 == 0)
                    {
                        answer += cha[i];
                    }
                }
                else { mode = 1; }
            }
            else
            {
                if (cha[i] != char.Parse("1"))
                {
                    if (i % 2 != 0)
                    {
                        answer += cha[i];
                    }
                }
                else { mode = 0; }
            }
        }

        if (answer == "")
        {
            answer = "EMPTY";
        }


        return answer;
    }
}