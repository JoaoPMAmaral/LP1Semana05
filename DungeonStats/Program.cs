using System;
using Spectre.Console;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int damageInt = int.Parse(args[0]);

            if(args.Length < 2)
            {

                var table = new Table();

                table.AddColumn("Operation");
                table.AddColumn("Result");

                table.AddRow($"Damage({Damage(damageInt)})");
                table.AddRow($"Damage({Damage(damageInt,2)})");
                table.AddRow($"CriticalHit({CriticalHit(damageInt)})");

                Console.WriteLine(table);
            }
            else
            {
                int defenseInt = int.Parse(args[1]);

                var table = new Table();

                table.AddColumn("Operation");
                table.AddColumn("Result");

                table.AddRow($"Damage({Damage(damageInt)})");
                table.AddRow($"Damage({Damage(damageInt,defenseInt)})");
                table.AddRow($"CriticalHit({CriticalHit(damageInt)})");

                Console.WriteLine(table);
            }
            
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
                crit = 1 + Damage(damage);
            }
            return crit;
        }
    }
}