using System;
using System.Collections;
using System.Collections.Generic;

// 영어 끝말잇기
class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];
        int round = 0;                              //몇번째인지
        int count = 0;                              //탈락자 순서
        bool isStop = false;                        //중간에 틀렸는지 체크
        List<string> word_list = new List<string>();
        word_list.Add(words[0]);

        for (int i = 0; i < words.Length - 1; i++)
        {
            char[] chaBe = words[i].ToCharArray();
            char before = chaBe[chaBe.Length - 1];      //전 단어의 끝 저장
            char[] chaAf = words[i + 1].ToCharArray();
            char after = chaAf[0];                      //다음 단어의 시작 저장
            count++;
            round = (count / n) + 1;

            if (!word_list.Contains(words[i+1]))
            {
                word_list.Add(words[i+1]);
            }
            else if(word_list.Contains(words[i+1]))
            {
                count = i + 1;
                round = (count / n) + 1;
                isStop = true;
                break;
            }

            if (before != after)
            {
                isStop = true;
                break;
            }
        }

        if (count == words.Length - 1 && isStop == false)
        {
            answer[0] = 0;
            answer[1] = 0;
        }
        else
        {
            answer[0] = count % n + 1;
            answer[1] = round;

        }
        
        return answer;
    }
}