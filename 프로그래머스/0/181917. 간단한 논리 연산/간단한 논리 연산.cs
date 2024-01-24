using System;

public class Solution
{
    public bool solution(bool x1, bool x2, bool x3, bool x4)
    {
        bool answer = true;
        bool temp12 = true;
        bool temp34 = true;

        if(x1 == true)
        {
            if(x2 == true) { temp12 = true; } 
            else { temp12 = true; }
        }
        else
        {
            if (x2 == true) { temp12 = true; }
            else { temp12 = false; }
        }


        if (x3 == true)
        {
            if (x4 == true) { temp34 = true; }
            else { temp34 = true; }
        }
        else
        {
            if (x4 == true) { temp34 = true; }
            else { temp34 = false; }
        }

        if (temp12 == true)
        {
            if (temp34 == true) { answer = true; }
            else { answer = false; }
        }
        else
        {
            if (temp34 == true) { answer = false; }
            else { answer = false; }
        }

        return answer;
    }
}