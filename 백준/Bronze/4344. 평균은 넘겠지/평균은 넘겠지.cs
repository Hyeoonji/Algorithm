public class Program
{
    static void Main(string[] args)
    {
        // 첫째줄에는 테스트 케이스의 개수 C
        int tcase = int.Parse(Console.ReadLine());

        // 테스크 케이스마다 학생의 수 N + N명의 점수
        for (int i = 0; i < tcase; i++)
        {
            string[] str = Console.ReadLine().Split(' ');
            // 학생의 수 N
            int num = int.Parse(str[0]);
            // 첫번째 학생의 수를 제외한 나머지 점수
            int[] score = new int[num+ 1];
            float sum = 0; // 합계
            float ave = 0; // 평균

            for (int j = 0; j < num+1; j++)
            {
                // 점수에 연결, 합계 구하기
                score[j] = int.Parse(str[j]);
                if(j >= 1)
                {
                    sum += score[j];
                }

            }
            ave = sum / (float)num;

            // 평균이 넘는 학생의 수
            float count = 0;
            for (int j = 0; j < num+1; j++)
            {
                // 점수가 평균보타 크다면
                if (j >= 1 && score[j] > ave)
                {
                    count++;
                }
            }

            float result = count / (float)num;
            // 각 케이스마다 평균이 넘는 학생의 비율을 출력 소수 셋째자리까지 반올림

            Console.WriteLine("{0:#0.000%}", result);
        }
    }
}