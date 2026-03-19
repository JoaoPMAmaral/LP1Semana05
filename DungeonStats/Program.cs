using System;
using Spectre.Console;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int damageInt = int.Parse(args[0]);
            int defenseInt = int.Parse(args[1]);

            Console.WriteLine(Damage(damageInt,defenseInt));
        }

        private static int Damage(int attack, int defense)
        {
            if(defense < 0)
            {
                return attack;
            }
            else
            {
                return attack - defense;
            }
        }

        private static int Damage(int attack)
        {
            return attack;
        }

        private static int CriticalHit(int damage)
        {
            int crit = 0;
            if(damage <= 0)
            {
                return 0;
            }
            else
            {
                crit = 1 - Damage(damage);
            }
            return crit;
        }
    }
}