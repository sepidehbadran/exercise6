// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num");
            int first =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second num");
            int second =int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= second; i++)
            {
                sum *= first;
                {
                    Console.WriteLine(sum.ToString());
                }
               
            }
        }
    }
}