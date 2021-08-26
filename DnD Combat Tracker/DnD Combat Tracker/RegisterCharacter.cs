using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD_Combat_Tracker.Domain;
using Newtonsoft;
using Newtonsoft.Json;

namespace DnD_Combat_Tracker
{
    public partial class RegisterCharacter : Form
    {
        public Character character;
        List<Domain.Action> actions = new List<Domain.Action>();

        public RegisterCharacter()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            character = new Character(
                Txt_Name.Text,
                Decimal.ToInt32(Num_Proficiency.Value),
                Decimal.ToInt32(Num_Init.Value),
                Decimal.ToInt32(Num_Ac.Value),
                Decimal.ToInt32(Num_HitDie.Value),
                Decimal.ToInt32(Num_NumHitDie.Value),
                Decimal.ToInt32(Num_Str.Value),
                Decimal.ToInt32(Num_Dex.Value),
                Decimal.ToInt32(Num_Con.Value),
                Decimal.ToInt32(Num_Intel.Value),
                Decimal.ToInt32(Num_Wis.Value),
                Decimal.ToInt32(Num_Charisma.Value));

            character.actions = this.actions;

            string json = JsonConvert.SerializeObject(character);
            File.WriteAllText(@"C:\Users\doubl\source\repos\DnD Combat Tracker\DnD Combat Tracker\Characters\" + character.name + ".json", json);

            this.Close();
        }

        private void Btn_AddAction_Click(object sender, EventArgs e)
        {
            AddAction addAction = new AddAction();
            addAction.ShowDialog();

            Debug.WriteLine(addAction.action.name);

            actions.Add(addAction.action);
            Lst_Actions.Items.Add(addAction.action.name);
            //character.AddAction(addAction.action);
            //Lst_Actions.Items.Add(addAction.action.name.get());
        }
    }
}
