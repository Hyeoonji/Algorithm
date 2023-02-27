public class Program
{
    static void Main(string[] args)
    {
        // 첫째 줄에 두 수 A B
        string[] num = Console.ReadLine().Split();
        int numA = int.Parse(num[0]);
        int numB = int.Parse(num[1]);

        // 일의 자리 *100 + 십의 자리 + 백의 자리
        int reA = (numA % 10 * 100) + (numA/10 - (numA/100)*10)*10 + (numA / 100);
        int reB = (numB % 10 * 100) + (numB/10 - (numB/100)*10)*10 + (numB / 100);
        
        if (reA > reB)
        {
            Console.WriteLine(reA);
        }
        else
        {
            Console.WriteLine(reB);
        }
    }
}