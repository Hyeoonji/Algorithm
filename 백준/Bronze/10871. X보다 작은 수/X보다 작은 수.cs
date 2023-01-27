public class Program
{
    static void Main(string[] args)
    {
        // 첫째 줄에 N과 X가 주어진다
        string[] str = Console.ReadLine().Split();

        //둘째 줄에 수열 A를 이루는 정수 N개가 주어진다
        string[] a = Console.ReadLine().Split();

        for(int i=0; i< int.Parse(str[0]); i++)
        {
            // x보다 작으면
            if (int.Parse(a[i]) < int.Parse(str[1]))
            {
                // 작은 수를 순서대로 출력, 사이는 공백처리
                Console.Write(a[i] + " ");
            }
        }
    }
}