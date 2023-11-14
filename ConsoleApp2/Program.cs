using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            Console.CursorVisible = false;

            Bullet bullet = new Bullet('|');

            Gun gun = new Gun(15,15,'^', bullet);
            gun.Print();
            
            FallingItem falling = new FallingItem('+');
            falling.Fall();
            
            while (true) 
            {
                //Thread.Sleep(150);
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.F) gun.GunFire();
                gun.MovedGun(info);
                //if(falling.)
            }
        }
    }
}
