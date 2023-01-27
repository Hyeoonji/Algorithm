using System;
using static System.Console;

namespace baekjoon {
	public class Program {
		static void Main(string[] args) {
			int times = int.Parse(ReadLine());

			for (int i = 0; i < times; i++) {
				string[] input = ReadLine().Split();
				int num1 = int.Parse(input[0]);
				int num2 = int.Parse(input[1]);
				WriteLine("Case #{0}: {1} + {2} = {3}", i+1, num1, num2, num1 + num2);
			}
		}
	}
}