using AssemblyLib;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyLoader asseblyLoader = new AssemblyLoader();
            asseblyLoader.LoadAssembly();
            Console.WriteLine("Hello World!");
        }
    }
}
