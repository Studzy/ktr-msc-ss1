using ktr_msc_ss1.exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    public class Character : Movable
    {
        protected string name;
        readonly string RPGClass;
        protected int life;
        protected int agility;
        protected int strength;
        protected int wit;
        
        public Character( string nameArg, string classArg)
        {
            name = nameArg;
            RPGClass = classArg;
            life = 50;
            agility = 2;
            strength = 2;
            wit = 2;
        }

        public string getName 
        {
            get { return name; }
        }

        public string getRPGClass
        {
            get { return RPGClass; }
        }
        public int getLife
        {
            get { return life; }
        }
        public int getAgility
        {
            get { return agility; }
        }
        public int getStrength
        {
            get { return strength; }
        }
        public int getWit
        {
            get { return wit; }
        }
        public virtual void Attack(string arg)
        {
            Console.WriteLine(getName + " : Rrrrrrrrr ....");
        }

        public void tryToAttack(string arg)
        {
            try
            {
                Attack(arg);
            }
            catch (WeaponException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Unsheathe()
        {
            Console.WriteLine(getName + " : unsheathes his weapon.");
        }

        public virtual void moveRight()
        {
            Console.WriteLine(getName + " : move right");
        }

        public virtual void moveLeft()
        {
            Console.WriteLine(getName + " : move left");
        }

        public virtual void moveForward()
        {
            Console.WriteLine(getName + " : move forward");
        }

        public virtual void moveBack()
        {
            Console.WriteLine(getName + " : move back");
        }

    }
}
