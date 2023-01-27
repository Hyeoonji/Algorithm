using System;
namespace baekjoon
{
    class Program
	{
		static void Main()
		{
			string s = Console.ReadLine();
			string[] ss = s.Split();
			double a = double.Parse(ss[0]);
			double b = double.Parse(ss[1]);

			Console.WriteLine(a/b);
		}
	}
}