using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Reflection
{
    class ReflectionTest
    {
        public static void Test()
        {
            Type type = Type.GetType("Reflection.CustomerInfo");
            Console.WriteLine("Full Name :{0}", type.FullName);
            Console.WriteLine("Class Name :{0}", type.Name);
            Console.WriteLine("Methods in customer class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name +" " + method.Name);
            }
            Console.WriteLine("Properties in customer class");
          PropertyInfo[] properties = type.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine("\nConstructor is customerInfo class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
        
    
    
    }

