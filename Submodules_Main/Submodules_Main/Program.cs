using Submodules_external;

namespace Submodules_Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Class1 t = new() { MyProperty = 1 };
            Console.WriteLine(t.MyProperty);
        }
    }
}