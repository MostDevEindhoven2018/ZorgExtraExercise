﻿using System;
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

            _player = new Player(10, 10, 20, 0, 1);

            lbl_hitPoints.Text = _player.CurrentHitPoints.ToString();
            lbl_gold.Text = _player.Gold.ToString();
            lbl_exp.Text = _player.Experience.ToString();
            lbl_lvl.Text = _player.Level.ToString();
            _player.GoldChanged += (gold) => lbl_gold.Text = gold.ToString();
            _player.ExperienceChanged += (experience) => lbl_gold.Text = experience.ToString();
            _player.LevelChanged += (level) => lbl_gold.Text = level.ToString();
            _player.HitPointsChanged += (hp) => lbl_hitPoints.Text = hp.ToString();

            dgv_inventory.DataSource = _player.Inventory;
            dgv_quests.DataSource = _player.Quests;


            { //example lines
                _player.Inventory.Add(new InventoryItem(new Item(ItemID.INVALID, "itemName", "itemNames"), 1));
                _player.Inventory.Add(new InventoryItem(new Item(ItemID.INVALID, "otheritemName", "itemNames"), 4));
            }
            

            World.InitWorld();


            { //example line
                _player.Inventory.Add(new InventoryItem(new HealingPotion(ItemID.HEALING_POTION, "hp_pot", "hp_pots", 5), 1));
                _player.Gold += 5;
                _player.Inventory.Add(new InventoryItem(World.Items[ItemID.CLUB], 1));
                _player.Inventory.Add(new InventoryItem(World.Items[ItemID.RUSTY_SWORD], 1));
            }

            cbo_Weapons_Click(null, null);
            cbo_potions_Click(null, null);
            rtb_location.Text = World.Locations[LocationID.HOME].Description;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbo_Weapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item details = ((InventoryItem)cbo_Weapons.SelectedItem).Details;
            rtb_messages.Text += "Equiped a " + details.Name + "\n";
        }

        private void cbo_Weapons_Click(object sender, EventArgs e)
        {
            cbo_Weapons.DataSource = new List<InventoryItem>(_player.Inventory.Where((a) => a.Details is Weapon));
        }

        private void cbo_potions_Click(object sender, EventArgs e)
        {
            cbo_potions.DataSource = new List<InventoryItem>(_player.Inventory.Where((a) => a.Details is HealingPotion));
        }

        private void cbo_potions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Item selectedPotion = ((InventoryItem)cbo_Weapons.SelectedItem).Details;
            rtb_messages.Text += "Equiped a " + selectedPotion.Name + "\n";
        }

        private void btn_useWeapon_Click(object sender, EventArgs e)
        {
            _player.Inventory.Add(new InventoryItem(World.Items[ItemID.CLUB], 1));
        }
    }
}
