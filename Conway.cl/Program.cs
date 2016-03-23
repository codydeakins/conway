using conway.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.cl
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = new World(40, 16);

            Console.WriteLine("The world is {0} by {1} big ", world.Width, world.Height);









            Console.ReadKey();
        }
        
    }
}
