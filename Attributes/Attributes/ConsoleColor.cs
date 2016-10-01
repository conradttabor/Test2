using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// I chose a bad name for this class, System.ConsoleColor is an actual class for
// console colors, so don't get confused, they are referencing different things.


namespace Attributes
{
    // To know that this will target methods
    [AttributeUsage(AttributeTargets.Method)]
    class ConsoleColor : System.Attribute
    {
        public System.ConsoleColor color { get; set; }

        public ConsoleColor(System.ConsoleColor color)
        {
            this.color = color;

            Console.ForegroundColor = color;
        }
    }
}
