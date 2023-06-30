using System;
using System.Collections;
using System.Collections.Generic;

namespace Programmers;

/*// 최댓값과 최솟값
public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        // 최대 최소
        int max = int.MinValue;
        int min = int.MaxValue;

        // 문자열 자르기
        string[] str = s.Split(' ');
        // 정수배열
        int[] num = new int[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            num[i] = int.Parse(str[i]);
        }


        for (int j = 0; j < num.Length; j++)
        {
            if (num[j] > max)
            {
                max = num[j];
            }
            if (num[j] < min)
            {
                min = num[j];
            }
        }

        answer = $"{min} {max}";
        return answer;
    }
}*/

/*// 행렬의 곱셈
public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        // 행(0), 열(1)
        int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

        // 밑으로 증가 a -> c
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            // 앞 행렬 증가 a -> b
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                //뒤 행렬 증가 x1 -> y1
                for (int k = 0; k < arr2.GetLength(1); k++)
                {
                    answer[i, k] += arr1[i, j] * arr2[j, k];
                }
            }
        }
        return answer;
    }
}
---------------------------------------------------
행렬의 곱셈 -> 덧셈으로 변환하기
    - 곱셈
(a, b) + (x1, y1)  --> (a x1 + b x2 , a y1 + b y2)
(c, d) + (x2, y2)  --> (c x1 + d x2 , c y1 + d y2)
-> 이대로 풀 경우, a -> b 옆으로 증가, x1 -> x2 밑으로 증가 =>> 꼬이게 됨
    -> 덧셈으로 변환해서 풀이 ([a,b] + [x,y] = [a+x, b+y]를 활용)
(a x1 + b x2 , a y1 + b y2) 를 [a x1, ay1] + [b x1, b y2] 로 변경 가능 
-> 이렇게 되면 둘다 옆으로 증가
*/

/*// 피보나치 수
public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int[] fibo = new int[n + 1];
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < n + 1; i++)
        {
            fibo[i] = (fibo[i - 2] + fibo[i - 1]) % 1234567;
            // 왜 안에서 나눠야 하는가? -> 밖에서 나눌 경우, 숫자가 크면 int, long으로도 커버가 되지 않기 떄문
        }
        // [2] = 0 + 1 = 1
        // [3] = 1 + 1 = 2
        // [4] = 1 + 2 = 3
        // [5] = 2 + 3 = 5
        // [6] = 3 + 5 = 8

        answer = fibo[n];
        return answer;
    }
}*/

/*// 예상 대진표
class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 1;

        // a와 b가 만날때까지 진행, 단, a,b 중 뭐가 더 큰지는 알 수 없음
        // -> 짝수일때는 a의 앞, 홀수일때는 뒤에 b가 있다면 경기한다는 것
        while (!((a % 2 == 0 && a - 1 == b) || (a % 2 == 1 && a + 1 == b)))
        {

            if (a % 2 == 0) // a가 짝수면 -> 4/2 = 2 번째 경기
            {
                a = a / 2;
            }
            else // a가 홀수면 -> (3+1)/2 = 2 번째 경기 / (7+1)/2 = 4번째 경기
            {
                a = (a + 1) / 2;
            }
            // b도 동일
            if (b % 2 == 0)
            {
                b = b / 2;
            }
            else
            {
                b = (b + 1) / 2;
            }
            answer++;
        }
        return answer;
    }
}*/

/*// JadenCase 문자열 만들기
public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        s = s.ToLower();                      //전체를 소문자화: unFollowed -> Unfollowed
        char[] cha = s.ToCharArray();

        for (int i = 0; i < cha.Length; i++)
        {
            cha[0] = char.ToUpper(cha[0]);      //첫 알파벳 대문자로 바꾸기
            //단어의 첫 글자 조건: 앞에 빈칸이 있을때 
            if (cha[i] == ' ' && i + 1 < cha.Length)
            {
                cha[i + 1] = char.ToUpper(cha[i + 1]);
            }
        }

        for (int i = 0; i < cha.Length; i++)
        {
            answer += cha[i];
        }

        return answer;
    }
}*/

/*// 최솟값 만들기
public class Solution
{
    //최솟값을 구하는 방법
    //가장 큰 수는 가장 작은 수와 곱하는 방식
    //배열을 한개는 오름차순, 한개는 내림차순으로 정렬
    //순서대로 곱하기
    public int solution(int[] A, int[] B)
    {
        int answer = 0;
        Array.Sort(A);          //오름차순 정렬
        Array.Sort(B);          //오름차순 정렬 후 
        Array.Reverse(B);       //내림차순 정렬

        for (int i = 0; i < A.Length; i++)
        {
            answer += (A[i] * B[i]);
        }

        return answer;
    }
}*/

