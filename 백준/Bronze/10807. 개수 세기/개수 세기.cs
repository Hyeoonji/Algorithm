public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] m = new int[n];
            string[] str = Console.ReadLine().Split();
            int v = int.Parse(Console.ReadLine());
            int count = 0;

            for(int i =0; i < str.Length; i++)
            {
                m[i] = int.Parse(str[i]);
                if (m[i] == v)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }