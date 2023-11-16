using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Gun : Figure
    {
        Bullet bullet;
        public Gun(int x, int y, char body, Bullet bullet) : base (x, y, body)
        {
            this.bullet = bullet;
        }
        public void MovedGun(ConsoleKeyInfo keyInfo) 
        {
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                Clear();
                x -= 1;
                Print();
                
            }
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                Clear();
                x += 1;
                Print();
            }
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                Clear();
                y -= 1;
                Print();
            }
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                Clear();
                y += 1;
                Print();
            }
        }
        public void GunFire(Target target)
        {
           Thread thread = new Thread( () => bullet.MovedBullet(x, y, target));
           thread.Start();       
        }
    }
}
