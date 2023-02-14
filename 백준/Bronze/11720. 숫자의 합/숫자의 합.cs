public class Program
{
    // 기존의 숫자 합과의 차이점: 공백
    // 일반적인 정수 자료형에 담기에 너무 크다는 것에 주의
    static void Main(string[] args)
    {
        // 첫째줄에 숫자의 개수n
        int n = int.Parse(Console.ReadLine());
        // 둘째줄에 숫자가 개수만큼 공백없이 주어짐
        string str = Console.ReadLine();

        // 합을 받을 변수
        int count = 0;
        // 숫자 n개의 합 출력하기
        for(int i =0; i < n; i++)
        {
            count += int.Parse(str[i].ToString());
        }
        Console.WriteLine(count);

    }
}