using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6122_POE_PART1
{
    public partial class Form1 : Form
    {
        Map map = new Map(10, 20, 10, 20, 3);

        public Form1()
        {
            InitializeComponent();
            
            map.getHero().ToString();
            map.getEnemy();

            DisplayMap();
        }

        public void DisplayMap()
        {
            lblMap.Text = map.getMap().ToString();
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
    }
}
