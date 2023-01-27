namespace baekjoon{
    class Program{
        static void Main(string[] args){
            string[] str = Console.ReadLine().Split();

            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);

            if(A > B){
                Console.WriteLine(">");
            } else if(A < B){
                Console.WriteLine("<");
            } else { Console.WriteLine("=="); }
        }
    }
}
		
            

