using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    public class Buildings
    {
        public enum BuildingType
        {
            Food = 1,
            Wood = 2,
            Stone = 3,
            Science = 4,
        }
        public GameCity City;
        public Dictionary<BuildingType, int> Levels;
        public int WoodPoints, StonePoints;

        public Buildings(GameCity city)
        {
            City = city;
            Levels = new Dictionary<BuildingType, int>();
            foreach (BuildingType type in Enum.GetValues(typeof(BuildingType)))
                Levels.Add(type, 0);
        }

        public void UpgradePoints()
        {
            if (City.Wood.Value >= City.Wood.Max)
            {
                WoodPoints += (int)(City.Wood.Value / City.Wood.Max);
                City.Wood.Value %= City.Wood.Max;
                City.Wood.Max += 5;
            }
            if (City.Stone.Value >= City.Stone.Max)
            {
                StonePoints += (int)(City.Stone.Value / City.Stone.Max);
                City.Stone.Value %= City.Stone.Max;
                City.Stone.Max += 5;
            }
        }
        public void Build(BuildingType type)
        {
            if (Levels[type] < 3 && WoodPoints > 0 && StonePoints > 0)
            {
                WoodPoints--;
                StonePoints--;
                Levels[type]++;
            }
        }
    }
}
