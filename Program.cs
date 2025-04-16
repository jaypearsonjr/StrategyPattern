using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IWeapon> weaponCach = new List<IWeapon>();

            IWeapon sword = new Sword();
            IWeapon knife = new Knife();
            IWeapon bow = new Bow();

            weaponCach.Add(sword);
            weaponCach.Add(knife);
            weaponCach.Add(bow);

            foreach (var weapon in weaponCach)
            {
                ICharacter king = new King(weapon);

                Console.WriteLine(king.useWeapon());
            }

            foreach (var weapon in weaponCach)
            {
                ICharacter queen = new Queen(weapon);

                Console.WriteLine(queen.useWeapon());
            }

            Console.ReadLine();
        }
    }
}
