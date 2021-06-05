using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    public class LocationFood : Location
    {
        public LocationFood(Resource resource, int peopleValue, int peopleMax, double allowance, double efficiency) 
                     : base(resource, peopleValue, peopleMax, allowance, efficiency)

        {
        }

        public void UpdateIncome(int peopleCount)
        {
            base.PassiveIncome = -peopleCount * 0.5;
        }

        public void UpdateFood(int peopleCount)
        {
            UpdateIncome(peopleCount);
            var nextValue = GetIncome() + resource.Value;
            resource.Value = nextValue;
        }
    }
}
