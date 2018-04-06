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
using Engine.Items;

namespace SuperAdventure
{
    public partial class form_SuperAdventure : Form
    {
        private Player _player;
        public form_SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(LocationID.INVALID, "Home", "This is your house.");
            
            _player = new Player(10, 10, 20, 0, 1);

            lbl_hitPoints.Text = _player.CurrentHitPoints.ToString();
            lbl_gold.Text = _player.Gold.ToString();
            lbl_exp.Text = _player.Experience.ToString();
            lbl_lvl.Text = _player.Level.ToString();
            _player.GoldChanged += (gold) => lbl_gold.Text = gold.ToString();
            _player.ExperienceChanged += (experience) => lbl_gold.Text = experience.ToString();
            _player.LevelChanged += (level) => lbl_gold.Text = level.ToString();

            { //example lines
                _player.Inventory.Add(new InventoryItem(new Item(ItemID.INVALID, "itemName", "itemNames"), 1));
                _player.Inventory.Add(new InventoryItem(new Item(ItemID.INVALID, "otheritemName", "itemNames"), 4));
            }
            cbo_potions.DataSource = _player.Inventory;

            { //example line
                _player.Inventory.Add(new InventoryItem(new HealingPotion(ItemID.HEALING_POTION, "hp_pot", "hp_pots", 5), 1));
                _player.Gold += 5;
            }

            World.InitWorld();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
