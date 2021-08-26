using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Combat_Tracker.Domain
{
    public class Character
    {
        public String name;
        public int proficiency;
        public int hp;
        public int init;
        public int initBonus;
        public int ac;
        public int hitDie;
        public int numHitDie;
        public int str;
        public int dex;
        public int con;
        public int intel;
        public int wis;
        public int charisma;
        public List<Action> actions = new List<Action>();

        public Character(String name, int proficiency, int initBonus, int ac, int hitDie, int numHitDie, int str, int dex, int con, int intel, int wis, int charisma)
        {
            this.name = name;
            this.proficiency = proficiency;
            this.initBonus = initBonus;
            this.ac = ac;
            this.hitDie = hitDie;
            this.numHitDie = numHitDie;
            this.str = str;
            this.dex = dex;
            this.con = con;
            this.intel = intel;
            this.wis = wis;
            this.charisma = charisma;
        }

        public void CalculateHp()
        {
            Random random = new Random();
            this.hp = 0;
            for(int i = 0; i < numHitDie; i++)
            {
                this.hp += random.Next(1, hitDie) + ((con - 10) / 2);
            }
        }

        public void CalculateAvgHp()
        {
            int auxcon = (int)Math.Floor((double)(con - 10) / 2.0);
            this.hp = (((hitDie / 2) + 1) * numHitDie + ((auxcon) * numHitDie)) - 1;
        }

        public void CalculateInit()
        {
            Random random = new Random();
            this.init = random.Next(1, 20) + initBonus;
        }
    }
}
