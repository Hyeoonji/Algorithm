public class Program
{
    static void Main(string[] args)
    {
        // 첫째줄에 순서대로 ABC 사이 공백
        string[] str = Console.ReadLine().Split();
        int A = int.Parse(str[0]);
        int B = int.Parse(str[1]);
        int C = int.Parse(str[2]);
        // 첫째 줄에 (A+B)%C
        Console.WriteLine((A + B) % C);
        // 둘째 줄에 ((A%C) + (B%C))%C
        Console.WriteLine(((A % C) + (B % C)) % C);
        // 셋째 줄에 (A×B)%C
        Console.WriteLine((A*B) % C);
        // 넷째 줄에 ((A%C) × (B%C))%C 출력
        Console.WriteLine(((A % C) * (B % C)) % C );
    }
}