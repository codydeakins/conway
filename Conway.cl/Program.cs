using conway.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Conway.cl
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = new World(40, 16);





            world.RandomizeCells();

            while (true)
            {
                Console.Clear();

                world.Display();
                world.Step();

                Thread.Sleep(100);
            }




            Console.ReadKey();
        }
        
    }
}
