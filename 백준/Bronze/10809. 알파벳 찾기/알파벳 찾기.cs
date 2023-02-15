public class Program
{
    static void Main(string[] args)
    {
        // 첫째 줄에 단어 S
        string word = Console.ReadLine();
        // 알파벳의 위치를 표현
        // 아스키코드를 활용: 소문자 a-z = 97- 122
        for(int i =97 ; i<=122 ; i++)
        {
            // 기본값 -1
            int result = -1;
            for (int j = 0; j < word.Length; j++)
            {
                //97부터 같은지 확인
                if(i == word[j])
                {
                    // 같으면 자릿수 반환
                    result = j;
                    break;
                }


            }
            // 공백으로 구분해서 출력
            Console.Write(result + " ");
        }
    }
}