using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game__Application_
{
    internal class WeaponData
    {
        private bool cannon;
        private bool explosiveDrone;
        private int speed; //Only applies to explosive drones
        private int damage; //Used universally for all weapon types
        private int range; //Only applies to cannons, anything else has infinite range
        //Further note, range indicates the x coordinate at which the cannon can start to be fired from
        private int coolDown; //Used universally for all weapon types

        public WeaponData(bool cannon, bool explosiveDrone, int speed, int damage, int range, int coolDown)
        {
            this.cannon = cannon;
            this.explosiveDrone = explosiveDrone;
            this.speed = speed;
            this.damage = damage;
            this.range = range;
            this.coolDown = coolDown;
        }

        public bool getCannon()
        {
            return cannon;
        }
        public bool getExplosiveDrone()
        {
            return explosiveDrone;
        }
        public int getSpeed()
        {
            return speed;
        }
        public int getDamage()
        {
            return damage;
        }
        public int getRange()
        {
            return range;
        }
        public int getCoolDown()
        {
            return coolDown;
        }
        public void setCannon(bool hasCan)
        {
            cannon = hasCan;
        }
        public void setExplosiveDrone(bool hasExpDrone)
        {
            explosiveDrone = hasExpDrone;
        }
        public void setSpeed(int travelSpeed)
        {
            speed = travelSpeed;
        }
        public void setDamage(int hurt)
        {
            damage = hurt;
        }
        public void setRange(int maxRange)
        {
            range = maxRange;
        }
        public void setCoolDown(int coolDownTime)
        {
            coolDown = coolDownTime;
        }
    }
}