using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART1
{
    class Hero : Character //Inherits from Character class
    {
        //Hero constructor:
        public Hero(int x, int y, TileType t, int d, int hp, int mHP) : base(x, y, t)
        {
            this.hp = hp;
            this.maxHP = mHP;
            this.tType = TileType.Hero;
            this.damage = 2;
        }

        public override Movement ReturnMove(Movement m) //Might be a problem because of movement
        {
            Movement result = Movement.Stationary;
            
            if (m == Movement.Up)
            {
                if (playerVision[0].getType() != TileType.Enemy || !(playerVision[0] is Obstacle)) //Will de Morgan mess us UP??????
                {
                    result = Movement.Up;
                }
            }
            else if (m == Movement.Down)
            {
                if (playerVision[1].getType() != TileType.Enemy || !(playerVision[0] is Obstacle))//Will de Morgan mess us UP??????
                {
                    result = Movement.Down;
                }
            }
            else if (m == Movement.Left)
            {
                if (playerVision[2].getType() != TileType.Enemy || !(playerVision[0] is Obstacle))//Will de Morgan mess us UP??????
                {
                    result = Movement.Left;
                }
            }
            else if (m == Movement.Right)
            {
                if (playerVision[3].getType() != TileType.Enemy || !(playerVision[0] is Obstacle))//Will de Morgan mess us UP??????
                {
                    result = Movement.Right;
                }
            }

            return result; //returns move
        }

        //Overriding the ToString() method to display the hero's stats, using concatenation:
        public override string ToString()
        {
            return "Player Stats:\n==========\n" +
                   "HP: " + hp + " / " + maxHP +
                   "\nDamage: 2\n" +
                   "Position: " + getY() + ", " + getX();
        }
    }
}
