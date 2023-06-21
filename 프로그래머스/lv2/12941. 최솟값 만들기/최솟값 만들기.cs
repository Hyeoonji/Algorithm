using System;

public class Solution
{
    //최솟값을 구하는 방법
    //가장 큰 수는 가장 작은 수와 곱하는 방식
    //배열을 한개는 오름차순, 한개는 내림차순으로 정렬
    //순서대로 곱하기
    public int solution(int[] A, int[] B)
    {
        int answer = 0;
        Array.Sort(A);          //오름차순 정렬
        Array.Sort(B);       //오름차순 정렬 후 
        Array.Reverse(B);       //내림차순 정렬

        for (int i = 0; i < A.Length; i++)
        {
            answer += (A[i] * B[i]);
        }

        return answer;
    }
}