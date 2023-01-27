using System;
using static System.Console;

namespace baekjoon {
    public class Program {
		static void Main(string[] args) {
			int score = int.Parse(ReadLine());
            
            int sum = 0;

			for (int i = 1; i <= score; i++) 
            {
                sum = sum + i;
			}
            WriteLine(sum);

		}
	}
}