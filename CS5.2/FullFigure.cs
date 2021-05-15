using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5._2
{
    class FullFigure
    {
        public int Length { get; set; }
        public Form[] form;
        public FullFigure(int length)
        {
            Length = length;
            form = new Form[length];
        }
        public void PrintAll()
        {
            for (int i = 0; i < form.Length; i++)
            {
                form[i].PrintForm();
                Console.WriteLine();
            }
        }
    }
}
