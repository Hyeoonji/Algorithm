using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// 프로세스
// 1. 중요도와 동일한 길이의 배열을 하나 준비
// 2. 가장 큰 우선순위를 구함
// 3. 배열의 같은 위치에 숫자 기입
// 4. 그 다음으로 큰 우선순위 구하기
// 5. 반복
// 6. 원하는 위치의 숫자를 출력
public class Solution
{
    public int findOrder(int[] priorities, int num, int start)  //우선순위의 위치 구하기
    {
        int count = 0;                                      //발견 위치
        for (int i = start; i < priorities.Length; i++)
        {
            if (priorities[i] == num)
            {
                count = i;
                priorities[i] = 0;                          //검출되지 않도록 0으로 변경
                break;
            }
        }

        if (count == 0)                                      //count가 0 -> 우선순위와 동일한게 없음
        {
            for (int i = 0; i < start; i++)                 //앞에부터 구하기
            {
                if (priorities[i] == num)
                {
                    count = i;
                    priorities[i] = 0;
                    break;
                }
            }
        }

        return count;                                       //위치를 출력
    }

    public int solution(int[] priorities, int location)
    {
        int answer = 0;
        int[] sequence = new int[priorities.Length];

        int max = priorities.Max();
        int start = 0;
        int order = 1;

        for (int i = 0; i < priorities.Length; i++)
        {
            int count = findOrder(priorities, max, start);
            if(priorities.Contains(max) == false)
            {
                max = priorities.Max();
            }
            sequence[count] = order;
            start = count;
            order++;
        }
        
        answer = sequence[location];
        return answer;
    }
}