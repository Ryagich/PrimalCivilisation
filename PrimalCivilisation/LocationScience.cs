using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    public class LocationScience : Location
    {
        public LocationScience(Resource resource, int peopleValue, int peopleMax, double passiveIncome, double efficiency)
                        : base(resource, peopleValue, peopleMax, passiveIncome, efficiency)
        {
        }
        public void UpdateScience()
        {
            resource.Value = GetIncome() + resource.Value;
        }
    }
}
