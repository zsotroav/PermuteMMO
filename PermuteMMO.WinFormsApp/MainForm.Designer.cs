﻿namespace PermuteMMO.WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkWantAlpha = new System.Windows.Forms.CheckBox();
            this.checkWantShiny = new System.Windows.Forms.CheckBox();
            this.buttonJSON = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWarn = new System.Windows.Forms.TextBox();
            this.buttonPermutate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxBonus = new System.Windows.Forms.TextBox();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxAlpha = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericSpawns2 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSpecies2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericSpawns = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSpecies = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLoc = new System.Windows.Forms.ComboBox();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.checkBoxMMO = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelFound = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpawns2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpawns)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.buttonJSON);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxWarn);
            this.panel1.Controls.Add(this.buttonPermutate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBoxLoc);
            this.panel1.Controls.Add(this.textBoxSeed);
            this.panel1.Controls.Add(this.checkBoxMMO);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 195);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.checkWantAlpha);
            this.panel5.Controls.Add(this.checkWantShiny);
            this.panel5.Location = new System.Drawing.Point(3, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(508, 31);
            this.panel5.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Wanted pokémon";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Advanced...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkWantAlpha
            // 
            this.checkWantAlpha.AutoSize = true;
            this.checkWantAlpha.Location = new System.Drawing.Point(180, 7);
            this.checkWantAlpha.Name = "checkWantAlpha";
            this.checkWantAlpha.Size = new System.Drawing.Size(57, 19);
            this.checkWantAlpha.TabIndex = 12;
            this.checkWantAlpha.Text = "Alpha";
            this.checkWantAlpha.UseVisualStyleBackColor = true;
            this.checkWantAlpha.CheckedChanged += new System.EventHandler(this.checkWant_CheckedChanged);
            // 
            // checkWantShiny
            // 
            this.checkWantShiny.AutoSize = true;
            this.checkWantShiny.Checked = true;
            this.checkWantShiny.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWantShiny.Location = new System.Drawing.Point(119, 7);
            this.checkWantShiny.Name = "checkWantShiny";
            this.checkWantShiny.Size = new System.Drawing.Size(55, 19);
            this.checkWantShiny.TabIndex = 11;
            this.checkWantShiny.Text = "Shiny";
            this.checkWantShiny.UseVisualStyleBackColor = true;
            this.checkWantShiny.CheckedChanged += new System.EventHandler(this.checkWant_CheckedChanged);
            // 
            // buttonJSON
            // 
            this.buttonJSON.Location = new System.Drawing.Point(517, 125);
            this.buttonJSON.Name = "buttonJSON";
            this.buttonJSON.Size = new System.Drawing.Size(122, 23);
            this.buttonJSON.TabIndex = 1;
            this.buttonJSON.Text = "Use JSON data";
            this.buttonJSON.UseVisualStyleBackColor = true;
            this.buttonJSON.Click += new System.EventHandler(this.buttonJSON_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Seed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Outbreak location:";
            // 
            // textBoxWarn
            // 
            this.textBoxWarn.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxWarn.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxWarn.Location = new System.Drawing.Point(517, 3);
            this.textBoxWarn.Multiline = true;
            this.textBoxWarn.Name = "textBoxWarn";
            this.textBoxWarn.ReadOnly = true;
            this.textBoxWarn.Size = new System.Drawing.Size(122, 89);
            this.textBoxWarn.TabIndex = 9;
            this.textBoxWarn.Text = "MMOs currently not fully operational in GUI mode. Use the website to get the spaw" +
    "n tables.";
            this.textBoxWarn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPermutate
            // 
            this.buttonPermutate.Location = new System.Drawing.Point(517, 160);
            this.buttonPermutate.Name = "buttonPermutate";
            this.buttonPermutate.Size = new System.Drawing.Size(122, 23);
            this.buttonPermutate.TabIndex = 6;
            this.buttonPermutate.Text = "Permutate!";
            this.buttonPermutate.UseVisualStyleBackColor = true;
            this.buttonPermutate.Click += new System.EventHandler(this.buttonPermutate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.textBoxBonus);
            this.panel3.Controls.Add(this.textBoxBase);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.checkBoxAlpha);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.numericSpawns2);
            this.panel3.Controls.Add(this.comboBoxSpecies2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(260, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 123);
            this.panel3.TabIndex = 5;
            // 
            // textBoxBonus
            // 
            this.textBoxBonus.Enabled = false;
            this.textBoxBonus.Location = new System.Drawing.Point(3, 68);
            this.textBoxBonus.Name = "textBoxBonus";
            this.textBoxBonus.PlaceholderText = "Bonus Table";
            this.textBoxBonus.Size = new System.Drawing.Size(245, 23);
            this.textBoxBonus.TabIndex = 11;
            // 
            // textBoxBase
            // 
            this.textBoxBase.Enabled = false;
            this.textBoxBase.Location = new System.Drawing.Point(3, 39);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.PlaceholderText = "Base Table";
            this.textBoxBase.Size = new System.Drawing.Size(245, 23);
            this.textBoxBase.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alphas only?";
            // 
            // checkBoxAlpha
            // 
            this.checkBoxAlpha.AutoSize = true;
            this.checkBoxAlpha.Enabled = false;
            this.checkBoxAlpha.Location = new System.Drawing.Point(119, 43);
            this.checkBoxAlpha.Name = "checkBoxAlpha";
            this.checkBoxAlpha.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlpha.TabIndex = 5;
            this.checkBoxAlpha.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.Location = new System.Drawing.Point(3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(245, 23);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Second wave";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of spawns:\r\n";
            // 
            // numericSpawns2
            // 
            this.numericSpawns2.Enabled = false;
            this.numericSpawns2.Location = new System.Drawing.Point(119, 97);
            this.numericSpawns2.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericSpawns2.Name = "numericSpawns2";
            this.numericSpawns2.Size = new System.Drawing.Size(129, 23);
            this.numericSpawns2.TabIndex = 2;
            // 
            // comboBoxSpecies2
            // 
            this.comboBoxSpecies2.Enabled = false;
            this.comboBoxSpecies2.FormattingEnabled = true;
            this.comboBoxSpecies2.Location = new System.Drawing.Point(119, 68);
            this.comboBoxSpecies2.Name = "comboBoxSpecies2";
            this.comboBoxSpecies2.Size = new System.Drawing.Size(129, 23);
            this.comboBoxSpecies2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pokémon species:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericSpawns);
            this.panel2.Controls.Add(this.comboBoxSpecies);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 90);
            this.panel2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(245, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "First wave";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of spawns:\r\n";
            // 
            // numericSpawns
            // 
            this.numericSpawns.Location = new System.Drawing.Point(119, 64);
            this.numericSpawns.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericSpawns.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericSpawns.Name = "numericSpawns";
            this.numericSpawns.Size = new System.Drawing.Size(129, 23);
            this.numericSpawns.TabIndex = 2;
            this.numericSpawns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // comboBoxSpecies
            // 
            this.comboBoxSpecies.DisplayMember = "Text";
            this.comboBoxSpecies.FormattingEnabled = true;
            this.comboBoxSpecies.Location = new System.Drawing.Point(119, 35);
            this.comboBoxSpecies.Name = "comboBoxSpecies";
            this.comboBoxSpecies.Size = new System.Drawing.Size(129, 23);
            this.comboBoxSpecies.TabIndex = 1;
            this.comboBoxSpecies.ValueMember = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pokémon species:";
            // 
            // comboBoxLoc
            // 
            this.comboBoxLoc.Enabled = false;
            this.comboBoxLoc.FormattingEnabled = true;
            this.comboBoxLoc.Items.AddRange(new object[] {
            "Obsidian Fieldlands",
            "Crimson Mirelands",
            "Colbalt Coastlands",
            "Coronet Highlands",
            "Alabaster Icelands"});
            this.comboBoxLoc.Location = new System.Drawing.Point(122, 32);
            this.comboBoxLoc.Name = "comboBoxLoc";
            this.comboBoxLoc.Size = new System.Drawing.Size(129, 23);
            this.comboBoxLoc.TabIndex = 2;
            this.comboBoxLoc.Text = "Obsidian Fieldlands";
            this.comboBoxLoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoc_SelectedIndexChanged);
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(47, 3);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.PlaceholderText = "16045686375800883966";
            this.textBoxSeed.Size = new System.Drawing.Size(204, 23);
            this.textBoxSeed.TabIndex = 1;
            // 
            // checkBoxMMO
            // 
            this.checkBoxMMO.AutoSize = true;
            this.checkBoxMMO.Location = new System.Drawing.Point(272, 10);
            this.checkBoxMMO.Name = "checkBoxMMO";
            this.checkBoxMMO.Size = new System.Drawing.Size(226, 19);
            this.checkBoxMMO.TabIndex = 0;
            this.checkBoxMMO.Text = "Massive Mass Outbreak (MMO) mode";
            this.checkBoxMMO.UseVisualStyleBackColor = true;
            this.checkBoxMMO.CheckedChanged += new System.EventHandler(this.checkBoxMMO_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "json";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.panelFound);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Location = new System.Drawing.Point(12, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(644, 225);
            this.panel4.TabIndex = 1;
            // 
            // panelFound
            // 
            this.panelFound.AutoScroll = true;
            this.panelFound.BackColor = System.Drawing.SystemColors.Control;
            this.panelFound.Location = new System.Drawing.Point(3, 32);
            this.panelFound.Name = "panelFound";
            this.panelFound.Size = new System.Drawing.Size(638, 190);
            this.panelFound.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(638, 23);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Found Pokémon:";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PermuteMMO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpawns2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpawns)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxLoc;
        private TextBox textBoxSeed;
        private CheckBox checkBoxMMO;
        private Panel panel2;
        private TextBox textBox2;
        private Label label2;
        private NumericUpDown numericSpawns;
        private ComboBox comboBoxSpecies;
        private Label label1;
        private Panel panel3;
        private Label label5;
        private CheckBox checkBoxAlpha;
        private TextBox textBox3;
        private Label label3;
        private NumericUpDown numericSpawns2;
        private ComboBox comboBoxSpecies2;
        private Label label4;
        private Button buttonPermutate;
        private Label label7;
        private Label label6;
        private TextBox textBoxWarn;
        private TextBox textBoxBonus;
        private TextBox textBoxBase;
        private Button buttonJSON;
        private OpenFileDialog openFileDialog1;
        private Panel panel4;
        private CheckBox checkWantAlpha;
        private CheckBox checkWantShiny;
        private Button button1;
        private Panel panel5;
        private TextBox textBox1;
        private TextBox textBox4;
        private Panel panelFound;
    }
}