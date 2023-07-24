using System;
using System.Linq;

// H-Index
public class Solution
{
    public int solution(int[] citations)
    {
        //h번 이상 인용된 논문이 h개 이상, 나머지가 h번 이하
        int answer = 0;
        int index = citations.Max();      //배열의 최댓값을 일단 부여
        
        while (true)
        {
            int count = 0;
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] >= index)
                {
                    count++;
                }
            }

            if (count >= index)         //개수와 값을 비교해서 같으면 중단
            {
                break;
            }
            else                        //다르면 하나씩 줄여나가기
            {
                index--;
            }
        }

        answer = index;
        return answer;
    }
}