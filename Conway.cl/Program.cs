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

            var neighbors = world.NeighborsFor(40, 16);
            Console.WriteLine("(1,1) has {0} neighbors", neighbors.Count);









            Console.ReadKey();
        }
        
    }
}
