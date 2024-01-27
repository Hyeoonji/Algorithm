using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = strArr.Where(i => !i.Contains("ad")).ToArray();
        return answer;
    }
}