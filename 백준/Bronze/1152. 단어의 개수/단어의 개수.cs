public class Program
{
    static void Main(string[] args)
    {
        // 영어 대소문자와 공백으로 이루어진 문자열
        // 앞 뒤 공백 제거
        string str = Console.ReadLine().Trim();
        string[] arr = str.Split();

        int count = 0;
        // 만약 사이에 공백이 있다면, count +1
        for(int i =0; i<arr.Length; i++)
        {
            if (string.IsNullOrEmpty(arr[i]))
            {
                count++;
            }
        }

        Console.WriteLine(arr.Length - count);
    }
}