using System;
using static System.Console;

namespace baekjoon {
	public class Program {
		static void Main(string[] args) {
			int times = int.Parse(ReadLine());

			for (int i = 0; i < times; i++) {
				for (int j = 0; j <= i; j++){
                    Write("*");
                }
            WriteLine();
			}
		} 
	}
}