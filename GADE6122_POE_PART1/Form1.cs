using System;
using System.Windows.Forms;

namespace GADE6122_POE_PART1
{
    public partial class Form1 : Form
    {
        GameEngine gameEngine = new GameEngine();

        public Form1()
        {
            InitializeComponent();

            Console.WriteLine("Hello");

            GameEngine.getMap().getHero().ToString();
            GameEngine.getMap().getEnemy();

            DisplayMap();

        }

        public void DisplayMap()
        {
            lblMap.Text = gameEngine.ToString();
        }

        public void FillComboBox()
        {
            for (int i = 0; i < GameEngine.getMap().getEnemy().Length; i++)
            {
                if (GameEngine.getMap().getHero().CheckRange(GameEngine.getMap().getEnemy()[i]))
                {
                    comboBoxEnemies.Items.Add(GameEngine.getMap().getEnemy()[i].getType());
                }
            }

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
            Console.WriteLine(gameEngine.ToString());
            GameEngine.getMap().getHero().Move(Character.Movement.Up);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            GameEngine.getMap().getHero().Move(Character.Movement.Down);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            GameEngine.getMap().getHero().Move(Character.Movement.Left);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            GameEngine.getMap().getHero().Move(Character.Movement.Right);
        }
    }
}
