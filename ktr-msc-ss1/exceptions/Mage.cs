using ktr_msc_ss1.exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ktr_msc_ss1
{
    public class Mage : Character
    {
        public Mage(string nameArg, string classArg = "Mage") : base(nameArg, classArg)
        {
            life = 70;
            strength = 3;
            agility = 10;
            wit = 10;
            Console.WriteLine(nameArg + " :  May the gods be with me.");
        }

        public override void Attack(string arg)
        {
            if (string.IsNullOrWhiteSpace(arg))
            {
                throw new WeaponException(getName + " : I refuse to fight with my bare hands.");
            }
            if (arg == "magic" || arg == "wand")
            {
                base.Attack(arg);
                Console.WriteLine(getName + " : Feel the power of my " + arg + "!");
            }
            else
            {
                throw new WeaponException(getName + " : I don 't need this stupid " + arg + "! Don't misjudge my powers!");
            }

        }

        public override void moveBack()
        {
            Console.WriteLine(getName + " : move back furtively.");
        }

        public override void moveForward()
        {
            Console.WriteLine(getName + " : move forward furtively.");
        }

        public override void moveRight()
        {
            Console.WriteLine(getName + " : move right furtively.");
        }

        public override void moveLeft()
        {
            Console.WriteLine(getName + " : move left furtively.");
        }
    }
}
