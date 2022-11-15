using AssemblyLib;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyLoader asseblyLoader = new AssemblyLoader();
            var ass = asseblyLoader.LoadAssembly("dwdw");
            Console.WriteLine("Hello World!");
        }
    }
}
