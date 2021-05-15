using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5._2
{
    abstract class Form
    {
        public abstract ConsoleColor Color { get; set; }
        public abstract void PrintForm();
    }
}
