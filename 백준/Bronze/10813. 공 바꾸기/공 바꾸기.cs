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

        // 1부터 넣어주기
        for (int i = 0; i < N; i++)
        {
            count[i] = i + 1;
        }

        // 둘째줄부터(바구니i 바구니j) 를 M만큼 반복
        for (int i = 0; i < M; i++)
        {
            string[] Case = Console.ReadLine().Split();
            int bucketi = int.Parse(Case[0]);
            int bucketj = int.Parse(Case[1]);

            int balli = count[bucketi - 1];
            // i번째 바구니에 j번째 공 넣어주기
            count[bucketi-1] = count[bucketj - 1];
            // j번째 바구니에 i번째 공 넣어주기
            count[bucketj-1] = balli;

        }
        foreach (int number in count)
        {
            Console.Write(number + " ");
        }
    }
}