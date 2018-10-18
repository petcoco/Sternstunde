

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length==0)
            {
                System.Console.WriteLine("Helloworld 이름");
                System.Console.ReadKey();
                return;
            }
            System.Console.WriteLine("Hello {0}!",args[0]);
            System.Console.ReadKey();

        }
    }
}
