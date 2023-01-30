public class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[10]; // 숫자 10개
        for (int i = 0; i < num.Length; i++)
        {
            // 42의 나머지를 저장
            num[i] = int.Parse(Console.ReadLine()) % 42;
        }

        Console.WriteLine(num.Distinct().Count());
    }
}