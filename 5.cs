using System.Text;
using System.IO;

namespace Baekjoon;

//4673. 셀프 넘버
//public class Program
//{
//    // 생성자 n

//    // 함수 d(n)
//    static int Creater(string num)
//    {
//        // 받은 숫자를 결과에 저장
//        int result = int.Parse(num);
//        for(int i=0; i<num.Length; i++) 
//        {
//            // 추가적으로 숫자의 각 자리수를 더함
//            result += int.Parse(num[i].ToString());
//        }
//        return result;
//    }

//    // 수열에서 n이 없는 셀프넘버 찾아내기
//    // 함수에 대입했을 떄 없는 숫자 찾아내기
//    // 여기서는 10000개까지로 지정

//    static void Main(string[] args)
//    {
//        // 1부터 10000까지 받아서
//        int[] value = new int[10000];
//        // 하나씩 다 함수넣어보기
//        for(int i=0; i< 10000; i++)
//        {
//            value[i] = Creater(i.ToString());
//        }

//        // 비교를 위해 값을 받을 StringBuilder
//        StringBuilder sb = new StringBuilder();

//        // 1-10000과 아까 넣었던 value 비교하기
//        // 같으면 bool을 통해 확인
//        bool selfnum = true;

//        // 10000과
//        for(int i =0; i<= 10000;i++)
//        {
//            // 구해진 값을 비교
//            for(int j =0; j<value.Length; j++)
//            {
//                // 만약 숫자가 같으면 = 생성자가 있으면
//                if (i == value[j])
//                {
//                    // 셀프넘버 아님
//                    selfnum= false;
//                    break;
//                }
//                else // 생성자가 없으면
//                {
//                    // 셀프넘버
//                    selfnum= true;
//                }

//            }
//            if (selfnum) // 셀프넘버라면
//            {
//                sb.AppendLine(i.ToString()); // 뒤에 계속 문자열 추가하기
//            }
//        }
//        Console.WriteLine(sb);

//    }

//}
//-------------------------------
// ToString(): 값이나 정보를 문자열로 리턴하는 메소드
// StringBuilder(): 변경가능한 문자열, 새로운 StringBuilder 인스턴스 초기화
// AppendLine(): 새로운 문자열을 뒤에 추가, 자동 줄바꿈

// 1065. 한수
public class Program
{
    static void Main(string[] args)
    {
        // 한수: 


        // 첫쨰줄에 자연수 N
        int n = int.Parse(Console.ReadLine());
        // 1 <= 한수 >= N / 한수의 개수 출력
    }
}

