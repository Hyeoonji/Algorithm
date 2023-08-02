using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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

/* // 점프와 순간이동
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
}*/

/*// N개의 최소공배수
// 유클리드 호제법: 2개의 자연수 a, b(a > b)에 대해서 a를 b로 나눈 나머지가 r일 때, a와 b의 최대공약수는 b와 r의 최대공약수와 같다.
// 1. GCD: 나누어 떨어질 때까지 나누어서 최대공약수를 구하기
// 2. LCM: a와 b의 최소공배수는 a와 b의 곱을 a와 b의 최대공약수를 나눈 것과 같다
// 3. 먼저 앞 두 수에 대한 최소 공배수를 구한 뒤 구해진 최소 공배수와 다음 수 1개와 최소 공배수를 구하기
public class Solution
{
    public int GCD(int a, int b)
    {
        //원래 GCD를 구할때 a>b 라는 조건이 필요한데, LCM을 구하면서 a의 값이 커질 수 있기 때문에 적용 X
        while (b != 0)
        {
            int gcd = a % b;
            a = b;
            b = gcd;
        }
        return a;
    }

    public int LCM(int a, int b)
    {
        int lcm = (a * b) / GCD(a, b);
        return lcm;
    }

    public int solution(int[] arr)
    {
        int answer = LCM(arr[0], arr[1]);
        for (int i = 2; i < arr.Length; i++)
        {
            answer = LCM(answer, arr[i]);
        }
        return answer;
    }
}*/

/*// 멀리 뛰기
public class Solution
{
    //피보나치 수열 활용
    long fibo = 1;
    long num = 1;
    public long solution(int n)
    {
        long answer = 0;
        if(n == 0 || n == 1)
        {
            answer = 1;
        }
        else
        {
            for(int i = 2; i <= n; i++)
            {
                answer = (fibo + num) % 1234567;
                fibo = num;
                num = answer;
            }
        }

        return answer;
    }
}*/

/*// 귤 고르기
public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        int answer = 0;
        Array.Sort(tangerine);                      //오름차순 정렬
        List<int> count = new List<int>();
        int compare = tangerine[0];                 
        int num = 1;

        for (int i = 1; i < tangerine.Length; i++)
        {
            if (compare != tangerine[i])            // 1==2 ? 
            {
                count.Add(num);                     //{1,2,2,1,2}
                compare = tangerine[i];
                num = 1;
            } else            
            {
                num++;
            }
        }

        count.Add(num);                             //마지막 숫자를 답아야 함
        count.Sort();                               //오름차순
        count.Reverse();                            //내림차순

        foreach (int i in count)
        {
            if (k < i)
            {
                answer++;
                break;
            }
            else if (k >= i)
            {
                k -= i;
                answer++;
                if (k <= 0) break;
            }
        }

        return answer;
    }
}*/

/* // 괄호 회전하기 --------------------------------------------------------------------
public class Solution
{

    //올바른 괄호 공식 활용
    public bool Bracket(string str, char cha)
    {
        bool correct = false;
        char[] chars = str.ToCharArray();
        int countFront = 0;
        int countBack = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[0] == ')')
            {
                correct = false;
                return correct;
            }
            else if (chars[chars.Length - 1] == cha)
            {
                correct = false;
                return correct;
            }
            else
            {
                if (chars[i] == cha) countFront++;
                else countBack++;

                if (countFront < countBack)
                {
                    correct = false;
                    return correct;
                }

            }
        }

        if (countFront != countBack)
        {
            correct = false;
        }

        return correct;

    }
    public int solution(string s)
    {
        int answer = -1;
        for(int i = 0; i < s.Length; i++)
        {
            
        }

        return answer;
    }
}*/

/*// 연속 부분 수열 합의 개수
public class Solution
{

    public int Partial(int[] ele, int start, int len)  //부분합을 구하는 식
    {
        int sum = 0;
        for (int i = start; i < start + len; i++)
        {
            sum += ele[i];
        }
        return sum;
    }

    // 연속값을 어떻게 처리할 것인가
    // -> 길이가 작아진다면 앞에서 추가할 수 있도록 해야 함
    // ->> 그러면 길이에 따라 더하는 방식으로 가야 할 듯

    public int solution(int[] elements)
    {
        int answer = 0;
        int[] ele = new int[elements.Length * 2];
        //List<int> result = new List<int>();
        HashSet<int> numset = new HashSet<int>();

        for (int i = 0; i < elements.Length; i++)            //길이가 2배인 배열 준비
        {
            ele[i] = elements[i];
            ele[i + elements.Length] = elements[i];
        }

        int count = elements.Length;

        for (int i = 0; i < elements.Length; i++)
        {
            if (count == 0)
            {
                break;
            }
            for (int j = 0; j < elements.Length; j++)
            {
                //기존의 코드
                //result.Add(Partial(ele, j, count));
                //result = result.Distinct().ToList();      //계속 중복을 확인하는 과정에서 시간 초과
                numset.Add(Partial(ele, j, count));

            }
            count--;
        }

        answer = numset.Count;

        return answer;
    }
}
//-------------------------------------
// HashSet: 중복되지 않은 값들이 존재하는 데이터 집합
// 이를 이용해 중복값을 확인하는 시간 단축
*/

/*// H-Index
public class Solution
{
    public int solution(int[] citations)
    {
        //h번 이상 인용된 논문이 h개 이상, 나머지가 h번 이하
        int answer = 0;
        int index = citations.Max();      //배열의 최댓값을 일단 부여
        
        while (true)
        {
            int count = 0;
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] >= index)
                {
                    count++;
                }
            }

            if (count >= index)         //개수와 값을 비교해서 같으면 (X), 이상(O)
            {
                break;
            }
            else                        //다르면 하나씩 줄여나가기
            {
                index--;
            }
        }

        answer = index;
        return answer;
    }
}*/

