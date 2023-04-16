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





