using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    public class Enemy
    {
        public GameCity City;
        public double ProtectionEfficiency{ get; set; }

        public Enemy(GameCity city)
        {
            City = city;
            ProtectionEfficiency = 1;
        }

        public double GetDanger(int turn)
        {
            var Danger = 10 + Math.Sin(turn * 0.1) * Math.Pow(0.1, turn) - City.People.FreePeople * ProtectionEfficiency;
            return Danger > 0 ? Danger : 0;
        }
    }
}
