using System;

namespace beakjoon
{
    class Program
    {
        static void Main(string[] args)
        {    
            string[] in_str = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(in_str[0]) + int.Parse(in_str[1]));
        }
    }
}