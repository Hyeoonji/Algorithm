using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string a, string b)
    {
        List<int> list = new List<int>();

        string answer = "";

        int lena = a.Length;
        int lenb = b.Length;
        string gap = "";

        if (lena < lenb)
        {
            for (int i = 0; i < lenb - lena; i++)
            {
                gap += "0";
            }
            string num = gap + a;
            a = num;
        }
        else
        {
            for (int i = 0; i < lena - lenb; i++)
            {
                gap += "0";
            }
            string num = gap + b;
            b = num;
        }

        list.Add(0);

        for (int i = 0; i < a.Length; i++)
        {
            int plus = int.Parse(a[i].ToString()) + int.Parse(b[i].ToString());
            list.Add(plus);
        }

        int up = 0;

        for (int i = list.Count - 1; i >= 0; i--)
        {
            int num = list[i] + up;
            up = num / 10;
            list[i] = num % 10;
        }

        answer = string.Join("", list);

        return answer;
    }
}