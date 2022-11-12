using System;
using System.Reflection;

namespace AssemblyLib
{
    public class AssemblyLoader
    {
        private readonly string path = "../../../../Assemblies/";
        public string s;
        public string q { get; set; }
        public void LoadAssembly()
        {
            Assembly assembly = Assembly.LoadFrom(path + "AssemblyLib.dll");
            string name = assembly.GetName().Name;
            var types = assembly.GetTypes();
            Console.WriteLine(assembly.GetTypes()[0].Name);
            var meths = assembly.GetTypes()[0].GetMethods();
            var fields = assembly.GetTypes()[0].GetFields();
            var props = assembly.GetTypes()[0].GetProperties();

            foreach (var prop in props)
            {
                string s = propInfo(prop);
                Console.WriteLine(s);
            }

            foreach (var field in fields)
            {
                string s = fieldInfo(field);
                Console.WriteLine(s);
            }

            foreach (var meth in meths)
            {
                string s = methodSignature(meth);
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }

        private string propInfo(PropertyInfo prop)
        {
            return prop.PropertyType + " " + prop.Name;
        }

        private string fieldInfo(FieldInfo fieldInfo)
        {
            return fieldInfo.FieldType + " " + fieldInfo.Name;
        }
        public string methodSignature(MethodInfo methodInfo)
        {
            ParameterInfo[] parameters = methodInfo.GetParameters();
            string result = methodInfo.Name + "(";

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i].GetType().Name + " " + parameters[i].Name;
                if (i < parameters.Length - 1)
                {
                    result += ", ";
                }
            }

            result += ")";

            return result;
        }
    }
}