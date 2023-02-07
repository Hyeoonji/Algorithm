namespace Baekjoon;

// 10807. 개수 세기
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        int[] m = new int[n];
//        string[] str = Console.ReadLine().Split();
//        int v = int.Parse(Console.ReadLine());
//        int count = 0;

//        for (int i = 0; i < str.Length; i++)
//        {
//            m[i] = int.Parse(str[i]);
//            if (m[i] == v)
//            {
//                count++;
//            }
//        }
//        Console.WriteLine(count);
//    }
//}

// 10871. X보다 작은 수
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 첫째 줄에 N과 X가 주어진다
//        string[] str = Console.ReadLine().Split();

//        //둘째 줄에 수열 A를 이루는 정수 N개가 주어진다
//        string[] a = Console.ReadLine().Split();

//        for (int i = 0; i < int.Parse(str[0]); i++)
//        {
//            // x보다 작으면
//            if (int.Parse(a[i]) < int.Parse(str[1]))
//            {
//                // 작은 수를 순서대로 출력, 사이는 공백처리
//                Console.Write(a[i] + " ");
//            }
//        }
//    }
//}

// 10818. 최소,최대
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 정수의 개수 N
//        int n = int.Parse(Console.ReadLine());
//        // 최대 최소
//        int max = int.MinValue;
//        int min = int.MaxValue;
//        // N개의 정수를 공백으로 주어짐
//        string[] str = Console.ReadLine().Split();
//        // 정수 배열
//        int[] s = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            s[i] = int.Parse(str[i]);
//        }

//        for (int i = 0; i < n; i++)
//        {
//            if (s[i] > max)
//            {
//                max = s[i];
//            }
//            if (s[i] < min)
//            {
//                min = s[i];
//            }
//        }
//        Console.WriteLine("{0} {1}", min, max);
//    }
//}
//-----------------------------
// Array.ConvertAll
// ConvertAll은 전달인자(argument)로 사용되는 배열형(ArrayType) 입력하고, 전달인자로 변환하고자 하는 배열(Array)와 형변환 함수 "Convert."를 입력

// 2562.  최댓값
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 자연수 9개를 받음
//        int[] num = new int[9];
//        int max =0; //최댓값
//        int count =0; // 순서

//        for (int i = 0; i < 9; i++)
//        {
//            num[i] = int.Parse(Console.ReadLine());
//            // 만약 max가 num 보다 작다면
//            if(max < num[i])
//            {
//                max = num[i]; // 그 숫자가 최대값
//                count = i + 1; // 순서는 +1
//            }
//        }
//        Console.WriteLine(max);
//        Console.WriteLine(count);
//    }

//}

// 5597. 과제 안 내신 분,,?
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int[] num = new int[30]; //30개 -> 받는건 28이지만 30까지

//        for (int i = 0; i < 28; i++)
//        {
//            int n = int.Parse(Console.ReadLine()); // 번호에 숫자를 받음
//            // num[n] = 1; 숫자를 받으면 1로 표시 --> 에러발생
//            // -> 받는건 1부터 시작하는데 0부터 저장하려고 해서 n-1로 수정
//            num[n-1] = 1;
//        }
//        for (int i = 0; i < 30; i++)
//        {
//            if (num[i] != 1)  // 1~30중에 1이 안들어 있는 번호
//            {
//                //Console.WriteLine(i); -1 되어있는 상태이기 때문에 +1 해줌
//                Console.WriteLine(i+1); // 번호 출력
//            }
//        }
//    }
//}

// 3052. 나머지
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int[] num = new int[10]; // 숫자 10개
//        for (int i = 0; i < num.Length; i++)
//        {
//            // 42의 나머지를 저장
//            num[i] = int.Parse(Console.ReadLine()) % 42;
//        }

//        Console.WriteLine(num.Distinct().Count());
//    }
//}
//-----------------------------
// Distinct(): 중복 값을 제거

// 1546. 평균
//public class Program
//{
//    static void Main(string[] args)
//    {
//        //개수 받기
//        int count = int.Parse(Console.ReadLine());
//        string[] num = Console.ReadLine().Split();
//        float[] score = Array.ConvertAll(num, float.Parse);
//        float max = score.Max(); // 최대값
//        float sum=0; // 더해줄 값
//        for (int i =0; i < num.Length; i++)
//        {
//            // 배열에 점수/최대값*100
//            score[i] = score[i]/ max * 100;
//            sum += score[i];
//        }

//        // 새로운 평균 구하기
//        double average = sum / count;
//        Console.WriteLine(average);
//    }
//}

// 8958. OX퀴즈
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 케이스의 개수
//        int num = int.Parse(Console.ReadLine());
//        // 케이스를 받을 배열
//        string[] str = new string[num];
//        // 점수를 받을 배열
//        int[] arr = new int[num];

//        for (int i = 0; i < str.Length; i++)
//        {
//            str[i] = Console.ReadLine();

//            // 케이스 별 점수
//            int score = 0;
//            // 연속일 때 추가 점수
//            int count = 1;

//            // 받은 케이스의 길이만큼
//            for (int j = 0; j < str[i].Length; j++)
//            {
//                // 케이스속 결과 1개씩 확인
//                if (str[i][j] == 'O')
//                {
//                    score += count;
//                    // 연속될때마다 추가점수를 +1해서 더하기
//                    count++;
//                }
//                if (str[i][j] == 'X')
//                {
//                    count = 1;
//                }
//            }
//            arr[i] = score;
//        }
//        foreach(int i in arr)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

//-----------------------
// foreach 끝까지 알아서 순환하는 반복문
// foreach(데이터타입 변수명 in 배열,컬렉션등)

// 4344. 평균은 넘겠지
//public class Program
//{
//    static void Main(string[] args)
//    {
//        // 첫째줄에는 테스트 케이스의 개수 C
//        int tcase = int.Parse(Console.ReadLine());

//        // 테스크 케이스마다 학생의 수 N + N명의 점수
//        for (int i = 0; i < tcase; i++)
//        {
//            string[] str = Console.ReadLine().Split(' ');
//            // 학생의 수 N
//            int num = int.Parse(str[0]);
//            // 첫번째 학생의 수를 제외한 나머지 점수
//            int[] score = new int[num+ 1];
//            float sum = 0; // 합계
//            float ave = 0; // 평균

//            for (int j = 0; j < num+1; j++)
//            {
//                // 점수에 연결, 합계 구하기
//                score[j] = int.Parse(str[j]);
//                if(j >= 1)
//                {
//                    sum += score[j];
//                }

//            }
//            ave = sum / (float)num;

//            // 평균이 넘는 학생의 수
//            float count = 0;
//            for (int j = 0; j < num+1; j++)
//            {
//                // 점수가 평균보타 크다면
//                if (j >= 1 && score[j] > ave)
//                {
//                    count++;
//                }
//            }

//            float result = count / (float)num;
//            // 각 케이스마다 평균이 넘는 학생의 비율을 출력 소수 셋째자리까지 반올림
//            Console.WriteLine("{0:#0.000%}", result);
//        }
//    }
//}