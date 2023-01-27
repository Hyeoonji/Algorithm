using System;
namespace baekjoon{
    class System{
        static void Main(string[] args){
            string[]str = Console.ReadLine().Split(" ");
            int h = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            
            m = m - 45; // 45분 감소
            if (m >= 0) // 45분이 감소 해도 그 값이 0 보다 크다면
            {
                Console.WriteLine($"{h} {m}"); // 바로 출력
            }
            else if (m < 0) // 45분이 감소 해서 그 값이 0 보다 작을 때
            {
                if (h == 0) // 0시라면 
                {
                    h = 23; //전날23시로 변경
                }
                else
                {
                    h -= 1;
 
                }
                m += 60; // m이 0보다 작으면 음수이기때문에 
                
                Console.WriteLine($"{h} {m}");
            }
        }
    }
}