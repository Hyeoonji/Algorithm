public class Program
{
    static void Main(string[] args)
    {
        // 첫째줄에 바구니 개수 N 진행횟수 M
        string[] str = Console.ReadLine().Split();
        int N = int.Parse(str[0]);
        int M = int.Parse(str[1]);

        // 공의 번호를 받을 배열
        int[] count = new int[N];

        for (int i = 0; i < N; i++)
        {
            count[i] = 0;
        }

        // 둘째줄부터 ( 시작바구니i 끝바구니j 넣을공의번호k ) 를 M만큼 반복
        for (int i = 0; i < M; i++)
        {
            string[] Case = Console.ReadLine().Split();
            int start = int.Parse(Case[0]);
            int End = int.Parse(Case[1]);
            int num = int.Parse(Case[2]);

            for(int j = start-1; j <= End-1; j++)
            {
                count[j] = int.Parse(Case[2]);
            }
        }
        foreach (int number in count)
        {
            Console.Write(number + " ");
        }
    }
}
