using System;

public class Solution {
    public string solution(string my_string, int[] index_list) {
        string answer = "";
        char[] strCha = my_string.ToCharArray();
        for(int i = 0; i < index_list.Length; i++)
        {
            answer+= strCha[index_list[i]];
        }
        
        return answer;
    }
}