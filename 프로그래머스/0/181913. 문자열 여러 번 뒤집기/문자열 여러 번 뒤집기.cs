using System;

public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
                string answer = "";

        char[] cha = my_string.ToCharArray();
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int startIdx = queries[i, 0];
            int endIdx = queries[i, 1] - queries[i, 0] + 1;

            Array.Reverse(cha, startIdx, endIdx);
        }

        answer = new string(cha);

        return answer;
    }
}