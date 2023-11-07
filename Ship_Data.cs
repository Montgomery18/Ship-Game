using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game__Application_
{
    internal class Ship_Data
    {
        private int HP;
        private int AC;
        private bool has90mmCannon;
        private bool has180mmCannon;

        public Ship_Data(int Health, int Armour, bool smallCannon, bool bigCannon)
        {
            HP = Health;
            AC = Armour;
            has90mmCannon = smallCannon;
            has180mmCannon = bigCannon;
        }
    }
}
