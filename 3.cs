﻿using System;
using System.Text;
using static System.Console;

namespace Baekjoon;

// 2739. 구구단
//class Project
//{
//    static void Main(string[] args)
//    {
//        int a = int.Parse(Console.ReadLine());
//        for (int i = 1; i < 10; i++)
//        {
//            Console.WriteLine(a + " * " + i + " = " + a * i);
//        }
//    }
//}

// 10950. A+B - 3
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int times = int.Parse(ReadLine());

//        for (int i = 0; i < times; i++)
//        {
//            string[] input = ReadLine().Split();
//            int num1 = int.Parse(input[0]);
//            int num2 = int.Parse(input[1]);
//            WriteLine(num1 + num2);
//        }
//    }
//}

// 8393. 합
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int score = int.Parse(ReadLine());

//        int sum = 0;

//        for (int i = 1; i <= score; i++)
//        {
//            sum = sum + i;
//        }
//        WriteLine(sum);

//    }
//}

// 25304. 영수증
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int total = int.Parse(ReadLine());
//        int num = int.Parse(ReadLine());
//        int sum = 0;
//        for (int i = 0; i < num; i++)
//        {
//            string[] input = ReadLine().Split();
//            int num1 = int.Parse(input[0]);
//            int num2 = int.Parse(input[1]);
//            sum += num1 * num2;
//        }
//        if (total == sum)
//        {
//            WriteLine("Yes");
//        }
//        else
//        {
//            WriteLine("No");
//        }
//    }
//}

// 25314. 코딩은 체육과목 입니다
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 문제의 정수 N
//        int N = int.Parse(Console.ReadLine());

//        // 정수 자료형 1개 당 4
//        int num = N / 4;
//        // 갯수만큼 long 반복
//        for (int i = 0; i < num; i++)
//        {
//            Console.Write("long ");
//        }
//        Console.Write("int");

//    }
//}

// 15552. 빠른 A+B

// 11021. A+B - 7
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int times = int.Parse(ReadLine());

//        for (int i = 0; i < times; i++)
//        {
//            string[] input = ReadLine().Split();
//            int num1 = int.Parse(input[0]);
//            int num2 = int.Parse(input[1]);
//            WriteLine("Case #{0}: {1}", i + 1, num1 + num2);
//        }
//    }
//}

// 11022. A+B - 8
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int times = int.Parse(ReadLine());

//        for (int i = 0; i < times; i++)
//        {
//            string[] input = ReadLine().Split();
//            int num1 = int.Parse(input[0]);
//            int num2 = int.Parse(input[1]);
//            WriteLine("Case #{0}: {1} + {2} = {3}", i + 1, num1, num2, num1 + num2);
//        }
//    }
//}

// 2435. 별찍기 1
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int times = int.Parse(ReadLine());

//        for (int i = 0; i < times; i++)
//        {
//            for (int j = 0; j <= i; j++)
//            {
//                Write("*");
//            }
//            WriteLine();
//        }
//    }
//}

// 2439. 별찍기 2
//public class Program 
//{
//    static void Main(string[] args)
//    {
//        int times = int.Parse(ReadLine());
//        for(int i =1; i <= times; i++)
//        {
//            for(int j = times- i-1; j >=0; j--)
//            {
//                Write(" ");
//            }
//            for(int k =0; k <i; k++)
//            {
//                Write("*");
//            }
//            WriteLine();
//        }
//        Read();
//    }
//}

//----------------------------------
// ToString(): 문자열 변환 함수

// 10952. A + B - 5 
//public class Program 
//{
//    static void Main(string[] args)
//    {
//        while(true)
//        {
//            string[] str = Console.ReadLine().Split();
//            int a = int.Parse(str[0]);
//            int b = int.Parse(str[1]);
//            int sum = a + b;

//            if(a == 0 && b == 0) 
//            {
//                break;
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}
//----------------------------------------
// while() : 조건식이 true 일 때까지만 실행을 반복

// 10951. A + B - 4
//public class Program
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {

//            string input = Console.ReadLine();
//            if (input == null)
//            {
//                break;
//            }

//            string[] str = input.Split();
//            int a = int.Parse(str[0]);
//            int b = int.Parse(str[1]);
//            int sum = a + b;

//            Console.WriteLine(sum);
//        }
//    }
//}
//----------------------------------------
// 10952와의 차이점: 마지막이 지정되지 않음 -> 직접 마지막을 확인하는 과정이 필요

// 1110. 더하기 사이클
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int n = int.Parse((Console.ReadLine())); // 첫째줄에 받기
//        int m = n;
//        int count = 0; // 횟수
//        while (true)
//        {
//            int t = m / 10; // 십의 자리
//            int a = m % 10; // 일의 자리

//            m = ((a * 10) + (t + a)%10); 
//            // 일의 자리가 12가 된다면 2만 가져가기
//            count++;
//            if (m == n)
//            {
//                break;
//            }
//        }
//        Console.WriteLine(count);

//    }
//}