/*// 올바른 괄호
public class Solution
{
    public bool solution(string s)
    {
        bool answer = true;
        char[] chars = s.ToCharArray();
        int countFront = 0;
        int countBack = 0;


        // ()로 이루어진다는 것 = ( 와 ) 의 개수가 같아야 함
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[0] == ')')
            {
                answer = false;
                return answer;
            }
            else if (chars[chars.Length - 1] == '(')
            {
                answer = false;
                return answer;
            }
            else
            {
                if (chars[i] == '(') countFront++;
                else countBack++;

                // 순서대로 진행하는 도중에 )가 (보다 많다는 것 => ()()))이런식으로 갯수가 맞지 않는다는 것
                if (countFront < countBack)
                {
                    answer = false;
                    return answer;
                }
                
            }
        }

        if (countFront != countBack)
        {
            answer = false;
        }

        return answer;
    }
}*/

/*// 이진 변환 반복하기
public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[2];
        int count = 0;                              //변환 횟수
        int zerocount = 0;                          //변환 과정에서 제거된 0의 개수
        while (s.Length > 1)
        {
            count++;
            int length = s.Length;
            string str = "";
            for(int i = 0; i < length; i++)         //길이만큼 반복하며 0 찾기
            {
                if (s[i] == '0')
                {
                    zerocount++;
                }
                else
                {
                    str += s[i];
                }
            }
            
            s = Convert.ToString(str.Length, 2);    //길이를 이진법으로 변환해서 다시 넣기
        }

        answer[0] = count;
        answer[1] = zerocount;
        return answer;
    }
}*/

/*// 다음 큰 숫자
public class Solution
{
    //다음 큰 숫자: 2진수일때, 1의 개수가 동일한 숫자 중 가장 작은 수
	//0. 주어진 숫자를 2진수 변환하기
	//1. 2진수에서 가지고있는 1의 개수 저장
	//2. 주어진 숫자를 기준으로 +1 하기
	//3. 숫자를 2진수 변환해서 기존의 1의 개수와 비교하기

    public int solution(int n)
    {
        int answer = 0;
        string num = Convert.ToString(n, 2);                //주어진 수를 2진수로 변환
        int countNum = 0;                                   //주어진 수의 1의 개수
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == '1')
            {
                countNum++;                            
            }
        }

        answer = n;                                         //비교할 수
        while (true)
        {
            answer++;
            int countOne = 0;                               //1의 개수
            string binary = Convert.ToString(answer, 2);
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    countOne++;
                }
            }
            if(countOne == countNum)                        //만약 1의 개수가 같으면 정답
            {
                break;
            }
        }

        return answer;
    }
}*/

/*// 영어 끝말잇기
class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];
        int round = 0;                                  //몇번째인지
        int count = 0;                                  //탈락자 순서
        bool isStop = false;                            //중간에 틀렸는지 체크
        List<string> word_list = new List<string>();    //중복값 확인용 리스트
        word_list.Add(words[0]);

        for (int i = 0; i < words.Length - 1; i++)
        {
            char[] chaBe = words[i].ToCharArray();
            char before = chaBe[chaBe.Length - 1];      //전 단어의 끝 저장
            char[] chaAf = words[i + 1].ToCharArray();
            char after = chaAf[0];                      //다음 단어의 시작 저장
            count++;
            round = (count / n) + 1;

            if (!word_list.Contains(words[i+1]))        //중복단어 체크
            {
                word_list.Add(words[i+1]);              //없으면 추가
            }
            else if(word_list.Contains(words[i+1]))     //있으면 중단
            {
                count = i + 1;
                round = (count / n) + 1;
                isStop = true;
                break;              
            }

            if (before != after)                        //끝말잇기 확인
            {
                isStop = true;
                break;
            }
        }

        if (count == words.Length - 1 && isStop == false)   //끝까지 문제 없으면 [0,0]
        {
            answer[0] = 0;
            answer[1] = 0;
        }
        else
        {
            answer[0] = count % n + 1;
            answer[1] = round;

        }
        
        return answer;
    }
}*/

/*// 카펫
public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[2];
        int row = 0;
        int col = 0;

        // 둘레(2w + 2h -4)와 면적(w*h)의 공식을 통해 가로세로의 합을 구함
        int sum = (brown + 4) / 2;                  //가로와 세로의 합 
        int tile = brown + yellow;                  //면적 

        List<int> div_list = new List<int>();

        for (int i = 1; i <= tile; i++)             //약수를 리스트에 담음
        {
            if (tile % i == 0)
            {
                div_list.Add(i);
            }
        }
        
        foreach(int a in div_list)                  //약수에 대해   
        {
            int b = tile / a;                       
            if(a + b == sum) 
            {
                row = a;
                col = b;
            }
        }

        answer[0] = row;
        answer[1] = col;
        return answer;
    }
}*/

// 점프와 순간이동
// 0->n이 아니라 n -> 0 으로 생각할 것
// n을 2로 나눠서 갈 수 있는가? 갈수있다면 순간이동한 것.
// 아니라면 1칸을 이동한 것 => 에너지 소모
class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int k = 0;
        while(true)
        {
            if(n == 0)
            {
                break;
            }
            if(n%2 != 0)
            {
                n--;
                k++;
            }
            else
            {
                n = n / 2;
            }
        }
        answer = k;
        return answer;
    }
}
