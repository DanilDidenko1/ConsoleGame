using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FallingItem : Figure
    {
        public FallingItem(char body) : base (body)
        {
            
        }
        public void Fall()
        {
            while (true) 
            {
                Thread.Sleep(1000);
                Clear();
                y++;
                Print();
            }
        }
        public void IsCrash()
        {
            /*
            if(bullet.y + 1 == y && bullet.x == x)
            {
                
            }*/
        }
    }
}
