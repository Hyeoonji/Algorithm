using System;
using System.Collections.Generic;

// 게임 맵 최단거리
class Solution
{
    int n = 0;
    int m = 0;

    int[] dx = { -1, 1, 0, 0 };
    int[] dy = { 0, 0, -1, 1 };

    Queue<(int, int)> que = new Queue<(int, int)>();

    public void BFS(int i, int j, int[,] maps)
    {
        que.Enqueue((i, j));                            //현재 값 넣기
        while (que.Count != 0)
        {
            (int a, int b) = que.Dequeue();             //q값 받기

            for (int k = 0; k < 4; k++)                 //상하좌우 반복
            {
                int nx = a + dx[k];
                int ny = b + dy[k];

                if (nx < 0 || nx >= n || ny < 0 || ny >= m) continue;   //범위를 벗어난 경우

                if (maps[nx, ny] == 0) continue;                        //벽

                if (maps[nx, ny] == 1)
                {
                    maps[nx, ny] = maps[a, b] + 1;
                    que.Enqueue((nx, ny));
                }
            }
        }
    }

    public int solution(int[,] maps)
    {
        //int answer = 0;
        n = maps.GetLength(0);
        m = maps.GetLength(1);

        BFS(0, 0, maps);

        if (maps[n - 1, m - 1] == 1)
        {
            return -1;
        }
        else return (maps[n - 1, m - 1]);
    }
}