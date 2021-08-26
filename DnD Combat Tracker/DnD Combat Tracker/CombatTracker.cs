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
    public partial class CombatTracker : Form
    {
        public List<Domain.Character> characters = new List<Domain.Character>();
        int characterId = 0;
        public Domain.Action chosenAction;

        public CombatTracker()
        {
            InitializeComponent();
        }

        private void Btn_AddCombatant_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\doubl\source\repos\DnD Combat Tracker\DnD Combat Tracker\Characters",
                Title = "Selecione Arquivo JSON",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Character character = JsonConvert.DeserializeObject<Character>(File.ReadAllText(openFileDialog1.FileName));
                Debug.WriteLine(character.name + " Carregado");

                character.CalculateInit();
                if (Chk_AvgHP.Checked)
                {
                    character.CalculateAvgHp();
                }
                else
                {
                    character.CalculateHp();
                }

                characterId++;

                character.name = character.name + " " + characterId.ToString();
                characters.Add(character);
                Lst_Combatants.Items.Add(character.init.ToString() + " " + character.name);
            }
        }

        private void Btn_RegisterCharacter_Click(object sender, EventArgs e)
        {
            RegisterCharacter registerCharacter = new RegisterCharacter();
            registerCharacter.ShowDialog();
        }

        private void Lst_Combatants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curItem = Lst_Combatants.SelectedIndex;
            Debug.WriteLine(characters[curItem].name + " selecionado");

            if (chosenAction != null)
            {
                int auxHit;
                int auxDmg;

                auxHit = chosenAction.ActionHit();

                if (auxHit >= characters[curItem].ac)
                {
                    auxDmg = chosenAction.ActionDmg();
                    characters[curItem].hp -= auxDmg;

                    MessageBox.Show("Acerto!\nAlvo:" + characters[curItem].name + "\nRolagem de acerto:" + auxHit.ToString() + "\nClasse de Armadura:" + characters[curItem].ac.ToString() + "\nDano:" + auxDmg.ToString());
                }
                else
                {
                    MessageBox.Show("Erro!\nAlvo:" + characters[curItem].name + "\nRolagem de acerto:" + auxHit.ToString() + "\nClasse de Armadura:" + characters[curItem].ac.ToString());
                }

                chosenAction = null;
            }
            else
            {
                CharacterInfo characterInfo = new CharacterInfo();
                characterInfo.character = characters[curItem];
                characterInfo.ShowDialog();
                this.chosenAction = characterInfo.chosenAction;
            }

            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].hp <= 0)
                {
                    characters.RemoveAt(i);
                }
            }

            Lst_Combatants.Items.Clear();
            for (int i = 0; i < characters.Count; i++)
            {
                Lst_Combatants.Items.Add(characters[i].init.ToString() + " " + characters[i].name);
            }
        }
    }
}
