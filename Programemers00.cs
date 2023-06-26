using System;
using System.Collections.Generic;

namespace Programmers;

/*// 특정 문자 제거하기
public class Solution
{
    public string solution(string my_string, string letter)
    {
        string answer = "";
        foreach (char text in my_string)
        {
            if (text.ToString() == letter)
            {
                continue;
            }
            answer += $"{text}";
        }
        return answer;
    }
}*/

/*// 편지
public class Solution
{
    public int solution(string message)
    {
        int answer = 0;

        answer = message.Length * 2;    //공백포함 문자의 길이 * 2

        return answer;
    }
}*/

/*// 배열의 유사도
public class Solution
{
    public int solution(string[] s1, string[] s2)
    {
        int answer = 0;
        for(int i =0; i < s1.Length; i++)
        {
            for(int j = 0; j < s2.Length; j++)
            {
                if (s1[i] == s2[j])
                {
                    answer++;
                }
            }
        }

        return answer;
    }
}*/

/*// 배열 자르기
public class Solution
{
    public int[] solution(int[] numbers, int num1, int num2)
    {
        List<int> result = new List<int>();     //자른 배열을 담을 새로운 리스트

        for(int i = num1; i <= num2; i++)       //배열을 리스트에 담기
        {
            result.Add(numbers[i]);
        }

        int[] answer = result.ToArray();
        return answer;
    }
}*/

/*// 문자 반복 출력하기
public class Solution
{
    public string solution(string my_string, int n)
    {
        string answer = "";

        char[] cha = my_string.ToCharArray();       //단어를 쪼개기

        for (int i = 0; i < cha.Length; i++)
        {
            string word = new string(cha[i], n);    //알파벳을 반복한 배열을 넣어주기
            answer += word;
        }

        return answer;
    }
}*/

/*// 순서쌍의 개수
public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        for(int i = 1; i <= n; i++)
        {
            if(n%i == 0)
            {
                answer++;
            }

            //for(int j = 1; j <= n; j++)
            //{
            //    if(i * j == n)            // i * j == n 을 사용할 경우, 탐색 시간이 길어져 오답으로 판별됨
            //    {
            //        answer++;
            //    }
            //}
        }

        return answer;
    }
}*/


