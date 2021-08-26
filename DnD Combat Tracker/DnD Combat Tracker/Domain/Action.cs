using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Combat_Tracker.Domain
{
    public class Action
    {
        public String name { get; set; }
        public int hitBonus;
        public int dmgDie;
        public int numDmgDie;
        public int dmgBonus;

        public Action (String name, int hitBonus, int dmgDie, int numDmgDie, int dmgBonus)
        {
            this.name = name;
            this.hitBonus = hitBonus;
            this.dmgDie = dmgDie;
            this.numDmgDie = numDmgDie;
            this.dmgBonus = dmgBonus;
        }

        public int ActionHit()
        {
            Random random = new Random();

            return random.Next(1, 20) + hitBonus;
        }

        public int ActionDmg()
        {
            Random random = new Random();
            int dmg = 0;

            for (int i = 0; i < numDmgDie; i++)
            {
                dmg += random.Next(1, dmgDie);
            }

            return dmg + dmgBonus;
        }
    }
}
