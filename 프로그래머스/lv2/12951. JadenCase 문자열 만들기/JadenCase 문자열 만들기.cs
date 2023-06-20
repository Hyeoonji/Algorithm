using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        s = s.ToLower();                      //전체를 소문자화: unFollowed -> Unfollowed
        char[] cha = s.ToCharArray();

        //공백문자가 연속해서 나올 수 있습니다 -> 공백 문자 처리 해줘야 함
        for (int i = 0; i < cha.Length; i++)
        {
            cha[0] = char.ToUpper(cha[0]);      //첫 알파벳 대문자로 바꾸기
            if (cha[i] == ' ' && i + 1 < cha.Length)
            {
                cha[i + 1] = char.ToUpper(cha[i + 1]);
            }
        }

        for (int i = 0; i < cha.Length; i++)
        {
            answer += cha[i];
        }

        return answer;
    }
}