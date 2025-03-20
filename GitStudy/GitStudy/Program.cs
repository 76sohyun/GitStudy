namespace GitStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력해주세요 : ");
            string input = Console.ReadLine();
            Console.Write("좋아하는 음식을 입력해주세요 : ");
            string food = Console.ReadLine();
            Console.WriteLine($"이름은 {input}이고 좋아하는 음식은 {food}살 입니다.");

        }
    }
}
