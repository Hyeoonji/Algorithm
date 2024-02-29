using System;

public class Solution
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        int num = 0;
        int den = 0;

        int min = gcd(denom1, denom2);
        den = (denom1 * denom2) / min;

        numer1 *= (den / denom1);
        numer2 *= (den / denom2);

        num = numer1 + numer2;

        int min2 = gcd(num, den);
        num = num / min2;
        den = den / min2;

        int[] answer = new int[] { num, den };
        return answer;
    }

    static int gcd(int x, int y)
    {
        return (x % y == 0 ? y : gcd(y, x % y));
    }
}