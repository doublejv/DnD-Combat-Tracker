namespace DnD_Combat_Tracker
{
    partial class CharacterInfo
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
            this.Lst_Actions = new System.Windows.Forms.ListBox();
            this.Lbl_Actions = new System.Windows.Forms.Label();
            this.Lbl_Ac = new System.Windows.Forms.Label();
            this.Lbl_AcValue = new System.Windows.Forms.Label();
            this.Lbl_Init = new System.Windows.Forms.Label();
            this.Lbl_InitValue = new System.Windows.Forms.Label();
            this.Lbl_HP = new System.Windows.Forms.Label();
            this.Lbl_HPValue = new System.Windows.Forms.Label();
            this.Lbl_Str = new System.Windows.Forms.Label();
            this.Lbl_StrValue = new System.Windows.Forms.Label();
            this.Lbl_Dex = new System.Windows.Forms.Label();
            this.Lbl_DexValue = new System.Windows.Forms.Label();
            this.Lbl_Con = new System.Windows.Forms.Label();
            this.Lbl_ConValue = new System.Windows.Forms.Label();
            this.Lbl_Intel = new System.Windows.Forms.Label();
            this.Lbl_IntelValue = new System.Windows.Forms.Label();
            this.Lbl_Wis = new System.Windows.Forms.Label();
            this.Lbl_Charisma = new System.Windows.Forms.Label();
            this.Lbl_WisValue = new System.Windows.Forms.Label();
            this.Lbl_CharismaValue = new System.Windows.Forms.Label();
            this.Btn_Dmg = new System.Windows.Forms.Button();
            this.Num_Dmg = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Dmg)).BeginInit();
            this.SuspendLayout();
            // 
            // Lst_Actions
            // 
            this.Lst_Actions.FormattingEnabled = true;
            this.Lst_Actions.Location = new System.Drawing.Point(371, 26);
            this.Lst_Actions.Name = "Lst_Actions";
            this.Lst_Actions.Size = new System.Drawing.Size(120, 186);
            this.Lst_Actions.TabIndex = 0;
            this.Lst_Actions.SelectedIndexChanged += new System.EventHandler(this.Lst_Actions_SelectedIndexChanged);
            // 
            // Lbl_Actions
            // 
            this.Lbl_Actions.AutoSize = true;
            this.Lbl_Actions.Location = new System.Drawing.Point(368, 9);
            this.Lbl_Actions.Name = "Lbl_Actions";
            this.Lbl_Actions.Size = new System.Drawing.Size(37, 13);
            this.Lbl_Actions.TabIndex = 1;
            this.Lbl_Actions.Text = "Ações";
            // 
            // Lbl_Ac
            // 
            this.Lbl_Ac.AutoSize = true;
            this.Lbl_Ac.Location = new System.Drawing.Point(12, 26);
            this.Lbl_Ac.Name = "Lbl_Ac";
            this.Lbl_Ac.Size = new System.Drawing.Size(101, 13);
            this.Lbl_Ac.TabIndex = 2;
            this.Lbl_Ac.Text = "Classe de Armadura";
            // 
            // Lbl_AcValue
            // 
            this.Lbl_AcValue.AutoSize = true;
            this.Lbl_AcValue.BackColor = System.Drawing.Color.SteelBlue;
            this.Lbl_AcValue.Location = new System.Drawing.Point(119, 26);
            this.Lbl_AcValue.Name = "Lbl_AcValue";
            this.Lbl_AcValue.Size = new System.Drawing.Size(13, 13);
            this.Lbl_AcValue.TabIndex = 3;
            this.Lbl_AcValue.Text = "0";
            // 
            // Lbl_Init
            // 
            this.Lbl_Init.AutoSize = true;
            this.Lbl_Init.Location = new System.Drawing.Point(64, 65);
            this.Lbl_Init.Name = "Lbl_Init";
            this.Lbl_Init.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Init.TabIndex = 4;
            this.Lbl_Init.Text = "Iniciativa";
            // 
            // Lbl_InitValue
            // 
            this.Lbl_InitValue.AutoSize = true;
            this.Lbl_InitValue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Lbl_InitValue.Location = new System.Drawing.Point(119, 65);
            this.Lbl_InitValue.Name = "Lbl_InitValue";
            this.Lbl_InitValue.Size = new System.Drawing.Size(13, 13);
            this.Lbl_InitValue.TabIndex = 5;
            this.Lbl_InitValue.Text = "0";
            // 
            // Lbl_HP
            // 
            this.Lbl_HP.AutoSize = true;
            this.Lbl_HP.Location = new System.Drawing.Point(183, 26);
            this.Lbl_HP.Name = "Lbl_HP";
            this.Lbl_HP.Size = new System.Drawing.Size(79, 13);
            this.Lbl_HP.TabIndex = 6;
            this.Lbl_HP.Text = "Pontos de Vida";
            // 
            // Lbl_HPValue
            // 
            this.Lbl_HPValue.AutoSize = true;
            this.Lbl_HPValue.BackColor = System.Drawing.Color.Crimson;
            this.Lbl_HPValue.Location = new System.Drawing.Point(268, 26);
            this.Lbl_HPValue.Name = "Lbl_HPValue";
            this.Lbl_HPValue.Size = new System.Drawing.Size(13, 13);
            this.Lbl_HPValue.TabIndex = 7;
            this.Lbl_HPValue.Text = "0";
            // 
            // Lbl_Str
            // 
            this.Lbl_Str.AutoSize = true;
            this.Lbl_Str.Location = new System.Drawing.Point(79, 126);
            this.Lbl_Str.Name = "Lbl_Str";
            this.Lbl_Str.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Str.TabIndex = 8;
            this.Lbl_Str.Text = "Força";
            // 
            // Lbl_StrValue
            // 
            this.Lbl_StrValue.AutoSize = true;
            this.Lbl_StrValue.BackColor = System.Drawing.Color.Gold;
            this.Lbl_StrValue.Location = new System.Drawing.Point(119, 126);
            this.Lbl_StrValue.Name = "Lbl_StrValue";
            this.Lbl_StrValue.Size = new System.Drawing.Size(13, 13);
            this.Lbl_StrValue.TabIndex = 9;
            this.Lbl_StrValue.Text = "0";
            // 
            // Lbl_Dex
            // 
            this.Lbl_Dex.AutoSize = true;
            this.Lbl_Dex.Location = new System.Drawing.Point(64, 159);
            this.Lbl_Dex.Name = "Lbl_Dex";
            this.Lbl_Dex.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Dex.TabIndex = 10;
            this.Lbl_Dex.Text = "Destreza";
            // 
            // Lbl_DexValue
            // 
            this.Lbl_DexValue.AutoSize = true;
            this.Lbl_DexValue.BackColor = System.Drawing.Color.SpringGreen;
            this.Lbl_DexValue.Location = new System.Drawing.Point(119, 159);
            this.Lbl_DexValue.Name = "Lbl_DexValue";
            this.Lbl_DexValue.Size = new System.Drawing.Size(13, 13);
            this.Lbl_DexValue.TabIndex = 11;
            this.Lbl_DexValue.Text = "0";
            // 
            // Lbl_Con
            // 
            this.Lbl_Con.AutoSize = true;
            this.Lbl_Con.Location = new System.Drawing.Point(48, 193);
            this.Lbl_Con.Name = "Lbl_Con";
            this.Lbl_Con.Size = new System.Drawing.Size(65, 13);
            this.Lbl_Con.TabIndex = 12;
            this.Lbl_Con.Text = "Constituição";
            // 
            // Lbl_ConValue
            // 
            this.Lbl_ConValue.AutoSize = true;
            this.Lbl_ConValue.BackColor = System.Drawing.Color.Red;
            this.Lbl_ConValue.Location = new System.Drawing.Point(119, 193);
            this.Lbl_ConValue.Name = "Lbl_ConValue";
            this.Lbl_ConValue.Size = new System.Drawing.Size(13, 13);
            this.Lbl_ConValue.TabIndex = 13;
            this.Lbl_ConValue.Text = "0";
            // 
            // Lbl_Intel
            // 
            this.Lbl_Intel.AutoSize = true;
            this.Lbl_Intel.Location = new System.Drawing.Point(201, 126);
            this.Lbl_Intel.Name = "Lbl_Intel";
            this.Lbl_Intel.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Intel.TabIndex = 14;
            this.Lbl_Intel.Text = "Inteligência";
            // 
            // Lbl_IntelValue
            // 
            this.Lbl_IntelValue.AutoSize = true;
            this.Lbl_IntelValue.BackColor = System.Drawing.Color.DodgerBlue;
            this.Lbl_IntelValue.Location = new System.Drawing.Point(268, 126);
            this.Lbl_IntelValue.Name = "Lbl_IntelValue";
            this.Lbl_IntelValue.Size = new System.Drawing.Size(13, 13);
            this.Lbl_IntelValue.TabIndex = 15;
            this.Lbl_IntelValue.Text = "0";
            // 
            // Lbl_Wis
            // 
            this.Lbl_Wis.AutoSize = true;
            this.Lbl_Wis.Location = new System.Drawing.Point(207, 159);
            this.Lbl_Wis.Name = "Lbl_Wis";
            this.Lbl_Wis.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Wis.TabIndex = 16;
            this.Lbl_Wis.Text = "Sabedoria";
            // 
            // Lbl_Charisma
            // 
            this.Lbl_Charisma.AutoSize = true;
            this.Lbl_Charisma.Location = new System.Drawing.Point(218, 193);
            this.Lbl_Charisma.Name = "Lbl_Charisma";
            this.Lbl_Charisma.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Charisma.TabIndex = 17;
            this.Lbl_Charisma.Text = "Carisma";
            // 
            // Lbl_WisValue
            // 
            this.Lbl_WisValue.AutoSize = true;
            this.Lbl_WisValue.BackColor = System.Drawing.Color.LimeGreen;
            this.Lbl_WisValue.Location = new System.Drawing.Point(268, 159);
            this.Lbl_WisValue.Name = "Lbl_WisValue";
            this.Lbl_WisValue.Size = new System.Drawing.Size(13, 13);
            this.Lbl_WisValue.TabIndex = 18;
            this.Lbl_WisValue.Text = "0";
            // 
            // Lbl_CharismaValue
            // 
            this.Lbl_CharismaValue.AutoSize = true;
            this.Lbl_CharismaValue.BackColor = System.Drawing.Color.MediumOrchid;
            this.Lbl_CharismaValue.Location = new System.Drawing.Point(268, 193);
            this.Lbl_CharismaValue.Name = "Lbl_CharismaValue";
            this.Lbl_CharismaValue.Size = new System.Drawing.Size(13, 13);
            this.Lbl_CharismaValue.TabIndex = 19;
            this.Lbl_CharismaValue.Text = "0";
            // 
            // Btn_Dmg
            // 
            this.Btn_Dmg.Location = new System.Drawing.Point(268, 60);
            this.Btn_Dmg.Name = "Btn_Dmg";
            this.Btn_Dmg.Size = new System.Drawing.Size(75, 20);
            this.Btn_Dmg.TabIndex = 21;
            this.Btn_Dmg.Text = "Danificar";
            this.Btn_Dmg.UseVisualStyleBackColor = true;
            this.Btn_Dmg.Click += new System.EventHandler(this.Btn_Dmg_Click);
            // 
            // Num_Dmg
            // 
            this.Num_Dmg.Location = new System.Drawing.Point(186, 60);
            this.Num_Dmg.Name = "Num_Dmg";
            this.Num_Dmg.Size = new System.Drawing.Size(76, 20);
            this.Num_Dmg.TabIndex = 22;
            // 
            // CharacterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 221);
            this.Controls.Add(this.Num_Dmg);
            this.Controls.Add(this.Btn_Dmg);
            this.Controls.Add(this.Lbl_CharismaValue);
            this.Controls.Add(this.Lbl_WisValue);
            this.Controls.Add(this.Lbl_Charisma);
            this.Controls.Add(this.Lbl_Wis);
            this.Controls.Add(this.Lbl_IntelValue);
            this.Controls.Add(this.Lbl_Intel);
            this.Controls.Add(this.Lbl_ConValue);
            this.Controls.Add(this.Lbl_Con);
            this.Controls.Add(this.Lbl_DexValue);
            this.Controls.Add(this.Lbl_Dex);
            this.Controls.Add(this.Lbl_StrValue);
            this.Controls.Add(this.Lbl_Str);
            this.Controls.Add(this.Lbl_HPValue);
            this.Controls.Add(this.Lbl_HP);
            this.Controls.Add(this.Lbl_InitValue);
            this.Controls.Add(this.Lbl_Init);
            this.Controls.Add(this.Lbl_AcValue);
            this.Controls.Add(this.Lbl_Ac);
            this.Controls.Add(this.Lbl_Actions);
            this.Controls.Add(this.Lst_Actions);
            this.Name = "CharacterInfo";
            this.Text = "CharacterInfo";
            this.Load += new System.EventHandler(this.CharacterInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Num_Dmg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_Actions;
        private System.Windows.Forms.Label Lbl_Actions;
        private System.Windows.Forms.Label Lbl_Ac;
        private System.Windows.Forms.Label Lbl_AcValue;
        private System.Windows.Forms.Label Lbl_Init;
        private System.Windows.Forms.Label Lbl_InitValue;
        private System.Windows.Forms.Label Lbl_HP;
        private System.Windows.Forms.Label Lbl_HPValue;
        private System.Windows.Forms.Label Lbl_Str;
        private System.Windows.Forms.Label Lbl_StrValue;
        private System.Windows.Forms.Label Lbl_Dex;
        private System.Windows.Forms.Label Lbl_DexValue;
        private System.Windows.Forms.Label Lbl_Con;
        private System.Windows.Forms.Label Lbl_ConValue;
        private System.Windows.Forms.Label Lbl_Intel;
        private System.Windows.Forms.Label Lbl_IntelValue;
        private System.Windows.Forms.Label Lbl_Wis;
        private System.Windows.Forms.Label Lbl_Charisma;
        private System.Windows.Forms.Label Lbl_WisValue;
        private System.Windows.Forms.Label Lbl_CharismaValue;
        private System.Windows.Forms.Button Btn_Dmg;
        private System.Windows.Forms.NumericUpDown Num_Dmg;
    }
}