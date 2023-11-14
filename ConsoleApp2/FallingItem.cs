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
        public async Task Fall()
        {
            while (true) 
            {
                Thread.Sleep(1000);
                await Task.Run( () => Clear());
                y++;
                await Task.Run( () => Print());
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
