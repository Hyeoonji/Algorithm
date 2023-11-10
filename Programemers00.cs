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

/*// 배열의 길이에 따라 다른 연산하기
public class Solution
{
    public int[] solution(int[] arr, int n)
    {
        int[] answer = new int[arr.Length];

        if (arr.Length % 2 == 0)    //짝수라면
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)     //홀수 + n
                {
                    answer[i] = arr[i] + n;
                }
                else
                {
                    answer[i] = arr[i];
                }
            }
        }
        else                        //홀수라면
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)     //짝수+ n
                {
                    answer[i] = arr[i] + n;
                }
                else
                {
                    answer[i] = arr[i];
                }
            }
        }

        return answer;
    }
}*/

/*//배열 비교하기
public class Solution
{
    public int solution(int[] arr1, int[] arr2)
    {
        int answer = 0;

        //두 배열의 길이가 다르다면, 배열의 길이가 긴 쪽이 더 큼
        if (arr1.Length > arr2.Length)
        {
            answer = 1;
        }
        else if (arr1.Length < arr2.Length)
        {
            answer = -1;
        }
        //배열의 길이가 같다면 모든 원소의 합을 비교하여 다르다면 더 큰 쪽이 크고, 같다면 같음.
        else
        {
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                num1 += arr1[i];
                num2 += arr2[i];
            }

            //arr2가 크다면 -1, arr1이 크다면 1, 두 배열이 같다면 0
            if (num1 > num2)
            {
                answer = 1;
            }
            else if (num2 > num1)
            {
                answer = -1;
            }
            else
            {
                answer = 0;
            }
        }

        return answer;
    }
}*/

/*// 정수 찾기
public class Solution
{
    public int solution(int[] num_list, int n)
    {
        int answer = 0;
        foreach(int num in num_list)
        {
            if(num == n)
            {
                answer = 1;
                break;
            }
            else
            {
                answer = 0;
            }
        }

        return answer;
    }
}*/

/*// 조건에 맞게 수열 변환하기 3
public class Solution
{
    public int[] solution(int[] arr, int k)
    {
        int[] answer = new int[arr.Length];
        if (k % 2 != 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i] * k;
            }
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i] + k;
            }
        }

        return answer;
    }
}*/

/*// n의 배수
public class Solution
{
    public int solution(int num, int n)
    {
        int answer = 0;
        if (num % n == 0)
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }

        return answer;
    }
}*/

/*// 이차원 배열 대각선 순회하기
public class Solution
{
    public int solution(int[,] board, int k)
    {
        int answer = 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (i + j <= k)
                {
                    answer += board[i, j];
                }
                else { break; }
            }
        }
        return answer;
    }
}
//-----------------------------------
//board.Length 는 전체 길이 = 행 * 열 -> 이를 사용하면 런타임 에러 발생
//board.GetLength()를 사용해야 행 또는 열의 길이만 구할 수 있음
//(0)은 행 / (1)은 열
*/

/*// 정사각형으로 만들기
public class Solution
{
    public int[,] solution(int[,] arr)
    {
        int col = arr.GetLength(0); //행의 길이
        int low = arr.GetLength(1); //열의 길이
        int length = 0;

        if (col > low) { length = col; }
        else { length = low; }

        int[,] answer = new int[length, length];

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                answer[i, j] = 0;           //전체 0으로 넣고난 후
                if (i < col && j < low)     //값이 있는 경우에만 덮어쓰기
                {
                    answer[i, j] = arr[i, j];
                }
            }
        }

        return answer;
    }
}*/

/*// 특별한 이차원 배열 2
public class Solution
{
    public int solution(int[,] arr)
    {
        int answer = 1;

        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i,j] != arr[j, i])
                {
                    answer = 0;
                    break;
                }
            }
        }

        return answer;
    }
}*/

// 정수를 나선형으로 배치하기
public class Solution
{
    public int[,] solution(int n)
    {
        int[,] answer = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[i, j] = 0;
            }
        }

        int col = 0;    //행
        int low = -1;   //열
        int a = 1;      //값
        int num = 1;    //방향을 바꿔줄 값

        while (true)
        {
            for (int i = 0; i < n; i++)
            {
                low += num;
                answer[col, low] = a;
                a++;
            }

            n--;
            if (n <= 0) { break; }

            for (int j = 0; j < n; j++)
            {
                col += num;
                answer[col, low] = a;
                a++;
            }

            num *= -1;
        }

        return answer;
    }
}