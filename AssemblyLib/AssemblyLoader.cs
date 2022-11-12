using System;
using System.Collections.Generic;
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
            AssemblyInfo assemblyInfo = new AssemblyInfo();
            assemblyInfo.Name = assembly.GetName().Name;

            List<TypeInfo> typeInfos = new List<TypeInfo>();

            assemblyInfo.Types = typeInfos;
            foreach(var type in types)
            {
                TypeInfo typeInfo = new TypeInfo();
                typeInfo.Name = type.Name;
                var meths = type.GetMethods();
                var fields = type.GetFields();
                var props = type.GetProperties();

                List<string> propsInfo = new List<string>();
                foreach (var prop in props)
                {
                    propsInfo.Add(propInfo(prop));
                }

                List<string> fieldsInfo = new List<string>();
                foreach (var field in fields)
                {
                    fieldsInfo.Add(fieldInfo(field));
                }

                List<string> methsInfo = new List<string>();
                foreach (var meth in meths)
                {
                    methsInfo.Add(methodSignature(meth));
                }
                
                typeInfo.PropertiesInfo = propsInfo;
                typeInfo.MethodsInfo = methsInfo;
                typeInfo.FieldsInfo = fieldsInfo;

                typeInfos.Add(typeInfo);
            }
            Console.WriteLine(assembly.GetTypes()[0].Name);

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