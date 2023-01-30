﻿namespace Baekjoon;

// 10807. 개수 세기
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        int[] m = new int[n];
//        string[] str = Console.ReadLine().Split();
//        int v = int.Parse(Console.ReadLine());
//        int count = 0;

//        for (int i = 0; i < str.Length; i++)
//        {
//            m[i] = int.Parse(str[i]);
//            if (m[i] == v)
//            {
//                count++;
//            }
//        }
//        Console.WriteLine(count);
//    }
//}

// 10871. X보다 작은 수
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 첫째 줄에 N과 X가 주어진다
//        string[] str = Console.ReadLine().Split();

//        //둘째 줄에 수열 A를 이루는 정수 N개가 주어진다
//        string[] a = Console.ReadLine().Split();

//        for (int i = 0; i < int.Parse(str[0]); i++)
//        {
//            // x보다 작으면
//            if (int.Parse(a[i]) < int.Parse(str[1]))
//            {
//                // 작은 수를 순서대로 출력, 사이는 공백처리
//                Console.Write(a[i] + " ");
//            }
//        }
//    }
//}

// 10818. 최소,최대
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 정수의 개수 N
//        int n = int.Parse(Console.ReadLine());
//        // 최대 최소
//        int max = int.MinValue;
//        int min = int.MaxValue;
//        // N개의 정수를 공백으로 주어짐
//        string[] str = Console.ReadLine().Split();
//        // 정수 배열
//        int[] s = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            s[i] = int.Parse(str[i]);
//        }

//        for (int i = 0; i < n; i++)
//        {
//            if (s[i] > max)
//            {
//                max = s[i];
//            }
//            if (s[i] < min)
//            {
//                min = s[i];
//            }
//        }
//        Console.WriteLine("{0} {1}", min, max);
//    }
//}
//-----------------------------
// Array.ConvertAll
// ConvertAll은 전달인자(argument)로 사용되는 배열형(ArrayType) 입력하고, 전달인자로 변환하고자 하는 배열(Array)와 형변환 함수 "Convert."를 입력

// 2562.  최댓값
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 자연수 9개를 받음
//        int[] num = new int[9];
//        int max =0; //최댓값
//        int count =0; // 순서

//        for (int i = 0; i < 9; i++)
//        {
//            num[i] = int.Parse(Console.ReadLine());
//            // 만약 max가 num 보다 작다면
//            if(max < num[i])
//            {
//                max = num[i]; // 그 숫자가 최대값
//                count = i + 1; // 순서는 +1
//            }
//        }
//        Console.WriteLine(max);
//        Console.WriteLine(count);
//    }

//}

// 5597. 과제 안 내신 분,,?
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int[] num = new int[30]; //30개 -> 받는건 28이지만 30까지

//        for (int i = 0; i < 28; i++)
//        {
//            int n = int.Parse(Console.ReadLine()); // 번호에 숫자를 받음
//            // num[n] = 1; 숫자를 받으면 1로 표시 --> 에러발생
//            // -> 받는건 1부터 시작하는데 0부터 저장하려고 해서 n-1로 수정
//            num[n-1] = 1;
//        }
//        for (int i = 0; i < 30; i++)
//        {
//            if (num[i] != 1)  // 1~30중에 1이 안들어 있는 번호
//            {
//                //Console.WriteLine(i); -1 되어있는 상태이기 때문에 +1 해줌
//                Console.WriteLine(i+1); // 번호 출력
//            }
//        }
//    }
//}

// 3052. 나머지
public class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[10]; // 숫자 10개
        int[] div = new int[42]; // 42의 나머지
        int count=0;
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
            div[i] = num[i] % 42;
            for (int j = 0; j < 42; j++)
            {
                if (div[i] == j)  // i와 비교해서 나머지가 있다면
                {
                    div[i] = 1;
                    count++;
                }
            }
        }      
        Console.WriteLine(count);
    }
}