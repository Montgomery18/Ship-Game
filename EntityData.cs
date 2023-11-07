using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game__Application_
{
    internal class EntityData
    {
        private bool isPlayer;
        private string name;
        private int hp;
        private int ac;
        private WeaponData weaponType;

        public EntityData(bool player, string playerName, int health, int armour, WeaponData weapons)
        {
            isPlayer = player;
            name = playerName;
            hp = health;
            ac = armour;
            weaponType = weapons;
        }

        public bool getIsPlayer()
        {
            return isPlayer;
        }
        public string getName()
        {
            return name;
        }
        public int getHealth()
        {
            return hp;
        }
        public int getArmour()
        {
            return ac;
        }
        public WeaponData getWeaponType()
        {
            return weaponType;
        }
        public void setIsPlayer(bool player)
        {
            isPlayer = player;
        }
        public void setName(string playerName)
        {
            name = playerName;
        }
        public void setHealth(int health)
        {
            hp = health;
        }
        public void setArmour(int armour)
        {
            ac = armour;
        }
        public void setWeaponType(WeaponData weapons)
        {
            weaponType = weapons;
        }

        //reading from a file to get names for the entities
        public string randomNameExtraction(Random rng)
        {
        string path = "namesforentities.txt";
            if (File.Exists(path))
            {
                List<string> names = File.ReadAllText(path).Split(",").ToList();
                return names[rng.Next(0, names.Count)];
            }
            else //the file name is static so this shouldn't occur, here just as a fallback (in case things don't work as intended)
            {
                return "Reliant";
            }
        }
        //
    }
}