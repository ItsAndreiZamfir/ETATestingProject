using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPHomework
{
    public class Manager : Person
    {
        private int _teamSize;
        private decimal _bonus;

        public int GetTeamSize()
        {
            return _teamSize;
        }
        public void SetTeamSize(int teamSize)
        {
            if (teamSize < 0)
            {
                throw new ArgumentException("Team size cannot be negative.");
            }
            _teamSize = teamSize;
        }
        public decimal GetBonus()
        {
            return _bonus;
        }
        public void SetBonus(decimal bonus)
        {
            if (bonus < 0)
            {
                throw new ArgumentException("Bonus cannot be negative.");
            }
            _bonus = bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager Name: {Name}");
            Console.WriteLine($"Leads a team of {_teamSize} people");
            Console.WriteLine($"Bonus: {_bonus}");
        }

    }
}
