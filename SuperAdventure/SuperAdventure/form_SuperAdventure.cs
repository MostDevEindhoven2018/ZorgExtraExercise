using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class form_SuperAdventure : Form
    {
        private Player _player;
        public form_SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house.");
            
            _player = new Player(10, 10, 20, 0, 1);

            lbl_hitPoints.Text = _player.CurrentHitPoints.ToString();
            lbl_gold.Text = _player.Gold.ToString();
            lbl_exp.Text = _player.Experience.ToString();
            lbl_lvl.Text = _player.Level.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
