public class Program
{
    static void Main(string[] args)
    {
        //첫째 줄에 숫자 입력받기
        char num = Convert.ToChar(Console.ReadLine());
        // 아스키코드로 출력하기
        int ascii = Convert.ToInt32(num);
        Console.WriteLine(ascii);
    }
}