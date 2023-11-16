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
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Bullet bullet = new Bullet('|');

            string topBot = null;
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(topBot);
            for (int i = 0; i < 50; i++)
            {
                builder.Append('*');
            }
            topBot = builder.ToString();

            Console.SetCursorPosition(0, 0);
            Console.WriteLine(topBot);

            Gun gun = new Gun(15,15,'^', bullet);
            gun.Print();
            
            FallingItem falling = new FallingItem('+');
            Thread thread = new Thread(() => falling.Fall());
            //falling.Fall();

            Target target = new Target('-');
            target.Print();

            while (true) 
            {
                Thread.Sleep(100);
                Console.SetCursorPosition(0,0);
                Console.WriteLine($"Score: { target.score}");
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.F) gun.GunFire(target);
                gun.MovedGun(info);
                //if(falling.)
            }
        }
    }
}
