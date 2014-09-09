using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Repository.Interface;

namespace InterfaceGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            var fooList = GetList<IFoo>().ToList();
            foreach (IFoo foo in fooList)
            {
                Console.WriteLine(foo.GetFooString());
            }
            Console.WriteLine("End");
            Console.ReadLine();
        }

        private static IEnumerable<T> GetList<T>()
        {
            var types = GetAllClassesOfType(typeof(T));
            return from item in types
                   select (T)Activator.CreateInstance(item);
        }

        private static List<Type> GetAllClassesOfType(Type type)
        {
            //var types = AppDomain.CurrentDomain.GetAssemblies()
            //    .SelectMany(s => s.GetTypes())
            //    .Where(p => type.IsAssignableFrom(p) && p.IsClass && p.IsPublic && !p.IsGenericType).ToList();
            //return types;
            var types = AppDomain.CurrentDomain.GetAssemblies()
         .SelectMany(s => s.GetTypes())
         .Where(p => type.IsAssignableFrom(p) && p.IsClass && p.IsPublic && !p.IsGenericType).ToList();
            return types;
        }

    }
}
