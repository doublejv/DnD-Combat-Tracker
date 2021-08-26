namespace DnD_Combat_Tracker
{
    partial class AddAction
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
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Num_HitBonus = new System.Windows.Forms.NumericUpDown();
            this.Lbl_HitBonus = new System.Windows.Forms.Label();
            this.Num_NumDmgDie = new System.Windows.Forms.NumericUpDown();
            this.Lbl_NumDmgDie = new System.Windows.Forms.Label();
            this.Num_DmgDie = new System.Windows.Forms.NumericUpDown();
            this.Lbl_DmgDie = new System.Windows.Forms.Label();
            this.Num_DmgBonus = new System.Windows.Forms.NumericUpDown();
            this.Lbl_DmgBonus = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Num_HitBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_NumDmgDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_DmgDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_DmgBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(15, 26);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(200, 20);
            this.Txt_Name.TabIndex = 3;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(81, 13);
            this.Lbl_Name.TabIndex = 2;
            this.Lbl_Name.Text = "Nome da Ação:";
            // 
            // Num_HitBonus
            // 
            this.Num_HitBonus.Location = new System.Drawing.Point(15, 95);
            this.Num_HitBonus.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Num_HitBonus.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.Num_HitBonus.Name = "Num_HitBonus";
            this.Num_HitBonus.Size = new System.Drawing.Size(107, 20);
            this.Num_HitBonus.TabIndex = 11;
            // 
            // Lbl_HitBonus
            // 
            this.Lbl_HitBonus.AutoSize = true;
            this.Lbl_HitBonus.Location = new System.Drawing.Point(12, 78);
            this.Lbl_HitBonus.Name = "Lbl_HitBonus";
            this.Lbl_HitBonus.Size = new System.Drawing.Size(86, 13);
            this.Lbl_HitBonus.TabIndex = 10;
            this.Lbl_HitBonus.Text = "Bônus de Acerto";
            // 
            // Num_NumDmgDie
            // 
            this.Num_NumDmgDie.Location = new System.Drawing.Point(15, 165);
            this.Num_NumDmgDie.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Num_NumDmgDie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_NumDmgDie.Name = "Num_NumDmgDie";
            this.Num_NumDmgDie.Size = new System.Drawing.Size(69, 20);
            this.Num_NumDmgDie.TabIndex = 28;
            this.Num_NumDmgDie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_NumDmgDie
            // 
            this.Lbl_NumDmgDie.AutoSize = true;
            this.Lbl_NumDmgDie.Location = new System.Drawing.Point(12, 149);
            this.Lbl_NumDmgDie.Name = "Lbl_NumDmgDie";
            this.Lbl_NumDmgDie.Size = new System.Drawing.Size(62, 13);
            this.Lbl_NumDmgDie.TabIndex = 27;
            this.Lbl_NumDmgDie.Text = "Quantidade";
            // 
            // Num_DmgDie
            // 
            this.Num_DmgDie.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Num_DmgDie.Location = new System.Drawing.Point(93, 165);
            this.Num_DmgDie.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Num_DmgDie.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Num_DmgDie.Name = "Num_DmgDie";
            this.Num_DmgDie.Size = new System.Drawing.Size(69, 20);
            this.Num_DmgDie.TabIndex = 26;
            this.Num_DmgDie.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // Lbl_DmgDie
            // 
            this.Lbl_DmgDie.AutoSize = true;
            this.Lbl_DmgDie.Location = new System.Drawing.Point(90, 149);
            this.Lbl_DmgDie.Name = "Lbl_DmgDie";
            this.Lbl_DmgDie.Size = new System.Drawing.Size(77, 13);
            this.Lbl_DmgDie.TabIndex = 25;
            this.Lbl_DmgDie.Text = "Dado de Dano";
            // 
            // Num_DmgBonus
            // 
            this.Num_DmgBonus.Location = new System.Drawing.Point(171, 165);
            this.Num_DmgBonus.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Num_DmgBonus.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.Num_DmgBonus.Name = "Num_DmgBonus";
            this.Num_DmgBonus.Size = new System.Drawing.Size(69, 20);
            this.Num_DmgBonus.TabIndex = 29;
            // 
            // Lbl_DmgBonus
            // 
            this.Lbl_DmgBonus.AutoSize = true;
            this.Lbl_DmgBonus.Location = new System.Drawing.Point(168, 149);
            this.Lbl_DmgBonus.Name = "Lbl_DmgBonus";
            this.Lbl_DmgBonus.Size = new System.Drawing.Size(81, 13);
            this.Lbl_DmgBonus.TabIndex = 30;
            this.Lbl_DmgBonus.Text = "Bônus de Dano";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(15, 222);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(225, 23);
            this.Btn_Add.TabIndex = 31;
            this.Btn_Add.Text = "Adicionar Ação";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // AddAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 257);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Lbl_DmgBonus);
            this.Controls.Add(this.Num_DmgBonus);
            this.Controls.Add(this.Num_NumDmgDie);
            this.Controls.Add(this.Lbl_NumDmgDie);
            this.Controls.Add(this.Num_DmgDie);
            this.Controls.Add(this.Lbl_DmgDie);
            this.Controls.Add(this.Num_HitBonus);
            this.Controls.Add(this.Lbl_HitBonus);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_Name);
            this.Name = "AddAction";
            this.Text = "Adicionar Ação";
            ((System.ComponentModel.ISupportInitialize)(this.Num_HitBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_NumDmgDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_DmgDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_DmgBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.NumericUpDown Num_HitBonus;
        private System.Windows.Forms.Label Lbl_HitBonus;
        private System.Windows.Forms.NumericUpDown Num_NumDmgDie;
        private System.Windows.Forms.Label Lbl_NumDmgDie;
        private System.Windows.Forms.NumericUpDown Num_DmgDie;
        private System.Windows.Forms.Label Lbl_DmgDie;
        private System.Windows.Forms.NumericUpDown Num_DmgBonus;
        private System.Windows.Forms.Label Lbl_DmgBonus;
        private System.Windows.Forms.Button Btn_Add;
    }
}