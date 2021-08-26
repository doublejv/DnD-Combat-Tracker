namespace DnD_Combat_Tracker
{
    partial class CombatTracker
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
            this.Lst_Combatants = new System.Windows.Forms.ListBox();
            this.Lbl_Combatants = new System.Windows.Forms.Label();
            this.Btn_AddCombatant = new System.Windows.Forms.Button();
            this.Btn_RegisterCharacter = new System.Windows.Forms.Button();
            this.Chk_AvgHP = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lst_Combatants
            // 
            this.Lst_Combatants.FormattingEnabled = true;
            this.Lst_Combatants.Location = new System.Drawing.Point(12, 28);
            this.Lst_Combatants.Name = "Lst_Combatants";
            this.Lst_Combatants.Size = new System.Drawing.Size(242, 407);
            this.Lst_Combatants.TabIndex = 0;
            this.Lst_Combatants.SelectedIndexChanged += new System.EventHandler(this.Lst_Combatants_SelectedIndexChanged);
            // 
            // Lbl_Combatants
            // 
            this.Lbl_Combatants.AutoSize = true;
            this.Lbl_Combatants.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Combatants.Name = "Lbl_Combatants";
            this.Lbl_Combatants.Size = new System.Drawing.Size(69, 13);
            this.Lbl_Combatants.TabIndex = 1;
            this.Lbl_Combatants.Text = "Combatentes";
            // 
            // Btn_AddCombatant
            // 
            this.Btn_AddCombatant.Location = new System.Drawing.Point(260, 382);
            this.Btn_AddCombatant.Name = "Btn_AddCombatant";
            this.Btn_AddCombatant.Size = new System.Drawing.Size(136, 23);
            this.Btn_AddCombatant.TabIndex = 2;
            this.Btn_AddCombatant.Text = "Adicionar Combatente";
            this.Btn_AddCombatant.UseVisualStyleBackColor = true;
            this.Btn_AddCombatant.Click += new System.EventHandler(this.Btn_AddCombatant_Click);
            // 
            // Btn_RegisterCharacter
            // 
            this.Btn_RegisterCharacter.Location = new System.Drawing.Point(260, 411);
            this.Btn_RegisterCharacter.Name = "Btn_RegisterCharacter";
            this.Btn_RegisterCharacter.Size = new System.Drawing.Size(136, 23);
            this.Btn_RegisterCharacter.TabIndex = 3;
            this.Btn_RegisterCharacter.Text = "Registrar Personagem";
            this.Btn_RegisterCharacter.UseVisualStyleBackColor = true;
            this.Btn_RegisterCharacter.Click += new System.EventHandler(this.Btn_RegisterCharacter_Click);
            // 
            // Chk_AvgHP
            // 
            this.Chk_AvgHP.AutoSize = true;
            this.Chk_AvgHP.Location = new System.Drawing.Point(261, 359);
            this.Chk_AvgHP.Name = "Chk_AvgHP";
            this.Chk_AvgHP.Size = new System.Drawing.Size(78, 17);
            this.Chk_AvgHP.TabIndex = 4;
            this.Chk_AvgHP.Text = "PV Médio?";
            this.Chk_AvgHP.UseVisualStyleBackColor = true;
            // 
            // CombatTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.Chk_AvgHP);
            this.Controls.Add(this.Btn_RegisterCharacter);
            this.Controls.Add(this.Btn_AddCombatant);
            this.Controls.Add(this.Lbl_Combatants);
            this.Controls.Add(this.Lst_Combatants);
            this.Name = "CombatTracker";
            this.Text = "Rastreador de Combate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_Combatants;
        private System.Windows.Forms.Label Lbl_Combatants;
        private System.Windows.Forms.Button Btn_AddCombatant;
        private System.Windows.Forms.Button Btn_RegisterCharacter;
        private System.Windows.Forms.CheckBox Chk_AvgHP;
    }
}