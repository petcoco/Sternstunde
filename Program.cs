using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length==0)
            {
<<<<<<< HEAD
                System.Console.WriteLine("Helloworld 이름");
                System.Console.WriteLine("이렇게 치는거야");
                System.Console.WriteLine("알겠니?");
=======
                System.Console.WriteLine("이렇게 입력하세요 : Helloworld 이름");
		System.Console.WriteLine("HAHAHAHAHA"); //이 코드는 remote에서 수정하였음.
>>>>>>> 36485f5d70e8471694840d5791778c15428f54f7
                System.Console.ReadKey();
                return;
            }
            System.Console.WriteLine("Hello! Nice to meet you!! {0}!",args[0]);
            System.Console.ReadKey();

        }
    }
}
