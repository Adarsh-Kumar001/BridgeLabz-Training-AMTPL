using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; //required for reflections

namespace BridgeLabz_Training.reflections
{

    public class Person
    {
        public string Name { get; set; }
        public int Age;

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
   
    


    internal class ReflectionsDemo
    {

        //Reflection allows a C# program to inspect, discover, and interact with its own metadata at runtime.
        //You can see classes, methods, properties, fields. ALl at runtime without knwoing at compile time

        static void Main(string[] args)
        {
            Type type = typeof(Person);   //Type is entry point to reflections. Can also write Type type = person.GetType();

            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.IsClass);

            //Get fields
            FieldInfo[] fields = type.GetFields();

            foreach (var field in fields)
            {
                Console.WriteLine(field.Name);
            }

            //get properties
            PropertyInfo[] properties = type.GetProperties();

            foreach (var prop in properties)
            {
                Console.WriteLine(prop.Name);
            }


            //get methods
            MethodInfo[] methods = type.GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }


        }
    }
}
