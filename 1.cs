using System.Net.NetworkInformation;

namespace Baekjoon;

// 2557. Hello World
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello World!");
//    }
//}

// 1000. A+B
//class Program
//{
//    static void Main(string[] args)
//    {
//        string[] in_str = Console.ReadLine().Split();
//        Console.WriteLine(int.Parse(in_str[0]) + int.Parse(in_str[1]));
//    }
//}

// 1001. A-B
//class Program
//{
//    static void Main()
//    {
//        string s = Console.ReadLine();
//        string[] ss = s.Split();
//        int a = int.Parse(ss[0]);
//        int b = int.Parse(ss[1]);

//        Console.WriteLine(a - b);
//    }
//}
// 10998. A×B
//class Program
//{
//    static void Main()
//    {
//        string s = Console.ReadLine();
//        string[] ss = s.Split();

//        int a = int.Parse(ss[0]);
//        int b = int.Parse(ss[1]);

//        Console.WriteLine(a * b);
//    }
//}

// 1008. A/B
//class Program
//{
//    static void Main()
//    {
//        string s = Console.ReadLine();
//        string[] ss = s.Split();
//        double a = double.Parse(ss[0]);
//        double b = double.Parse(ss[1]);

//        Console.WriteLine(a / b);
//    }
//}

// 10869. 사칙연산
//class Program
//{
//    static void Main()
//    {
//        string s = Console.ReadLine();
//        string[] ss = s.Split();
//        int a = int.Parse(ss[0]);
//        int b = int.Parse(ss[1]);

//        Console.WriteLine(a + b);
//        Console.WriteLine(a - b);
//        Console.WriteLine(a * b);
//        Console.WriteLine(a / b);
//        Console.WriteLine(a % b);
//    }
//}

// 10926. ??!
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s = Console.ReadLine();
//        Console.WriteLine(s + "??!");
//    }
//}

// 18108. 1998년생인 내가 태국에서는 2541년생?!
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine(a - 543);
//    }
//}

// 10430. 나머지
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 첫째줄에 순서대로 ABC 사이 공백
//        string[] str = Console.ReadLine().Split();
//        int A = int.Parse(str[0]);
//        int B = int.Parse(str[1]);
//        int C = int.Parse(str[2]);
//        // 첫째 줄에 (A+B)%C
//        Console.WriteLine((A + B) % C);
//        // 둘째 줄에 ((A%C) + (B%C))%C
//        Console.WriteLine(((A % C) + (B % C)) % C);
//        // 셋째 줄에 (A×B)%C
//        Console.WriteLine((A * B) % C);
//        // 넷째 줄에 ((A%C) × (B%C))%C 출력
//        Console.WriteLine(((A % C) * (B % C)) % C);
//    }
//}

// 2588. 곱셈 
//public class Program
//{
//    static void Main(string[] args)
//    {
//        string a = Console.ReadLine();
//        string b = Console.ReadLine();

//        Console.WriteLine(int.Parse(a)* (int) Char.GetNumericValue(b[2]));
//        Console.WriteLine(int.Parse(a)* (int) Char.GetNumericValue(b[1]));
//        Console.WriteLine(int.Parse(a)* (int) Char.GetNumericValue(b[0]));
//        Console.WriteLine(int.Parse(a)* int.Parse(b));

//    }
//}

// 11382. 꼬마 정민
//public class Program
//{
//    static void Main(string[] args)
//    {
//        string[] str = Console.ReadLine().Split(" ");
//        double A = double.Parse(str[0]);
//        double B = double.Parse(str[1]);
//        double C = double.Parse(str[2]);

//        Console.WriteLine(A + B + C);
//    }
//}

// 10171. 고양이
//public class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("\\    /\\");
//        Console.WriteLine(" )  ( ')");
//        Console.WriteLine("(  /  )");
//        Console.WriteLine(" \\(__)|");
//    }
//}

//------------------------------
// \: 줄바꿈 기호
// \를 한번 출력하기위해서는 두번 입력해야한다.

// 10172. 개
//public class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("|\\_/|");
//        Console.WriteLine("|q p|   /}");
//        Console.WriteLine("( 0 )\"\"\"\\");
//        Console.WriteLine("|\"^\"`    |");
//        Console.WriteLine("||_/=\\\\__|");
//    }
//}

// 25083. 새싹
//public class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("         ,r'\"7");
//        Console.WriteLine("r`-_   ,'  ,/");
//        Console.WriteLine(" \\. \". L_r'");
//        Console.WriteLine("   `~\\/");
//        Console.WriteLine("      |");
//        Console.WriteLine("      |");
//    }
//}

// 3003. 킹, 퀸, 룩, 비숍, 나이트, 폰
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 킹(1), 퀀(1), 룩(2), 비숍(2), 나이트(2), 폰(8)
//        string[] str = Console.ReadLine().Split();
//        int[] che = { 1, 1, 2, 2, 2, 8 };
//        for(int i = 0; i < str.Length; i++)
//        {
//            che[i] -= int.Parse(str[i]);
//        }
//        for (int i = 0; i < str.Length; i++)
//        {
//            Console.Write(che[i]);
//            Console.Write(" ");
//        }
        
//    }
//}

