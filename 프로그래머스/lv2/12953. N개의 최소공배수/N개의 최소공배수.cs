using System;
using System.Collections;
using System.Collections.Generic;

// N개의 최소공배수
// 유클리드 호제법: 2개의 자연수 a, b(a > b)에 대해서 a를 b로 나눈 나머지가 r일 때, a와 b의 최대공약수는 b와 r의 최대공약수와 같다.
// 1. GCD: 나누어 떨어질 때까지 나누어서 최대공약수를 구하기
// 2. LCM: a와 b의 최소공배수는 a와 b의 곱을 a와 b의 최대공약수를 나눈 것과 같다
// 3. 먼저 앞 두 수에 대한 최소 공배수를 구한 뒤 구해진 최소 공배수와 다음 수 1개와 최소 공배수를 구하기
public class Solution
{
    public int GCD(int a, int b)
    {
        while (b != 0)
        {
            int gcd = a % b;
            a = b;
            b = gcd;
        }
        return a;
    }

    public int LCM(int a, int b)
    {
        int lcm = (a * b) / GCD(a, b);
        return lcm;
    }

    public int solution(int[] arr)
    {
        int answer = LCM(arr[0], arr[1]);
        for (int i = 2; i < arr.Length; i++)
        {
            answer = LCM(answer, arr[i]);
        }
        return answer;
    }
}