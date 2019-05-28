using System;
using System.Linq.Expressions;

namespace vscode_dotnet_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test((a, b) => "11");
        }

        private static void Test(Expression<Func<string, string, string>> ex)
        {
            //....
        }
    }
}
