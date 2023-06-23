using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[2];
        char[] empty = new char[' '];
        int count = 0;                              //변환 횟수
        int zerocount = 0;                          //변환 과정에서 제거된 0의 개수
        while (s.Length > 1)
        {
            count++;
            int length = s.Length;
            string str = "";
            for(int i = 0; i < length; i++)         //길이만큼 반복하며 0 찾기
            {
                if (s[i] == '0')
                {
                    zerocount++;
                }
                else
                {
                    str += s[i];
                }
            }
            
            s = Convert.ToString(str.Length, 2);    //길이를 이진법으로 변환해서 다시 넣기
        }

        answer[0] = count;
        answer[1] = zerocount;
        return answer;
    }
}