public class Program
{
    static void Main(string[] args)
    {
        //개수 받기
        int count = int.Parse(Console.ReadLine());
        string[] num = Console.ReadLine().Split();
        float[] score = Array.ConvertAll(num, float.Parse);
        float max = score.Max(); // 최대값
        float sum=0; // 더해줄 값
        for (int i =0; i < num.Length; i++)
        {
            // 배열에 점수/최대값*100
            score[i] = score[i]/ max * 100;
            sum += score[i];
        }

        double average = sum / count;
        Console.WriteLine(/*"{0:#0.00####}",*/ average);
    }
}