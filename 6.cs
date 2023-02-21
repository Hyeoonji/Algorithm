using System.Text;

namespace Baekjoon;

// 11654. 아스키코드
//public class Program
//{
//    static void Main(string[] args)
//    {
//        //첫째 줄에 숫자 입력받기
//        char num = Convert.ToChar(Console.ReadLine());
//        // 아스키코드로 출력하기
//        int ascii = Convert.ToInt32(num);
//        Console.WriteLine(ascii);
//    }
//}

// 11720. 숫자의 합
//public class Program
//{
//    // 기존의 숫자 합과의 차이점: 공백
//    static void Main(string[] args)
//    {
//        // 첫째줄에 숫자의 개수n
//        int n = int.Parse(Console.ReadLine());
//        // 둘째줄에 숫자가 개수만큼 공백없이 주어짐
//        string str = Console.ReadLine();

//        // 합을 받을 변수
//        int count = 0;
//        // 숫자 n개의 합 출력하기
//        for(int i =0; i < n; i++)
//        {
//            count += int.Parse(str[i].ToString());
//        }
//        Console.WriteLine(count);

//    }
//}

// 10809. 알파벳찾기
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 첫째 줄에 단어 S
//        string word = Console.ReadLine();
//        // 알파벳의 위치를 표현
//        // 아스키코드를 활용: 소문자 a-z = 97- 122
//        for(int i =97 ; i<=122 ; i++)
//        {
//            // 기본값 -1
//            int result = -1;
//            for (int j = 0; j < word.Length; j++)
//            {
//                //97부터 같은지 확인
//                if(i == word[j])
//                {
//                    // 같으면 자릿수 반환
//                    result = j;
//                    break;
//                }
//            }
//            // 공백으로 구분해서 출력
//            Console.Write(result + " ");
//        }
//    }
//}

// 2675. 문자열 반복
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 첫째줄에 테스트 케이스의 개수
//        int test = int.Parse(Console.ReadLine());

//        // 케이스 만큼 반복
//        for(int i =0; i < test; i++)
//        {
//            // 반복 횟수 R + 공백 + 반복할 문자열 S
//            // 테스트할 문자열 받기
//            string[] str = Console.ReadLine().Split();
//            // 반복횟수
//            int r = int.Parse(str[0]);

//            // str의 0은 횟수, 1부터 반복 시작
//            for(int j =0; j < str[1].Length; j++)
//            {
//                // r만큼 반복
//                for(int k = 0; k < r; k++)
//                {
//                    Console.Write(str[1][j]);
//                }
//            }
//            Console.WriteLine();

//        }
//    }
//}

// 1157. 단어 공부
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 첫째줄에 단어
//        string str = Console.ReadLine();
//        // 문자를 다 대문자로 변환
//        string upper = str.ToUpper();

//        // 알파벳의 위치 표시할 나타낼 배열
//        int[] countNum =
//        {
//            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
//        };
//        // 알파벳 배열
//        char[] alphabet =
//        {
//            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q',
//            'R','S','T','U','V','W','X','Y','Z'
//        };

//        int count = 0;
//        // 문자의 길이만큼
//        for (int i = 0; i < str.Length; i++)
//        {
//            // A부터 비교
//            for (char j = 'A'; j <= 'Z'; j++)
//            {
//                //같은지 확인
//                if (str[i] == j)
//                {
//                    // 문자가 추가될때마다 값을 추가 
//                    countNum[count]++;
//                }
//                count++;
//            }
//            count = 0;
//        }

//        // 가장 많은 값을 가진 단어 찾기
//        int Max = 0;
//        char MaxAlpha = 'A';
//        for (int i = 0; i < countNum.Length; i++)
//        {
//            if (Max < countNum[i])
//            {
//                Max = countNum[i];
//                MaxAlpha = alphabet[i];
//            }
//            // 단어가 여러개라면 ? 출력하기 -> 에서 막힘
//            if (Max == countNum[i])
//            {
//                MaxAlpha = '?';
//            }
//        }

//        // 가장 많이 사용된 알파벳을 대문자로 출력
//        Console.WriteLine(MaxAlpha);
//    }
//}
