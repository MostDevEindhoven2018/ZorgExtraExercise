﻿namespace SuperAdventure
{
    partial class form_SuperAdventure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.lbl_exp = new System.Windows.Forms.Label();
            this.lbl_gold = new System.Windows.Forms.Label();
            this.lbl_hitPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_Weapons = new System.Windows.Forms.ComboBox();
            this.cbo_potions = new System.Windows.Forms.ComboBox();
            this.btn_useWeapon = new System.Windows.Forms.Button();
            this.btn_usePotion = new System.Windows.Forms.Button();
            this.btn_north = new System.Windows.Forms.Button();
            this.btn_east = new System.Windows.Forms.Button();
            this.btn_south = new System.Windows.Forms.Button();
            this.btn_west = new System.Windows.Forms.Button();
            this.rtb_location = new System.Windows.Forms.RichTextBox();
            this.rtb_messages = new System.Windows.Forms.RichTextBox();
            this.dgv_inventory = new System.Windows.Forms.DataGridView();
            this.dgv_quests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Experience:";
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Location = new System.Drawing.Point(147, 122);
            this.lbl_lvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(46, 17);
            this.lbl_lvl.TabIndex = 4;
            this.lbl_lvl.Text = "label5";
            // 
            // lbl_exp
            // 
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.Location = new System.Drawing.Point(147, 90);
            this.lbl_exp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(46, 17);
            this.lbl_exp.TabIndex = 5;
            this.lbl_exp.Text = "label6";
            // 
            // lbl_gold
            // 
            this.lbl_gold.AutoSize = true;
            this.lbl_gold.Location = new System.Drawing.Point(147, 55);
            this.lbl_gold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gold.Name = "lbl_gold";
            this.lbl_gold.Size = new System.Drawing.Size(46, 17);
            this.lbl_gold.TabIndex = 6;
            this.lbl_gold.Text = "label7";
            // 
            // lbl_hitPoints
            // 
            this.lbl_hitPoints.AutoSize = true;
            this.lbl_hitPoints.Location = new System.Drawing.Point(147, 23);
            this.lbl_hitPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hitPoints.Name = "lbl_hitPoints";
            this.lbl_hitPoints.Size = new System.Drawing.Size(46, 17);
            this.lbl_hitPoints.TabIndex = 7;
            this.lbl_hitPoints.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(823, 654);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select action";
            // 
            // cbo_Weapons
            // 
            this.cbo_Weapons.FormattingEnabled = true;
            this.cbo_Weapons.Location = new System.Drawing.Point(492, 688);
            this.cbo_Weapons.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Weapons.Name = "cbo_Weapons";
            this.cbo_Weapons.Size = new System.Drawing.Size(160, 24);
            this.cbo_Weapons.TabIndex = 9;
            this.cbo_Weapons.SelectionChangeCommitted += new System.EventHandler(this.cbo_Weapons_SelectedIndexChanged);
            this.cbo_Weapons.Click += new System.EventHandler(this.cbo_Weapons_Click);
            // 
            // cbo_potions
            // 
            this.cbo_potions.FormattingEnabled = true;
            this.cbo_potions.Location = new System.Drawing.Point(492, 730);
            this.cbo_potions.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_potions.Name = "cbo_potions";
            this.cbo_potions.Size = new System.Drawing.Size(160, 24);
            this.cbo_potions.TabIndex = 10;
            this.cbo_potions.SelectionChangeCommitted += new System.EventHandler(this.cbo_potions_SelectionChangeCommitted);
            this.cbo_potions.Click += new System.EventHandler(this.cbo_potions_Click);
            // 
            // btn_useWeapon
            // 
            this.btn_useWeapon.Location = new System.Drawing.Point(827, 688);
            this.btn_useWeapon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_useWeapon.Name = "btn_useWeapon";
            this.btn_useWeapon.Size = new System.Drawing.Size(100, 28);
            this.btn_useWeapon.TabIndex = 11;
            this.btn_useWeapon.Text = "Use";
            this.btn_useWeapon.UseVisualStyleBackColor = true;
            this.btn_useWeapon.Click += new System.EventHandler(this.btn_useWeapon_Click);
            // 
            // btn_usePotion
            // 
            this.btn_usePotion.Location = new System.Drawing.Point(827, 730);
            this.btn_usePotion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_usePotion.Name = "btn_usePotion";
            this.btn_usePotion.Size = new System.Drawing.Size(100, 28);
            this.btn_usePotion.TabIndex = 12;
            this.btn_usePotion.Text = "Use";
            this.btn_usePotion.UseVisualStyleBackColor = true;
            this.btn_usePotion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_north
            // 
            this.btn_north.Location = new System.Drawing.Point(657, 533);
            this.btn_north.Margin = new System.Windows.Forms.Padding(4);
            this.btn_north.Name = "btn_north";
            this.btn_north.Size = new System.Drawing.Size(100, 28);
            this.btn_north.TabIndex = 13;
            this.btn_north.Text = "North";
            this.btn_north.UseVisualStyleBackColor = true;
            // 
            // btn_east
            // 
            this.btn_east.Location = new System.Drawing.Point(764, 562);
            this.btn_east.Margin = new System.Windows.Forms.Padding(4);
            this.btn_east.Name = "btn_east";
            this.btn_east.Size = new System.Drawing.Size(100, 28);
            this.btn_east.TabIndex = 14;
            this.btn_east.Text = "East";
            this.btn_east.UseVisualStyleBackColor = true;
            // 
            // btn_south
            // 
            this.btn_south.Location = new System.Drawing.Point(657, 599);
            this.btn_south.Margin = new System.Windows.Forms.Padding(4);
            this.btn_south.Name = "btn_south";
            this.btn_south.Size = new System.Drawing.Size(100, 28);
            this.btn_south.TabIndex = 15;
            this.btn_south.Text = "South";
            this.btn_south.UseVisualStyleBackColor = true;
            // 
            // btn_west
            // 
            this.btn_west.Location = new System.Drawing.Point(549, 562);
            this.btn_west.Margin = new System.Windows.Forms.Padding(4);
            this.btn_west.Name = "btn_west";
            this.btn_west.Size = new System.Drawing.Size(100, 28);
            this.btn_west.TabIndex = 16;
            this.btn_west.Text = "West";
            this.btn_west.UseVisualStyleBackColor = true;
            // 
            // rtb_location
            // 
            this.rtb_location.Location = new System.Drawing.Point(463, 23);
            this.rtb_location.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_location.Name = "rtb_location";
            this.rtb_location.ReadOnly = true;
            this.rtb_location.Size = new System.Drawing.Size(479, 128);
            this.rtb_location.TabIndex = 17;
            this.rtb_location.Text = "";
            // 
            // rtb_messages
            // 
            this.rtb_messages.Location = new System.Drawing.Point(463, 160);
            this.rtb_messages.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_messages.Name = "rtb_messages";
            this.rtb_messages.ReadOnly = true;
            this.rtb_messages.Size = new System.Drawing.Size(479, 351);
            this.rtb_messages.TabIndex = 18;
            this.rtb_messages.Text = "";
            // 
            // dgv_inventory
            // 
            this.dgv_inventory.AllowUserToAddRows = false;
            this.dgv_inventory.AllowUserToDeleteRows = false;
            this.dgv_inventory.AllowUserToResizeRows = false;
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_inventory.Enabled = false;
            this.dgv_inventory.Location = new System.Drawing.Point(21, 160);
            this.dgv_inventory.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_inventory.MultiSelect = false;
            this.dgv_inventory.Name = "dgv_inventory";
            this.dgv_inventory.ReadOnly = true;
            this.dgv_inventory.RowHeadersVisible = false;
            this.dgv_inventory.Size = new System.Drawing.Size(416, 380);
            this.dgv_inventory.TabIndex = 19;
            // 
            // dgv_quests
            // 
            this.dgv_quests.AllowUserToAddRows = false;
            this.dgv_quests.AllowUserToDeleteRows = false;
            this.dgv_quests.AllowUserToResizeRows = false;
            this.dgv_quests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_quests.Enabled = false;
            this.dgv_quests.Location = new System.Drawing.Point(21, 549);
            this.dgv_quests.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_quests.MultiSelect = false;
            this.dgv_quests.Name = "dgv_quests";
            this.dgv_quests.ReadOnly = true;
            this.dgv_quests.RowHeadersVisible = false;
            this.dgv_quests.Size = new System.Drawing.Size(416, 233);
            this.dgv_quests.TabIndex = 20;
            // 
            // form_SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 802);
            this.Controls.Add(this.dgv_quests);
            this.Controls.Add(this.dgv_inventory);
            this.Controls.Add(this.rtb_messages);
            this.Controls.Add(this.rtb_location);
            this.Controls.Add(this.btn_west);
            this.Controls.Add(this.btn_south);
            this.Controls.Add(this.btn_east);
            this.Controls.Add(this.btn_north);
            this.Controls.Add(this.btn_usePotion);
            this.Controls.Add(this.btn_useWeapon);
            this.Controls.Add(this.cbo_potions);
            this.Controls.Add(this.cbo_Weapons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_hitPoints);
            this.Controls.Add(this.lbl_gold);
            this.Controls.Add(this.lbl_exp);
            this.Controls.Add(this.lbl_lvl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_SuperAdventure";
            this.Text = "Super Adventure";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_lvl;
        private System.Windows.Forms.Label lbl_exp;
        private System.Windows.Forms.Label lbl_gold;
        private System.Windows.Forms.Label lbl_hitPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_Weapons;
        private System.Windows.Forms.ComboBox cbo_potions;
        private System.Windows.Forms.Button btn_useWeapon;
        private System.Windows.Forms.Button btn_usePotion;
        private System.Windows.Forms.Button btn_north;
        private System.Windows.Forms.Button btn_east;
        private System.Windows.Forms.Button btn_south;
        private System.Windows.Forms.Button btn_west;
        private System.Windows.Forms.RichTextBox rtb_location;
        private System.Windows.Forms.RichTextBox rtb_messages;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.DataGridView dgv_quests;
    }
}

