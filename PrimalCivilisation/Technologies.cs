using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    public class Technologies
    {
        public enum TechnologieType
        {
            Food = 1,
            Wood = 2,
            Stone = 3,
            Science = 4,
        }

        public GameCity City;
        public int Points;
        public Dictionary<TechnologieType, int> Levels;

        public Technologies(GameCity city)
        {
            City = city;
            Levels = new Dictionary<TechnologieType, int>();
            foreach (TechnologieType type in Enum.GetValues(typeof(TechnologieType)))
                Levels.Add(type, 0);
        }

        public void UpdateSciencePoints()
        {
            if (City.Science.Value >= City.Science.Max)
            {
                Points += (int)(City.Science.Value / City.Science.Max);
                City.Science.Value %= City.Science.Max;
                City.Science.Max += 5;
            }
        }

        public void Learn(TechnologieType type)
        {
            if (Levels[type] < 5 && Points > 0)
            {
                Points--;
                Levels[type]++;
            }
        }
    }
}