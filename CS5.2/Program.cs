using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many forms do you want?");
            int n = Int32.Parse( Console.ReadLine());
            
            FullFigure fullFigure = new FullFigure(n);
            ConsoleColor c=ConsoleColor.White;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Choose form "+(i+1)+": ");
                Console.WriteLine("1.Triangle    2.Rectangle   3.Rhombus   4.Trapezoid");
                int choice_f= Int32.Parse(Console.ReadLine());
                while (choice_f<1||choice_f>4)
                {
                    Console.WriteLine("Wrong number!");
                    Console.WriteLine("Choose form " + (i + 1) + ": ");
                    Console.WriteLine("1.Triangle    2.Rectangle   3.Rhombus   4.Trapezoid");
                     choice_f = Int32.Parse(Console.ReadLine());
                }
               

                Console.WriteLine("Choose color for form " + (i + 1) + ": ");
                Console.WriteLine("1.Red    2.Green   3.Yellow   4.Blue   5.White");
                int choice_c = Int32.Parse(Console.ReadLine());
                while (choice_c < 1 || choice_c > 5)
                {
                    Console.WriteLine("Wrong number!");
                    Console.WriteLine("Choose color for form " + (i + 1) + ": ");
                    Console.WriteLine("1.Red    2.Green   3.Yellow   4.Blue   5.White");
                    choice_c = Int32.Parse(Console.ReadLine());
                }

                if (choice_c == 1) c = ConsoleColor.Red;
                else if (choice_c == 2) c = ConsoleColor.Green;
                else if (choice_c == 3) c = ConsoleColor.Yellow;
                else if (choice_c == 4) c = ConsoleColor.Blue;
                else if (choice_c == 5) c = ConsoleColor.White;
                else
                {
                    c = ConsoleColor.White;
                }


                if (choice_f == 1) fullFigure.form[i] = new Triangle(c);
                else if (choice_f == 2) fullFigure.form[i] = new Rectangle(c);
                else if (choice_f == 3) fullFigure.form[i] = new Rhombus(c);
                else if (choice_f == 4) fullFigure.form[i] = new Trapezoid(c);
                else
                {
                    fullFigure.form[i] = new Rectangle(c);
                }
            }

            Console.Clear();
            Console.WriteLine("Now we print all the forms!");
            fullFigure.PrintAll();
        }
    }
}
