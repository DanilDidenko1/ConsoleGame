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
        public void MovedBullet(int x , int y, Target target)
        {
            this.x = x;
            this.y = y;
            int start = y;
            while (this.y != 2) 
            {
                Thread.Sleep(60);
                this.y -= 1;
                if (this.y + 1 == start) continue;
                Clear(this.x, this.y + 1);
                Print(this.x, this.y);
                if(IsHit(target)) break;
            }
            Clear(this.x, this.y);
        }
        public bool IsHit(Target target)
        {
            if (target.x == x && target.y == y)
            {
                target.CreateNewTarget();

                return true;
            };
            return false;
        }
    }
}
