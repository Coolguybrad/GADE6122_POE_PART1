using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART1
{
    class GameEngine
    {
        private  Map map; //Map object
        private readonly char[] symbols = { 'H', '.', 'S', 'X' }; //char array of symbols which represent the tiletype enum
        public GameEngine() //constructor that gives values to the map object
        {
            map = new Map(10, 20, 10, 20, 3); //Min Width, Max Width, min Height, max Height, num of Enemies
        }

        public  Map getMap()
        {
            return map; //returns map
        }

        public bool MovePlayer(Character.Movement m)

        {
            //x and y variables of the hero on the map
            int y = map.getHero().getX();
            int x = map.getHero().getY();

            bool result = false;//result to return
            if (m != Character.Movement.Stationary) //if m is not = to stationay the code below will run
            {
                map.getMap()[x, y] = new EmptyTile(x, y, Tile.TileType.Empty); //puts an empty tile where the hero was
                map.getHero().Move(m); //Calls get hero which calls move
                map.getMap()[x, y] = map.getHero(); //sets heroes new location on the map array to the hero object that was created
                map.UpdateVision(); //updates vision
                result = true; //sets result to true
            }
            return result; //returns result
        }
        public override string ToString()
        {
            //nested forloop which parses the map array and returns it in a string format
            string result = "";
            Console.WriteLine(result + "something, anything");
            for (int i = 0; i < map.getMap().GetLength(0); i++)
            {
                for (int j = 0; j < map.getMap().GetLength(1); j++)
                {
                    if (map.getMap()[i, j] is EmptyTile) //For the "."
                    {
                        result += symbols[1] + "  ";
                    }
                    else if (map.getMap()[i, j] is Obstacle) //For the "X"
                    {
                        result += symbols[3] + " ";
                    }
                    else if (map.getMap()[i, j] is Enemy) //For the "S"
                    {
                        result += symbols[2] + " ";
                    }
                    else if (map.getMap()[i, j] is Hero) //For the "H"
                    {
                        result += symbols[0] + " ";
                    }
                    

                }
                result += "\n";
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
