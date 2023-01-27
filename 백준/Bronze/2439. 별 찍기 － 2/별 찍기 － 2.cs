using System;
using static System.Console;

namespace Baekjoon;
// 2439. 별찍기 2
public class Program
{
    static void Main(string[] args)
    {
        int times = int.Parse(ReadLine());
        for(int i =1; i <= times; i++)
        {
            for(int j = times- i-1; j >=0; j--)
            {
                Write(" ");
            }
            for(int k =0; k <i; k++)
            {
                Write("*");
            }
            WriteLine();
        }
        Read();
    }
}