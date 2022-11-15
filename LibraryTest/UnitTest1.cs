using System;
using System.IO;
using Xunit;

namespace LibraryTest
{
    public class UnitTest1
    {
        AssemblyLib.AssemblyLoader assemblyLoader;


        public UnitTest1()
        {
            assemblyLoader = new AssemblyLib.AssemblyLoader();
        }
        [Fact]
        public void HelpMethTest()
        {
            Assert.Throws<FileNotFoundException>(()=>assemblyLoader.LoadAssembly("ewygfbwe"));
        }
        
        [Fact]
        public void LoadLib()
        {
            assemblyLoader.LoadAssembly("C:\\Users\\Саша\\OneDrive\\Рабочий стол\\вся учеба\\учеба 5\\спп\\AssemblyBrowser\\BrowserDemo\\AssemblyLib\\bin\\Debug\\netcoreapp3.1\\AssemblyLib.dll");
            Assert.True(true);
        }
    }
}
