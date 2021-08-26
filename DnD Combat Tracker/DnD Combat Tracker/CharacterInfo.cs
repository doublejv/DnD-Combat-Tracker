using DnD_Combat_Tracker.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Combat_Tracker
{
    public partial class CharacterInfo : Form
    {
        public Character character;
        public Domain.Action chosenAction;

        public CharacterInfo()
        {
            InitializeComponent();
        }

        private void CharacterInfo_Load(object sender, EventArgs e)
        {
            this.Text = character.name;
            Lbl_AcValue.Text = character.ac.ToString();
            Lbl_HPValue.Text = character.hp.ToString();
            Lbl_InitValue.Text = character.init.ToString();
            Lbl_StrValue.Text = character.str.ToString();
            Lbl_DexValue.Text = character.dex.ToString();
            Lbl_ConValue.Text = character.con.ToString();
            Lbl_IntelValue.Text = character.intel.ToString();
            Lbl_WisValue.Text = character.wis.ToString();
            Lbl_CharismaValue.Text = character.charisma.ToString();

            for(int i = 0; i < character.actions.Count; i++)
            {
                Lst_Actions.Items.Add(character.actions[i].name);
            }
        }

        private void Btn_Dmg_Click(object sender, EventArgs e)
        {
            character.hp -= Decimal.ToInt32(Num_Dmg.Value);
            Lbl_HPValue.Text = character.hp.ToString();
        }

        private void Lst_Actions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curItem = Lst_Actions.SelectedIndex;
            Debug.WriteLine(character.actions[curItem].name + " selecionado");
            chosenAction = character.actions[curItem];

            this.Close();
        }
    }
}
