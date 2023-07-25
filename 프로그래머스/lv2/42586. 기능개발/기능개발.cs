using System;
using System.Collections.Generic;
using System.Linq;

// 기능개발
public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> result = new List<int>();

        while (true)
        {
            int count = 0;
            for(int i = result.Sum(); i < progresses.Length; i++)       //값이 계속 이어져야 하기 때문에 Sum()으로 시작
            {
                progresses[i] += speeds[i];
            }

            if (progresses[result.Sum()] >= 100)                        //만약 값이 100보다 크면
            {
                for(int i = result.Sum();i < progresses.Length; i++)    //끝까지 돌려서 100 넘는 값 확인
                {
                    if (progresses[i] >= 100)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if(count > 0)                                       //값이 있다면 리스트에 추가
            {
                result.Add(count);
            }

            if(result.Sum() == progresses.Length)               //리스트의 모든 값(=개수)가 길이와 동일해지면 종료
            {
                break;
            }
            
        }
        
        return result.ToArray();
    }
}
