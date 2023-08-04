using System;

// 타겟넘버
// 모든 경우의 수 구하기
public class Solution
{
    int answer;
    int count;

    public int DFS(int[] numbers, int target, int index, int sum, bool plus)
    {
        if (index == numbers.Length)
        {
            if (sum == target)
            {
                count++;
            }
            answer = Math.Max(count, answer)/2;        //돌때마다 최대값을 비교해서 넣기
            return answer;
        }

        //방문했다면 +, 아니라면 -;
        if (plus)
        {
            sum += numbers[index];
        }
        else
        {
            sum -= numbers[index];
        }

        //index가 끝까지 갔는지 확인. 아니라면 경우의 수 다 돌기, 맞다면 target과 같을때만 ++;

        DFS(numbers, target, index + 1, sum, true);
        DFS(numbers, target, index + 1, sum, false);


        return answer;
    }

    public int solution(int[] numbers, int target)
    {
        answer = 0;
        count = 0;
        int sum = 0;
        DFS(numbers, target, 0, sum, true);
        DFS(numbers, target, 0, sum, false);

        return answer;
    }

}