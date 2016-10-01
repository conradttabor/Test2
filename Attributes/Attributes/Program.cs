using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Console.WriteLine("-----------------");
            GoodbyeWorld();
            Console.WriteLine("-----------------");
            Console.ReadLine();
        }

        [ConsoleColor(System.ConsoleColor.Red)]
        public static void HelloWorld()
        {
            AttributeCaller(MethodBase.GetCurrentMethod());
            Console.WriteLine("Hello World!");
            OriginalColor();
        }

        [ConsoleColor(System.ConsoleColor.Magenta)]
        public static void GoodbyeWorld()
        {
            AttributeCaller(MethodBase.GetCurrentMethod());
            Console.WriteLine("Goodbye cruel World!");
            OriginalColor();
        }

        public static void AttributeCaller(MethodBase t)
        {
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);
        }

        private static void OriginalColor()
        {
            Console.ForegroundColor = System.ConsoleColor.White;
        }
    }
}
