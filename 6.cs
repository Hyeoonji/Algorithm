﻿namespace Baekjoon;

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

// 1157. 단어 공부 -----------------------------------------
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
//        for (int i = 0; i < countNum.Length; i++)
//        {
//            if (Max < countNum[i])
//            {
//                Max = countNum[i];
//            }
//        }

//        // 많이 사용된 알파벳이 여러개인지 확인
//        bool isSame = false;
//        for (int i = 0; i < countNum.Length; i++)
//        {
//            for (int j = 0; j < countNum.Length; j++)
//            {
//                if (countNum[i] == Max && countNum[i] == countNum[j] && i != j)
//                {
//                    isSame = true;

//                }
//            }
//        }

//        int index = Array.IndexOf(countNum, Max);
//        if (upper != null)
//        {
//            if (isSame)
//            {
//                Console.WriteLine("?");
//            }
//            else
//            {
//                // 가장 많이 사용된 알파벳을 대문자로 출력
//                Console.WriteLine(alphabet[index]);
//            }
//        }

//    }
//}

// 1157. 단어 공부 --  재호.ver
//public class Program
//{
//    static void Main(string[] args)
//    {
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

//        // CountNum의 위치를 나타낼 카운트
//        int count = 0;

//        // 입력값을 대문자로 변환해준다.
//        string input = Console.ReadLine().ToUpper();

//        // 입력값 길이만큼 반복
//        for (int j = 0; j < input.Length; j++)
//        {
//            // a ~ z 까지 비교
//            for (char i = 'A'; i <= 'Z'; i++)
//            {
//                // 만약 입력값[j]번째의 값이 i번째와 같을 경우
//                if (input[j] == i)
//                {
//                    // countNum의 count위치의 크기를 1증가
//                    countNum[count]++;
//                }
//                // 위치를 증가
//                count++;
//            }
//            count = 0;
//        }

//        // 가장 많이 나온 값 구하기
//        int MaxCount = 0;
//        foreach (var num in countNum)
//        {
//            if (num != 0)
//            {
//                if (MaxCount < num)
//                {
//                    MaxCount = num;
//                }
//            }
//        }

//        // 중복되었는지 체크할 로직
//        bool isOverlap = false;
//        for (int i = 0; i < countNum.Length; i++)
//        {
//            for (int j = 0; j < countNum.Length; j++)
//            {
//                // countNum의 값과 MaxCount값이 같고 
//                // countNum의 값중에 중복돼 있고
//                // cnumtNum의 기준값이 자기 자신이 아닐때
//                if (countNum[i] == MaxCount && countNum[i] == countNum[j] && i != j)
//                {
//                    // 그 값은 중복되 있다.
//                    isOverlap = true;
//                }
//            }
//        }

//        int index = Array.IndexOf(countNum, MaxCount);
//        if (input != null)
//        {
//            if (isOverlap) // 중복 있을 경우
//                Console.WriteLine('?');
//            else // 안되있을 경우
//                Console.WriteLine(alphabet[index]);
//        }

//    }
//}

// 1152. 단어의 개수
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 영어 대소문자와 공백으로 이루어진 문자열
//        // 앞 뒤 공백 제거
//        string str = Console.ReadLine().Trim();
//        string[] arr = str.Split();

//        int count = 0;
//        // 만약 사이에 공백이 있다면, count +1
//        for(int i =0; i<arr.Length; i++)
//        {
//            if (string.IsNullOrEmpty(arr[i]))
//            {
//                count++;
//            }
//        }

//        Console.WriteLine(arr.Length - count);
//    }
//}
// string.IsNullOrEmpty : 공백이거나 널인지 확인

// 2908. 상수
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 첫째 줄에 두 수 A B
//        string[] num = Console.ReadLine().Split();
//        int numA = int.Parse(num[0]);
//        int numB = int.Parse(num[1]);

//        // 일의 자리 *100 + 십의 자리 + 백의 자리
//        int reA = (numA % 10 * 100) + (numA/10 - (numA/100)*10)*10 + (numA / 100);
//        int reB = (numB % 10 * 100) + (numB/10 - (numB/100)*10)*10 + (numB / 100);

//        if (reA > reB)
//        {
//            Console.WriteLine(reA);
//        }
//        else
//        {
//            Console.WriteLine(reB);
//        }
//    }
//}

// 5622. 다이얼
public class Program
{
    static void Main(string[] args)
    {
        // 첫째 줄에 대문자로 이루어진 단어
        string word = Console.ReadLine();

        int[] asword = new int[word.Length];
        // 단어를 아스키코드로 변환
        for (int i = 0; i < word.Length; i++)
        {
            asword[i] = Convert.ToInt32(word[i]);
        }

        int time = 0;
        int total = 0;

        // ABC(67) 2 / DEF(70) 3 / GHI(73) 4 / JKL(76) 5 / MNO(79) 6 / PQRS(83) 7 / TUV(86) 8 / WXYZ(90) 9
        // 다이얼 돌리는 데 걸리는 시간 = 숫자 *2
        // 각 문자에 걸리는 시간을 구함

        for (int i = 0; i < asword.Length; i++)
        {
            if (asword[i] <= 67)
            {
                time = 2+1;
                total += time;
            }
            else if (asword[i] <= 70)
            {
                time = 3+1;
                total += time;
            }
            else if (asword[i] <= 73)
            {
                time = 4+1;
                total += time;
            }
            else if (asword[i] <= 76)
            {
                time = 5+1;
                total += time;
            }
            else if (asword[i] <= 79)
            {
                time = 6+1;
                total += time;
            }
            else if (asword[i] <= 83)
            {
                time = 7+1;
                total += time;
            }
            else if (asword[i] <= 86)
            {
                time = 8+1;
                total += time;
            }
            else
            {
                time = 9+1;
                total += time;
            }

        }

        Console.WriteLine(total);
    }
}

// 11718. 그대로 출력하기
//public class Program
//{
//    static void Main(string[] args)
//    {

//    }
//}
