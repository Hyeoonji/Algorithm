using System;
namespace Baekjoon;

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

// 10