/*// 기능개발
public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> result = new List<int>();

        while (true)
        {
            int count = 0;
            for(int i = result.Sum(); i < progresses.Length; i++)       //값이 계속 이어져야 하기 때문에 Sum()으로 시작
            {
                progresses[i] += speeds[i];
            }

            if (progresses[result.Sum()] >= 100)                        //만약 값이 100보다 크면
            {
                for(int i = result.Sum();i < progresses.Length; i++)    //끝까지 돌려서 100 넘는 값 확인
                {
                    if (progresses[i] >= 100)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if(count > 0)                                       //값이 있다면 리스트에 추가
            {
                result.Add(count);
            }

            if(result.Sum() == progresses.Length)               //리스트의 모든 값(=개수)가 길이와 동일해지면 종료
            {
                break;
            }
        }
        
        return result.ToArray();
    }
}*/

/*// 프로세스
// 1. 중요도와 동일한 길이의 배열을 하나 준비
// 2. 가장 큰 우선순위를 구함
// 3. 배열의 같은 위치에 숫자 기입
// 4. 그 다음으로 큰 우선순위 구하기
// 5. 반복
// 6. 원하는 위치의 숫자를 출력
public class Solution
{
    public int findTurn(int[] priorities, int num, int start)  //우선순위의 위치 구하기
    {
        int count = 0;                                      //발견 위치
        for (int i = start; i < priorities.Length; i++)
        {
            if (priorities[i] == num)
            {
                count = i;
                priorities[i] = 0;                          //검출되지 않도록 0으로 변경
                break;
            }
        }

        if (count == 0)                                      //count가 0 -> 우선순위와 동일한게 없음
        {
            for (int i = 0; i < start; i++)                 //앞에부터 구하기
            {
                if (priorities[i] == num)
                {
                    count = i;
                    priorities[i] = 0;
                    break;
                }
            }
        }

        return count;                                       //위치를 출력
    }

    public int solution(int[] priorities, int location)
    {
        int[] sequence = new int[priorities.Length];        

        int max = priorities.Max();
        int start = 0;
        int turn = 1;

        for (int i = 0; i < priorities.Length; i++)
        {
            int count = findTurn(priorities, max, start);   //같은 값이 또 있는지 확인, 없으면 그 다음으로 큰 수

            if (priorities.Contains(max) == false)
            {
                max = priorities.Max();
            }
            sequence[count] = turn;
            start = count;
            turn++;
        }
        
        int answer = sequence[location];
        return answer;
    }
}*/

/*// 피로도---------------------------반례가 존재해서 중단, 다른 풀이 방식은 아래에
// [최소 필요 피로도, 소모 피로도]
// 던전 하나당 1일 1회 가능
// 순서에 관계없이 유저가 탐험 가능한 최대 던전 수 구하기
// 반례 k = 40 , [[40, 20], [10, 10], [10, 10], [10, 10], [10, 10]] , answer = 4
// -> 꼭 차이가 큰 것을 우선시하는 건 맞지 않다는 증거: [10,10] 4개가 더 좋음
public class Solution
{
    public int solution(int k, int[,] dungeons)
    {
        int length = dungeons.GetLength(0);     //2개는 일정하니 column의 길이를 구함
        int[] need = new int[length];           //최소 필요
        int[] waste = new int[length];          //소모
        int[] gap = new int[length];            //차이

        for (int i = 0; i < length; i++)        // 2차원 배열 각각 분리하기
        {
            need[i] = dungeons[i, 0];
            waste[i] = dungeons[i, 1];
            gap[i] = need[i] - waste[i];        //최소 - 소모: 차이가 클수록 초기 필요값이 상대적으로 많이 필요한 것이니까 이를 활용
        }

        int order = 0;                          //탐험 순서
        int count = 0;                          //탐험 횟수

        while (true)                           
        {
            int gapMax = gap.Max();             //차이가 가장 큰 던전 구하기
            if( gapMax < -5) break;
            if (k < 0) break;

            for (int i = 0; i < length; i++)    //최댓값의 위치를 기억
            {
                if (gap[i] == gapMax)
                {
                    order = i;                  
                    gap[i] = -10;
                    break;
                }
            }

            if (k >= need[order])               
            {                                   
                k -= waste[order];              
                need[order] = 0;
                count++;                        
            }
            else continue;
        }

        int answer = count;
        return answer;
    }
}*/

// 피로도
// DFS(Depth First Search) 사용: 방문 여부를 확인하여 경우의 수를 모두 탐색
public class Solution
{
    public bool[] visited;                      //방문여부                      
    public int answer = 0;

    public int solution(int k, int[,] dungeons)
    {
        //int answer = -1;
        visited = new bool[dungeons.Length];
        DFS(k,dungeons,visited,0);

        return answer;
    }

    public int DFS(int k, int[,] dungeons, bool[] visited, int count)
    {
        int length = dungeons.GetLength(0);     //경우의 수
        //1번부터 시작하여 모든 경우의 수를 다 돌아보는 방식. 이후 최대값을 찾는다
        for(int i = 0; i < length; i++)
        {
            //dungeons[i, 0]: 최소 필요
            if (k >= dungeons[i,0] && !visited[i])
            {
                visited[i] = true;

                //dungeons[i, 1]: 소모
                DFS(k - dungeons[i, 1], dungeons, visited, count + 1);
                visited[i] = false;             //하나의 경우를 돌고난 후 새로운 시작을 위해 다시 false
            }
        }

        answer = Math.Max(count,answer);        //돌때마다 최대값을 비교해서 넣기
        return answer;
    }
}
