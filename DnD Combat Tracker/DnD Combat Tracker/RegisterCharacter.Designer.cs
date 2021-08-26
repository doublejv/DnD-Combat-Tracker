namespace DnD_Combat_Tracker
{
    partial class RegisterCharacter
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
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Lbl_HitDie = new System.Windows.Forms.Label();
            this.Num_HitDie = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Ac = new System.Windows.Forms.Label();
            this.Num_Ac = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Init = new System.Windows.Forms.Label();
            this.Num_Init = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Proficiency = new System.Windows.Forms.Label();
            this.Num_Proficiency = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Str = new System.Windows.Forms.Label();
            this.Num_Str = new System.Windows.Forms.NumericUpDown();
            this.Num_Dex = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Dex = new System.Windows.Forms.Label();
            this.Lbl_Con = new System.Windows.Forms.Label();
            this.Num_Con = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Intel = new System.Windows.Forms.Label();
            this.Num_Intel = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Wis = new System.Windows.Forms.Label();
            this.Num_Wis = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Charisma = new System.Windows.Forms.Label();
            this.Num_Charisma = new System.Windows.Forms.NumericUpDown();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Num_NumHitDie = new System.Windows.Forms.NumericUpDown();
            this.Lbl_NumHitDie = new System.Windows.Forms.Label();
            this.Lst_Actions = new System.Windows.Forms.ListBox();
            this.Lbl_Actions = new System.Windows.Forms.Label();
            this.Btn_AddAction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Num_HitDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Ac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Init)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Proficiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Str)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Dex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Con)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Intel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Wis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Charisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_NumHitDie)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(115, 13);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Nome do Personagem:";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(15, 26);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(200, 20);
            this.Txt_Name.TabIndex = 1;
            // 
            // Lbl_HitDie
            // 
            this.Lbl_HitDie.AutoSize = true;
            this.Lbl_HitDie.Location = new System.Drawing.Point(223, 149);
            this.Lbl_HitDie.Name = "Lbl_HitDie";
            this.Lbl_HitDie.Size = new System.Drawing.Size(72, 13);
            this.Lbl_HitDie.TabIndex = 2;
            this.Lbl_HitDie.Text = "Dado de Vida";
            // 
            // Num_HitDie
            // 
            this.Num_HitDie.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Num_HitDie.Location = new System.Drawing.Point(226, 165);
            this.Num_HitDie.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Num_HitDie.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Num_HitDie.Name = "Num_HitDie";
            this.Num_HitDie.Size = new System.Drawing.Size(69, 20);
            this.Num_HitDie.TabIndex = 3;
            this.Num_HitDie.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // Lbl_Ac
            // 
            this.Lbl_Ac.AutoSize = true;
            this.Lbl_Ac.Location = new System.Drawing.Point(194, 79);
            this.Lbl_Ac.Name = "Lbl_Ac";
            this.Lbl_Ac.Size = new System.Drawing.Size(101, 13);
            this.Lbl_Ac.TabIndex = 4;
            this.Lbl_Ac.Text = "Classe de Armadura";
            // 
            // Num_Ac
            // 
            this.Num_Ac.Location = new System.Drawing.Point(197, 95);
            this.Num_Ac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Ac.Name = "Num_Ac";
            this.Num_Ac.Size = new System.Drawing.Size(98, 20);
            this.Num_Ac.TabIndex = 5;
            this.Num_Ac.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_Init
            // 
            this.Lbl_Init.AutoSize = true;
            this.Lbl_Init.Location = new System.Drawing.Point(12, 149);
            this.Lbl_Init.Name = "Lbl_Init";
            this.Lbl_Init.Size = new System.Drawing.Size(97, 13);
            this.Lbl_Init.TabIndex = 6;
            this.Lbl_Init.Text = "Bônus de Iniciativa";
            // 
            // Num_Init
            // 
            this.Num_Init.Location = new System.Drawing.Point(15, 165);
            this.Num_Init.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Num_Init.Name = "Num_Init";
            this.Num_Init.Size = new System.Drawing.Size(94, 20);
            this.Num_Init.TabIndex = 7;
            // 
            // Lbl_Proficiency
            // 
            this.Lbl_Proficiency.AutoSize = true;
            this.Lbl_Proficiency.Location = new System.Drawing.Point(12, 79);
            this.Lbl_Proficiency.Name = "Lbl_Proficiency";
            this.Lbl_Proficiency.Size = new System.Drawing.Size(110, 13);
            this.Lbl_Proficiency.TabIndex = 8;
            this.Lbl_Proficiency.Text = "Bônus de Proficiência";
            // 
            // Num_Proficiency
            // 
            this.Num_Proficiency.Location = new System.Drawing.Point(15, 95);
            this.Num_Proficiency.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Num_Proficiency.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Num_Proficiency.Name = "Num_Proficiency";
            this.Num_Proficiency.Size = new System.Drawing.Size(107, 20);
            this.Num_Proficiency.TabIndex = 9;
            this.Num_Proficiency.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Lbl_Str
            // 
            this.Lbl_Str.AutoSize = true;
            this.Lbl_Str.Location = new System.Drawing.Point(12, 229);
            this.Lbl_Str.Name = "Lbl_Str";
            this.Lbl_Str.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Str.TabIndex = 10;
            this.Lbl_Str.Text = "Força";
            // 
            // Num_Str
            // 
            this.Num_Str.Location = new System.Drawing.Point(15, 245);
            this.Num_Str.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Num_Str.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Str.Name = "Num_Str";
            this.Num_Str.Size = new System.Drawing.Size(69, 20);
            this.Num_Str.TabIndex = 11;
            this.Num_Str.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Num_Dex
            // 
            this.Num_Dex.Location = new System.Drawing.Point(15, 301);
            this.Num_Dex.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Num_Dex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Dex.Name = "Num_Dex";
            this.Num_Dex.Size = new System.Drawing.Size(69, 20);
            this.Num_Dex.TabIndex = 12;
            this.Num_Dex.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Lbl_Dex
            // 
            this.Lbl_Dex.AutoSize = true;
            this.Lbl_Dex.Location = new System.Drawing.Point(12, 285);
            this.Lbl_Dex.Name = "Lbl_Dex";
            this.Lbl_Dex.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Dex.TabIndex = 13;
            this.Lbl_Dex.Text = "Destreza";
            // 
            // Lbl_Con
            // 
            this.Lbl_Con.AutoSize = true;
            this.Lbl_Con.Location = new System.Drawing.Point(12, 344);
            this.Lbl_Con.Name = "Lbl_Con";
            this.Lbl_Con.Size = new System.Drawing.Size(65, 13);
            this.Lbl_Con.TabIndex = 15;
            this.Lbl_Con.Text = "Constituição";
            // 
            // Num_Con
            // 
            this.Num_Con.Location = new System.Drawing.Point(15, 360);
            this.Num_Con.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Num_Con.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Con.Name = "Num_Con";
            this.Num_Con.Size = new System.Drawing.Size(69, 20);
            this.Num_Con.TabIndex = 14;
            this.Num_Con.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Lbl_Intel
            // 
            this.Lbl_Intel.AutoSize = true;
            this.Lbl_Intel.Location = new System.Drawing.Point(144, 229);
            this.Lbl_Intel.Name = "Lbl_Intel";
            this.Lbl_Intel.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Intel.TabIndex = 17;
            this.Lbl_Intel.Text = "Inteligência";
            // 
            // Num_Intel
            // 
            this.Num_Intel.Location = new System.Drawing.Point(147, 245);
            this.Num_Intel.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Num_Intel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Intel.Name = "Num_Intel";
            this.Num_Intel.Size = new System.Drawing.Size(69, 20);
            this.Num_Intel.TabIndex = 16;
            this.Num_Intel.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Lbl_Wis
            // 
            this.Lbl_Wis.AutoSize = true;
            this.Lbl_Wis.Location = new System.Drawing.Point(144, 285);
            this.Lbl_Wis.Name = "Lbl_Wis";
            this.Lbl_Wis.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Wis.TabIndex = 19;
            this.Lbl_Wis.Text = "Sabedoria";
            // 
            // Num_Wis
            // 
            this.Num_Wis.Location = new System.Drawing.Point(147, 301);
            this.Num_Wis.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Num_Wis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Wis.Name = "Num_Wis";
            this.Num_Wis.Size = new System.Drawing.Size(69, 20);
            this.Num_Wis.TabIndex = 18;
            this.Num_Wis.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Lbl_Charisma
            // 
            this.Lbl_Charisma.AutoSize = true;
            this.Lbl_Charisma.Location = new System.Drawing.Point(144, 344);
            this.Lbl_Charisma.Name = "Lbl_Charisma";
            this.Lbl_Charisma.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Charisma.TabIndex = 21;
            this.Lbl_Charisma.Text = "Carisma";
            // 
            // Num_Charisma
            // 
            this.Num_Charisma.Location = new System.Drawing.Point(147, 360);
            this.Num_Charisma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Num_Charisma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Charisma.Name = "Num_Charisma";
            this.Num_Charisma.Size = new System.Drawing.Size(69, 20);
            this.Num_Charisma.TabIndex = 20;
            this.Num_Charisma.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(15, 408);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(201, 30);
            this.Btn_Register.TabIndex = 22;
            this.Btn_Register.Text = "Registrar Personagem";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Num_NumHitDie
            // 
            this.Num_NumHitDie.Location = new System.Drawing.Point(148, 165);
            this.Num_NumHitDie.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Num_NumHitDie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_NumHitDie.Name = "Num_NumHitDie";
            this.Num_NumHitDie.Size = new System.Drawing.Size(69, 20);
            this.Num_NumHitDie.TabIndex = 24;
            this.Num_NumHitDie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_NumHitDie
            // 
            this.Lbl_NumHitDie.AutoSize = true;
            this.Lbl_NumHitDie.Location = new System.Drawing.Point(145, 149);
            this.Lbl_NumHitDie.Name = "Lbl_NumHitDie";
            this.Lbl_NumHitDie.Size = new System.Drawing.Size(62, 13);
            this.Lbl_NumHitDie.TabIndex = 23;
            this.Lbl_NumHitDie.Text = "Quantidade";
            // 
            // Lst_Actions
            // 
            this.Lst_Actions.FormattingEnabled = true;
            this.Lst_Actions.Location = new System.Drawing.Point(346, 30);
            this.Lst_Actions.Name = "Lst_Actions";
            this.Lst_Actions.Size = new System.Drawing.Size(148, 368);
            this.Lst_Actions.TabIndex = 25;
            // 
            // Lbl_Actions
            // 
            this.Lbl_Actions.AutoSize = true;
            this.Lbl_Actions.Location = new System.Drawing.Point(343, 13);
            this.Lbl_Actions.Name = "Lbl_Actions";
            this.Lbl_Actions.Size = new System.Drawing.Size(37, 13);
            this.Lbl_Actions.TabIndex = 26;
            this.Lbl_Actions.Text = "Ações";
            // 
            // Btn_AddAction
            // 
            this.Btn_AddAction.Location = new System.Drawing.Point(346, 404);
            this.Btn_AddAction.Name = "Btn_AddAction";
            this.Btn_AddAction.Size = new System.Drawing.Size(148, 23);
            this.Btn_AddAction.TabIndex = 27;
            this.Btn_AddAction.Text = "Adicionar Ação";
            this.Btn_AddAction.UseVisualStyleBackColor = true;
            this.Btn_AddAction.Click += new System.EventHandler(this.Btn_AddAction_Click);
            // 
            // RegisterCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.Btn_AddAction);
            this.Controls.Add(this.Lbl_Actions);
            this.Controls.Add(this.Lst_Actions);
            this.Controls.Add(this.Num_NumHitDie);
            this.Controls.Add(this.Lbl_NumHitDie);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Lbl_Charisma);
            this.Controls.Add(this.Num_Charisma);
            this.Controls.Add(this.Lbl_Wis);
            this.Controls.Add(this.Num_Wis);
            this.Controls.Add(this.Lbl_Intel);
            this.Controls.Add(this.Num_Intel);
            this.Controls.Add(this.Lbl_Con);
            this.Controls.Add(this.Num_Con);
            this.Controls.Add(this.Lbl_Dex);
            this.Controls.Add(this.Num_Dex);
            this.Controls.Add(this.Num_Str);
            this.Controls.Add(this.Lbl_Str);
            this.Controls.Add(this.Num_Proficiency);
            this.Controls.Add(this.Lbl_Proficiency);
            this.Controls.Add(this.Num_Init);
            this.Controls.Add(this.Lbl_Init);
            this.Controls.Add(this.Num_Ac);
            this.Controls.Add(this.Lbl_Ac);
            this.Controls.Add(this.Num_HitDie);
            this.Controls.Add(this.Lbl_HitDie);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_Name);
            this.Name = "RegisterCharacter";
            this.Text = "Registrar Personagem";
            ((System.ComponentModel.ISupportInitialize)(this.Num_HitDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Ac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Init)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Proficiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Str)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Dex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Con)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Intel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Wis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Charisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_NumHitDie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label Lbl_HitDie;
        private System.Windows.Forms.NumericUpDown Num_HitDie;
        private System.Windows.Forms.Label Lbl_Ac;
        private System.Windows.Forms.NumericUpDown Num_Ac;
        private System.Windows.Forms.Label Lbl_Init;
        private System.Windows.Forms.NumericUpDown Num_Init;
        private System.Windows.Forms.Label Lbl_Proficiency;
        private System.Windows.Forms.NumericUpDown Num_Proficiency;
        private System.Windows.Forms.Label Lbl_Str;
        private System.Windows.Forms.NumericUpDown Num_Str;
        private System.Windows.Forms.NumericUpDown Num_Dex;
        private System.Windows.Forms.Label Lbl_Dex;
        private System.Windows.Forms.Label Lbl_Con;
        private System.Windows.Forms.NumericUpDown Num_Con;
        private System.Windows.Forms.Label Lbl_Intel;
        private System.Windows.Forms.NumericUpDown Num_Intel;
        private System.Windows.Forms.Label Lbl_Wis;
        private System.Windows.Forms.NumericUpDown Num_Wis;
        private System.Windows.Forms.Label Lbl_Charisma;
        private System.Windows.Forms.NumericUpDown Num_Charisma;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.NumericUpDown Num_NumHitDie;
        private System.Windows.Forms.Label Lbl_NumHitDie;
        private System.Windows.Forms.ListBox Lst_Actions;
        private System.Windows.Forms.Label Lbl_Actions;
        private System.Windows.Forms.Button Btn_AddAction;
    }
}