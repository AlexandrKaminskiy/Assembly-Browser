using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyLib
{
    public class AssemblyInfo
    {
        public string Name { get; set; }
        public List<TypeInfo> Types { get; set; }

        public AssemblyInfo()
        {
            Types = new List<TypeInfo>();
        }
    }
}
