using System;

namespace ktr_msc_ss1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character warrior = new Warrior("Jean-Luc");
            Character mage = new Mage("Robert");
            warrior.tryToAttack("screwdriver");
            mage.tryToAttack("hammer");
            warrior.tryToAttack("hammer");
        }
    }
}
