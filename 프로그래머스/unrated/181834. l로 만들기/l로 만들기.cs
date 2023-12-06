using System;

// I로 만들기
public class Solution
{
    public string solution(string myString)
    {
        string answer = "";
        char[] chatArray = myString.ToCharArray();
        int numI = 108;
        for (int i = 0; i < chatArray.Length; i++)
        {
            int num = Convert.ToInt32(chatArray[i]);
            if (num < numI)
            {
                chatArray[i] = (char)numI;
            }

            answer += chatArray[i];

        }

        return answer;
    }
}