public class Program
{
    static void Main(string[] args)
    {
        // 알파벳의 위치 표시할 나타낼 배열
        int[] countNum =
        {
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };
        // 알파벳 배열
        char[] alphabet =
        {
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q',
            'R','S','T','U','V','W','X','Y','Z'
        };

        // CountNum의 위치를 나타낼 카운트
        int count = 0;

        // 입력값을 대문자로 변환해준다.
        string input = Console.ReadLine().ToUpper();

        // 입력값 길이만큼 반복
        for (int j = 0; j < input.Length; j++)
        {
            // a ~ z 까지 비교
            for (char i = 'A'; i <= 'Z'; i++)
            {
                // 만약 입력값[j]번째의 값이 i번째와 같을 경우
                if (input[j] == i)
                {
                    // countNum의 count위치의 크기를 1증가
                    countNum[count]++;
                }
                // 위치를 증가
                count++;
            }
            count = 0;
        }

        // 가장 많이 나온 값 구하기
        int MaxCount = 0;
        foreach (var num in countNum)
        {
            if (num != 0)
            {
                if (MaxCount < num)
                {
                    MaxCount = num;
                }
            }
        }

        // 중복되었는지 체크할 로직
        bool isOverlap = false;
        for (int i = 0; i < countNum.Length; i++)
        {
            for (int j = 0; j < countNum.Length; j++)
            {
                // countNum의 값과 MaxCount값이 같고 
                // countNum의 값중에 중복돼 있고
                // cnumtNum의 기준값이 자기 자신이 아닐때
                if (countNum[i] == MaxCount && countNum[i] == countNum[j] && i != j)
                {
                    // 그 값은 중복되 있다.
                    isOverlap = true;
                }
            }
        }

        int index = Array.IndexOf(countNum, MaxCount);
        if (input != null)
        {
            if (isOverlap) // 중복 있을 경우
                Console.WriteLine('?');
            else // 안되있을 경우
                Console.WriteLine(alphabet[index]);
        }

    }
}