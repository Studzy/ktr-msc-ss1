using ktr_msc_ss1.exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    public class Warrior : Character
    {
        public Warrior(string nameArg, string classArg = "Warrior") : base(nameArg, classArg)
        {
            life = 100;
            strength = 10;
            agility = 8;
            wit = 3;
            Console.WriteLine(nameArg + " : My name will go down in history!");
        }
        public override void Attack(string arg)
        {
            if (string.IsNullOrWhiteSpace(arg))
            {
                throw new WeaponException( getName + " : I refuse to fight with my bare hands.");
            }
            if (arg == "hammer" || arg == "sword")
            {
                base.Attack(arg);
                Console.WriteLine(getName + " : I'll crush you with my " + arg + "!");
            }
            else
            {
                throw new WeaponException(getName + " : A " + arg + "?? What should I do with this ?!");
            }
            
        }

        public override void moveForward()
        {
            Console.WriteLine(getName + " : move forward like a bad boy.");
        }

        public override void moveBack()
        {
            Console.WriteLine(getName + " : move back like a bad boy.");
        }

        public override void moveLeft()
        {
            Console.WriteLine(getName + " : move left like a bad boy.");
        }

        public override void moveRight()
        {
            Console.WriteLine(getName + " : move right like a bad boy.");
        }
    }
}
