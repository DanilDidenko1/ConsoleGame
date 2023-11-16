using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Figure
    {
        public int x;
        public int y;
        public char body;
        public Figure(char body)
        {
            Random random = new Random();
            x = random.Next(1, 20);
            y = 0;
            this.body = body;
        }
        public Figure(int x, int y, char body) 
        {
            this.x = x;
            this.y = y;
            this.body = body;
        }
        public void Print()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(body);
        }
        public void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(' ');
        }
    }
}
