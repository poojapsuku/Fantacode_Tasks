// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\nThe Current Day is : " + DateTime.Now.ToString("dddd"));
            Console.WriteLine("The Current Month is : "+DateTime.Now.ToString("MMMM"));

        }
    }
}