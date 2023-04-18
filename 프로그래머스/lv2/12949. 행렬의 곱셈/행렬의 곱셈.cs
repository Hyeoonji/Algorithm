public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        // 행(0), 열(1)
        int[,] answer = new int[arr1.GetLength(0),arr2.GetLength(1)] ;
        
        // 밑으로 증가 a -> c
        for(int i = 0; i < arr1.GetLength(0); i++)
        {
            // 앞 행렬 증가 a -> b
            for(int j = 0; j <arr1.GetLength(1); j++)
            {
                //뒤 행렬 증가 x1 -> y1
                for(int k = 0; k < arr2.GetLength(1); k++)
                {
                    answer[i,k] += arr1[i,j] * arr2[j,k];
                }
            }
        }
        return answer;
    }
}