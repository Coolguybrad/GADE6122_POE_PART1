using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART1
{
    class Map
    {
        //Creating variables which hold the Hero and Enemy tile type
        Tile.TileType typeH = Tile.TileType.Hero;
        Tile.TileType typeE = Tile.TileType.Enemy;

        private Tile[,] map; //2D Tile array
        private Hero hero; //Hero object
        private Enemy[] enemy;//1D Enemy array holding enemy objects
        private int width; //map width
        private int height; //map height
        private int enemyCount = 0; //enemy counter
        private Random randNum = new Random(); //random number object

        //Constructor
        public Map(int minW, int maxW, int minH, int maxH, int numE)
        {
            height = randNum.Next(minH, maxH);
            width = randNum.Next(minW, maxW);
            map = new Tile[height, width];
            enemy = new Enemy[numE];
            //Create() for hero
            Create(typeH);
            //Create() for Enemy array
            for (int i = 0; i < enemy.Length; i++)
            {
                Create(typeE);
                enemyCount++;
            }
        }

        //Accessors & Mutators
        public Tile[,] getMap()
        {
            return map;
        }
        public void setMap(Tile[,] m)
        {
            map = m;
        }

        public Hero getHero()
        {
            return hero;
        }
        public void setHero(Hero h)
        {
            hero = h;
        }

        public Enemy[] getEnemy()
        {
            return enemy;
        }
        public void setEnemy(Enemy[] e)
        {
            enemy = e;
        }

        public int getWidth()
        {
            return width;
        }
        public void setWidth(int w)
        {
            width = w;
        }

        public int getHeight()
        {
            return height;
        }
        public void setHeight(int h)
        {
            height = h;
        }

        //Update vision of hero or enemy
        public void UpdateVision()
        {
            Tile[] hVis = new Tile[4];
            hVis[0] = map[hero.getX(), hero.getY() - 1];
            hVis[1] = map[hero.getX(), hero.getY() + 1];
            hVis[2] = map[hero.getX() - 1, hero.getY()];
            hVis[3] = map[hero.getX() + 1, hero.getY()];
            hero.setPlayerVision(hVis);

            for (int i = 0; i < enemy.Length; i++)
            {
                Tile[] eVis = new Tile[4];
                eVis[0] = map[enemy[i].getX(), enemy[i].getY() - 1];
                eVis[1] = map[enemy[i].getX(), enemy[i].getY() + 1];
                eVis[2] = map[enemy[i].getX() - 1, enemy[i].getY()];
                eVis[3] = map[enemy[i].getX() + 1, enemy[i].getY()];
                enemy[i].setPlayerVision(eVis);
            }

        }

        //creates hero or enemy
        private Tile Create(Tile.TileType t)
        {
            Random rand = new Random();
            int numX = rand.Next(map.GetLength(0));
            int numY = rand.Next(map.GetLength(1));
            bool valid = false;
            Tile result = null;
            if (t == typeH)
            {

                while (!valid)
                {
                    if (map[numX, numY].getType() == typeE || (map[numX, numY] is Obstacle))
                    {
                        numX = rand.Next();
                        numY = rand.Next();
                        valid = false;
                    }
                    else
                    {
                        hero.setX(numX);
                        hero.setY(numY);

                        valid = true;
                        result = hero;
                    }
                }
            }
            else
            {
                valid = false;
                while (!valid)
                {

                    if (map[numX, numY].getType() == typeH || map[numX, numY].getType() == typeE || (map[numX, numY] is Obstacle))
                    {
                        numX = rand.Next();
                        numY = rand.Next();
                        valid = false;
                    }
                    else
                    {
                        enemy[enemyCount].setX(numX);
                        enemy[enemyCount].setY(numY);
                        valid = true;
                        result = enemy[enemyCount];
                    }
                }
            }
            return result;
        }
    }
}
