using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART1
{
    abstract class Tile
    {
        protected int x; //integer for x coordinate
        protected int y; //integer for y coordinate
        public enum TileType { Hero, Enemy, Gold, Weapon, Empty, Wall }; //enum variable to define the type of tile
        protected TileType tType; //tile type
        public Tile(int x, int y, TileType t) //constructor that accepts two integers which are used to give the x and y variables values
        {
            this.x = x;
            this.y = y;
            tType = t;
        }

        public int getX() //getter method that returns the x variable
        {
            return x;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public int getY() //getter method that returns the y variable
        {
            return y;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public TileType getType()
        {
            return tType;
        }
    }
}
