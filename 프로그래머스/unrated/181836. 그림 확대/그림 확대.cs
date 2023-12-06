using System;

public class Solution
{
    public string[] solution(string[] picture, int k)
    {
        string[] once = new string[picture.Length];         
        string[] answer = new string[picture.Length * k];   
        for (int i = 0; i < picture.Length; i++)            
        {
            char[] charArray;                   
            charArray = picture[i].ToCharArray();           
            for (int j = 0; j < charArray.Length; j++)
            {
                for (int l = 0; l < k; l++)
                {
                    once[i] += charArray[j];                
                }
            }
        }

        for (int i = 0; i < picture.Length; i++)            
        {
            for (int j = 0; j < k; j++)                     
            {
                answer[k * i + j] = once[i];            
            }
        }

        return answer;
    }
}