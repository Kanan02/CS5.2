using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5._2
{
    class Rhombus : Form
    {
        public Rhombus(ConsoleColor color)
        {
            Color = color;
        }

        public override ConsoleColor Color { get; set; }

        public override void PrintForm()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("  *  \n * * \n*   *\n*   *\n * * \n  *  \n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
