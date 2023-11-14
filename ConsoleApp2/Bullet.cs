using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bullet : Figure
    {
        public Bullet(char body) : base(body)
        {

        }
        public void Clear(int x, int y) 
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(' ');
        }
        public void Print(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(body);
        }
        public async Task MovedBullet(int x , int y)
        {
            int start = y;
            while (y != 0) 
            {
                Thread.Sleep(120);
                y -= 1;
                if (y + 1 == start) continue;
                await Task.Run( () => Clear(x, y + 1));
                await Task.Run( () => Print(x,y));
            }
            await Task.Run( () => Clear(x, y));
        }
    }
}
