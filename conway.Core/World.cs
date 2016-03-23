using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conway.Core
{
    public class World
    {
        private int _width;
        private int _height;
        private Cell[,] _cells;



        public World(int width, int height)
        {
            _width = width;
            _height = height;

            _cells = new Cell[width, height];

            InitializeCells();
        }


        private void InitializeCells()
        {
            for (int w = 0; w < _width; w++)
            {
                for (int h = 0; h < _height; h++)
                {
                    _cells[w, h] = new Cell();
                    _cells[w, h].State = CellState.Dead;
                }
            }
        }

        public List<Cell> NeighborsFor(int x, int y)
        {
            var neighbors = new List<Cell>();


            if (IsValidLocations(x - 1, y - 1))
            {
                neighbors.Add(_cells[x - 1, y - 1]);
            }


            if (IsValidLocations(x, y - 1))
            {
                neighbors.Add(_cells[x, y - 1]);
            }

            if (IsValidLocations(x + 1, y - 1))
            {
                neighbors.Add(_cells[x + 1, y - 1]);
            }
            if (IsValidLocations(x - 1, y))
            {
                neighbors.Add(_cells[x - 1, y]);
            }
            if (IsValidLocations(x + 1, y))
            {
                neighbors.Add(_cells[x + 1, y]);
            }
            if (IsValidLocations(x - 1, y + 1))
            {
                neighbors.Add(_cells[x - 1, y + 1]);
            }

            if (IsValidLocations(x, y + 1))
            {
                neighbors.Add(_cells[x, y + 1]);
            }

            if (IsValidLocations(x + 1, y + 1))
            {
                neighbors.Add(_cells[x + 1, y + 1]);
            }






            return neighbors;
        }

        private bool IsValidLocations(int x, int y)
        {
            if (x < 0 || x >= _width)
                return false;


            if (y < 0 || y >= _height)
                return false;

            return true;
        }







        public int Width
        {
            get
            {
                return _width;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
        }




    }//end class
}//end namespace
