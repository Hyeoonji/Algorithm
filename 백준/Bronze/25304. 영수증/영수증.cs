using System;
using static System.Console;
namespace baekjoon;
    public class Program{
        static void Main(string[] args){
            int total = int.Parse(ReadLine());
            int num = int.Parse(ReadLine());
            int sum = 0;
            for (int i = 0; i < num; i++) {
				string[] input = ReadLine().Split();
				int num1 = int.Parse(input[0]);
				int num2 = int.Parse(input[1]);
				sum += num1 * num2;
            } if(total == sum){
                WriteLine("Yes");
            } else {
                WriteLine("No");
            }
        }
    }