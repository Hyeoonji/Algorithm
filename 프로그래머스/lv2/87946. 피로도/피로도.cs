using System;

// 피로도
// DFS(Depth First Search) 사용: 방문 여부를 확인하여 경우의 수를 모두 탐색
public class Solution
{
    public bool[] visited;                      //방문여부                      
    public int answer = 0;

    public int solution(int k, int[,] dungeons)
    {
        //int answer = -1;
        visited = new bool[dungeons.Length];
        DFS(k,dungeons,visited,0);

        return answer;
    }

    public int DFS(int k, int[,] dungeons, bool[] visited, int count)
    {
        int length = dungeons.GetLength(0);     //경우의 수
        //1번부터 시작하여 모든 경우의 수를 다 돌아보는 방식. 이후 최대값을 찾는다
        for(int i = 0; i < length; i++)
        {
            //dungeons[i, 0]: 최소 필요
            if (k >= dungeons[i,0] && !visited[i])
            {
                visited[i] = true;

                //dungeons[i, 1]: 소모
                DFS(k - dungeons[i, 1], dungeons, visited, count + 1);
                visited[i] = false;             //하나의 경우를 돌고난 후 새로운 시작을 위해 다시 false
            }
        }

        answer = Math.Max(count,answer);        //돌때마다 최대값을 비교해서 넣기
        return answer;
    }
}