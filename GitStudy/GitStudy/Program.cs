namespace GitStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력해주세요 : ");
            string input = Console.ReadLine();
            Console.Write("나이를 입력해주세요 : ");
            string age = Console.ReadLine();
            Console.WriteLine($"이름은 {input}이고 나이는 {age}살 입니다.");

        }
    }
}
