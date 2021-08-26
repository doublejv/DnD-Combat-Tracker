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
using DnD_Combat_Tracker.Domain;

namespace DnD_Combat_Tracker
{
    public partial class AddAction : Form
    {
        public Domain.Action action;

        public AddAction()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            action = new Domain.Action(
                Txt_Name.Text,
                Decimal.ToInt32(Num_HitBonus.Value),
                Decimal.ToInt32(Num_DmgDie.Value), 
                Decimal.ToInt32(Num_NumDmgDie.Value), 
                Decimal.ToInt32(Num_DmgBonus.Value));

            this.Close();
        }
    }
}
