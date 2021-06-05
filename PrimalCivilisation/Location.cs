using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    public class Location : IGameLocation
    {
        protected Resource resource;

        public double Efficiency = 1.0;
        public int PeopleValue { get; set; }
        public int PeopleMax { get; set; }
        public double PassiveIncome { get; set; }
        public Location(Resource resource, int peopleValue, int peopleMax, double passiveIncome, double efficiency)
        {
            this.resource = resource;
            PeopleValue = peopleValue;
            PeopleMax = peopleMax;
            PassiveIncome = passiveIncome;
            Efficiency = efficiency;
        }

        public double GetIncome()
        {
            double income;
            if (Efficiency > 0)
                income = PeopleValue * Efficiency + PassiveIncome;
            else
                income = PeopleValue + PassiveIncome;
            return income;
        }

        public void Update()
        {
            var nextValue = GetIncome() + resource.Value;
            if (nextValue > resource.Max)
                nextValue = resource.Max;
            if (nextValue < 0)
                nextValue = 0;
            resource.Value = nextValue;
        }
    }
}
