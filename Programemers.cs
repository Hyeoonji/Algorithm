namespace Programmers;

// 정수 제곱근 판별
//public class Solution
//{
//    public long solution(long n)
//    {
//        long answer = 0;
//        for (long i = 0; i <= n; i++)
//        {
//            if(i*i == n)
//            {
//                answer = (i + 1) * (i + 1);
//                break;
//            } else if(i*i == 0)
//            {
//                answer = -1;
//            }
//        }

//        return answer;
//    }
//}

// 특정 문자 제거하기
//using System;

//public class Solution
//{
//    public string solution(string my_string, string letter)
//    {
//        string answer = "";
//        foreach (char text in my_string)
//        {
//            if (text.ToString() == letter)
//            {
//                continue;
//            }
//            answer += $"{text}";
//        }
//        return answer;
//    }
//}

// 행렬의 덧셈
//public class Solution
//{
//    public int[,] solution(int[,] arr1, int[,] arr2)
//    {
//        int[,] answer = new int[arr1.GetLength(0),arr2.GetLength(1)];
//        for(int i = 0; i< arr1.GetLength(0); i++)
//        {
//            for(int j =0; j< arr2.GetLength(1); j++)
//            {
//                answer[i,j] = arr1[i,j] + arr2[i,j];
//            }
//        }

//        return answer;
//    }
//}

// 자릿수 더하기
//using System;

//public class Solution
//{
//    public int solution(int n)
//    {
//        int answer = 0;
//        string num = n.ToString();
//        for(int i = 0; i < num.Length; i++)
//        {
//            answer += int.Parse(num[i].ToString());
//        }
//        return answer;
//    }
//}

// 최댓값과 최솟값
//public class Solution
//{
//    public string solution(string s)
//    {
//        string answer = "";
//        // 최대 최소
//        int max = int.MinValue;
//        int min = int.MaxValue;

//        // 문자열 자르기
//        string[] str = s.Split(' ');
//        // 정수배열
//        int[] num = new int[str.Length];

//        for(int i = 0; i < str.Length; i++)
//        {
//            num[i] = int.Parse(str[i]);
//        }


//        for(int j =0; j < num.Length; j++)
//        {
//            if (num[j] > max)
//            {
//                max = num[j];
//            }
//            if (num[j] < min)
//            {
//                min = num[j];
//            }
//        }

//        answer = $"{min} {max}";
//        return answer;
//    }
//}

// 행렬의 곱셈
//using System;

//public class Solution
//{
//    public int[,] solution(int[,] arr1, int[,] arr2)
//    {
//        // 행(0), 열(1)
//        int[,] answer = new int[arr1.GetLength(0),arr2.GetLength(1)] ;

//        // 밑으로 증가 a -> c
//        for(int i = 0; i < arr1.GetLength(0); i++)
//        {
//            // 앞 행렬 증가 a -> b
//            for(int j = 0; j <arr1.GetLength(1); j++)
//            {
//                //뒤 행렬 증가 x1 -> y1
//                for(int k = 0; k < arr2.GetLength(1); k++)
//                {
//                    answer[i,k] += arr1[i,j] * arr2[j,k];
//                }
//            }
//        }
//        return answer;
//    }
//}

/* 행렬의 곱셈 -> 덧셈으로 변환하기
    - 곱셈
(a, b) + (x1, y1)  --> (a x1 + b x2 , a y1 + b y2)
(c, d) + (x2, y2)  --> (c x1 + d x2 , c y1 + d y2)
-> 이대로 풀 경우, a -> b 옆으로 증가, x1 -> x2 밑으로 증가 =>> 꼬이게 됨
    -> 덧셈으로 변환해서 풀이 ([a,b] + [x,y] = [a+x, b+y]를 활용)
(a x1 + b x2 , a y1 + b y2) 를 [a x1, ay1] + [b x1, b y2] 로 변경 가능 
-> 이렇게 되면 둘다 옆으로 증가
 */

// 피보나치 수
//public class Solution
//{
//    public int solution(int n)
//    {
//        int answer = 0;
//        int[] pibo = new int[n + 1];
//        pibo[0] = 0;
//        pibo[1] = 1;
//        for (int i = 2; i < n + 1; i++)
//        {
//            pibo[i] = (pibo[i - 2] + pibo[i - 1]) % 1234567;
//            // 왜 안에서 나눠야 하는가? -> 밖에서 나눌 경우, 숫자가 크면 int, long으로도 커버가 되지 않기 떄문
//        }
//        // [2] = 0 + 1 = 1
//        // [3] = 1 + 1 = 2
//        // [4] = 1 + 2 = 3
//        // [5] = 2 + 3 = 5
//        // [6] = 3 + 5 = 8

//        answer = pibo[n];
//        return answer;
//    }
//}

//