﻿using System;
using System.Windows.Forms;

namespace GADE6122_POE_PART1
{
    public partial class Form1 : Form
    {
        GameEngine gameEngine = new GameEngine();

        public Form1()
        {
            InitializeComponent();

            DisplayPlayerInfo();

            DisplayMap();
            FillComboBox();

        }

        public void DisplayMap()
        {
            //lblMap.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace.ToString(), 10);
            lblMap.Text = gameEngine.ToString();
        }

        public void DisplayPlayerInfo()
        {
            lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
        }

        public void FillComboBox()
        {
            int count = 0;
            for (int i = 0; i < gameEngine.getMap().getEnemy().Length; i++)
            {
                count++;
                cboEnemies.Items.Add(gameEngine.getMap().getEnemy()[i].getType() + " [" + gameEngine.getMap().getEnemy()[i].getX() + ", "+ gameEngine.getMap().getEnemy()[i].getY() +"]");
            }
        }

        public void attack()
        {
            int selectedEnemy = cboEnemies.SelectedIndex;
            string e1 = "Enemy [" + gameEngine.getMap().getEnemy()[0].getX() + ", " + gameEngine.getMap().getEnemy()[0].getY() + "]";
            string e2 = "Enemy [" + gameEngine.getMap().getEnemy()[1].getX() + ", " + gameEngine.getMap().getEnemy()[1].getY() + "]";
            string e3 = "Enemy [" + gameEngine.getMap().getEnemy()[2].getX() + ", " + gameEngine.getMap().getEnemy()[2].getY() + "]";
            if (cboEnemies.Text == e1|| cboEnemies.Text == e2 || cboEnemies.Text == e3)
            {
                if (gameEngine.getMap().getHero().CheckRange(gameEngine.getMap().getEnemy()[selectedEnemy]))
                {
                    lblHitOrMiss.Text = "HIT!";
                    gameEngine.getMap().getHero().Attack(gameEngine.getMap().getEnemy()[selectedEnemy]);
                }
                else
                {
                    lblHitOrMiss.Text = "MISS!";
                }
            }
            else
            {
                lblHitOrMiss.Text = "Invalid Enemy Selected";
            }
        }
        public void DestroyHeroClones()
        {
            gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY()] = new EmptyTile(gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY(), Tile.TileType.Empty);
        }
        private void lblPlayerInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void lblHitOrMiss_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY() - 1] is Obstacle))
            {
                DestroyHeroClones();
                gameEngine.MovePlayer(Character.Movement.Up);
                lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
                DisplayMap();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {

            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY() + 1] is Obstacle))
            {
                DestroyHeroClones();
                gameEngine.MovePlayer(Character.Movement.Down);
                lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
                DisplayMap();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX() - 1, gameEngine.getMap().getHero().getY()] is Obstacle))
            {
                DestroyHeroClones();
                gameEngine.MovePlayer(Character.Movement.Left);
                lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
                DisplayMap();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX() + 1, gameEngine.getMap().getHero().getY()] is Obstacle))
            {
                DestroyHeroClones();
                gameEngine.MovePlayer(Character.Movement.Right);
                lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
                DisplayMap();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            attack();
        }
    }
}
