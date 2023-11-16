using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Target : Figure
    {
        public int score = 0;
        public Target(char body) : base (body)
        {
            Random random = new Random();
            y = random.Next(0,20);
        }
        public void CreateNewTarget()
        {
            Random random = new Random();
            x = random.Next(0,20);
            y = random.Next(0,20);
            Print();
            score++;
        }
    }
}
