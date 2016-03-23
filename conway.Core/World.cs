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

        public void RandomizeCells()
        {
            var rand = new Random();
            for (int w = 0; w < _width; w++)
            {
                for (int h = 0; h < _height; h++)
                {

                    var randomNumber = rand.Next(2);
                    _cells[w, h].State = randomNumber == 0 ? CellState.Dead : CellState.Alive;
                }
            }

        }

        public void Step()
        {
            var newCells = new Cell[_width, _height];
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    var aliveCount = CountLiveNeighbors(x, y);
                    var cell = _cells[x, y];
                    CellState newState;
                    newState = CalculateNewCellState(cell, aliveCount);

                    newCells[x, y] = new Cell();
                    newCells[x, y].State = newState;
                }
            }

            _cells = newCells;

        }

        private static CellState CalculateNewCellState(Cell cell, int aliveCount)
        {
            CellState newState = cell.State;
            if (cell.State == CellState.Alive)
            {
                if (aliveCount < 2)
                {
                    newState = CellState.Dead;
                }
                if (aliveCount == 2 || aliveCount == 3)
                {
                    newState = CellState.Alive;
                }
                else
                {
                    newState = CellState.Dead;
                }

            }
            else//dead
            {
                if (aliveCount == 3)
                {
                    newState = CellState.Alive;
                }
            }

            return newState;
        }

        private int CountLiveNeighbors(int x, int y)
        {
            var neighbors = NeighborsFor(x, y);
            int count = 0;
            foreach(var neighbor in neighbors)
            {
                if (neighbor.State == CellState.Alive)
                {
                    count++;
                }

            }
            return count;
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

        public void Display()
        {
            const char DEAD = '.';
            const char ALIVE = '#';

            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    Console.Write(_cells[x, y].DisplayCharacter);
                }

                Console.WriteLine();
            }
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
