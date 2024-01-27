using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] names) {
        string[] answer = new string[names.Length/5];

        List<String> list = new List<String>();
        
        for(int i = 0; i < names.Length; i++)
        {
            if(i%5 == 0)
            {
                list.Add(names[i]);
            }
        }
        answer = list.ToArray();
        return answer;
    }
}