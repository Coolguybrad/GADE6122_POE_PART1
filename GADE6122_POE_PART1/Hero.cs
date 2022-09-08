using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART1
{
    class Hero : Character
    {
        public Hero(int x, int y, TileType t, int d, int hp, int mHP) : base(x, y, t)
        {
            this.hp = hp;
            this.maxHP = mHP;
            this.tType = TileType.Hero;
            this.damage = 2;
        }

        public override Movement ReturnMove(Movement m)
        {
            Movement result = Movement.Stationary;

            ConsoleKeyInfo keyPress = Console.ReadKey();

            if (ConsoleKey.W == keyPress.Key)
            {
                if (playerVision[0].getType() != TileType.Enemy || (playerVision[0] is Obstacle)) //Will de Morgan mess us UP??????
                {
                    result = Movement.Up;
                }
            }
            else if (ConsoleKey.S == keyPress.Key)
            {
                if (playerVision[1].getType() != TileType.Enemy || (playerVision[0] is Obstacle))//Will de Morgan mess us UP??????
                {
                    result = Movement.Down;
                }
            }
            else if (ConsoleKey.A == keyPress.Key)
            {
                if (playerVision[2].getType() != TileType.Enemy || (playerVision[0] is Obstacle))//Will de Morgan mess us UP??????
                {
                    result = Movement.Left;
                }
            }
            else if (ConsoleKey.D == keyPress.Key)
            {
                if (playerVision[3].getType() != TileType.Enemy || (playerVision[0] is Obstacle))//Will de Morgan mess us UP??????
                {
                    result = Movement.Right;
                }
            }

            return result; //returns move
        }

        public override string ToString()
        {
            return "Player Stats:\n" +
                   "HP: " + hp + " / " + maxHP +
                   "\nDamage: 2\n" +
                   "[" + x + "," + y + "]";
        }
    }
}
