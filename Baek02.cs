namespace Baekjoon;

/*// 1330. 두 수 비교하기
class Program
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split();

        int A = int.Parse(str[0]);
        int B = int.Parse(str[1]);

        if (A > B)
        {
            Console.WriteLine(">");
        }
        else if (A < B)
        {
            Console.WriteLine("<");
        }
        else { Console.WriteLine("=="); }
    }
}*/

/*// 9498. 시험 성적
class Program
{
    static void Main(string[] args)
    {
        int score = int.Parse(Console.ReadLine());

        if (score >= 90 && score <= 100)
        {
            Console.WriteLine("A");
        }
        else if (score >= 80 && score <= 89)
        {
            Console.WriteLine("B");
        }
        else if (score >= 70 && score <= 79)
        {
            Console.WriteLine("C");
        }
        else if (score >= 60 && score <= 69)
        {
            Console.WriteLine("D");
        }
        else { Console.WriteLine("F"); }

    }
}*/

/*// 2753. 윤년
class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        if (((year % 4 == 0) & (year % 100 != 0)) || (year % 400 == 0))
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}*/

/*// 14681. 사분면 고르기
class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine("1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("3");
        }
        else
        {
            Console.WriteLine("4");
        }
    }
}*/

/*// 2884. 알람 시계
class System
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split(" ");
        int h = int.Parse(str[0]);
        int m = int.Parse(str[1]);

        m = m - 45; // 45분 감소
        if (m >= 0) // 45분이 감소 해도 그 값이 0 보다 크다면
        {
            Console.WriteLine($"{h} {m}"); // 바로 출력
        }
        else if (m < 0) // 45분이 감소 해서 그 값이 0 보다 작을 때
        {
            if (h == 0) // 0시라면 
            {
                h = 23; //전날23시로 변경
            }
            else
            {
                h -= 1;

            }
            m += 60; // m이 0보다 작으면 음수이기때문에 

            Console.WriteLine($"{h} {m}");
        }
    }
}*/

/*// 2525. 오븐 시계
class Program
{
    public static int Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        int h = int.Parse(s[0]);
        int m = int.Parse(s[1]);
        int time = int.Parse(Console.ReadLine());
        m += time;
        while (m >= 60)
        {
            m -= 60;
            h++;
        }
        while (h >= 24)
        {
            h %= 24;
        }

        Console.WriteLine(h + " " + m);
        return 0;
    }
}*/

/*// 2480. 주사위 세개
class Program
{
    public static int Main(string[] args)
    {
        string[] str = Console.ReadLine().Split();
        int a = int.Parse(str[0]);
        int b = int.Parse(str[1]);
        int c = int.Parse(str[2]);
        int cash;
        int max = 0;
        max = ((a > b) && (a > c)) ? a : ((b > a) && (b > c)) ? b : c;

        if (a == b && b == c)
        {
            cash = 10000 + a * 1000;
        }
        else if (a == b)
        {
            cash = 1000 + a * 100;
        }
        else if (b == c)
        {
            cash = 1000 + b * 100;
        }
        else if (a == c)
        {
            cash = 1000 + c * 100;
        }
        else
        {
            cash = max * 100;
        }

        Console.WriteLine(cash);
        return 0;
    }
}*/


