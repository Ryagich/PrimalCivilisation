using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    public class People
    {
        private const int defaultCount = 8;
        public int FreePeople { get; set; }
        public GameCity City { get; private set; }
        public double Count { get; set; }

        public People(GameCity city)
        {
            City = city;
            Count = defaultCount;
            FreePeople = (int)Count;
        }

        public void UpdatePeopleCount()
        {
            if (City.Food.Value >= City.Food.Max)
            {
                Count += (int)(City.Food.Value / City.Food.Max);
                FreePeople += (int)(City.Food.Value / City.Food.Max);
                City.Food.Value %= City.Food.Max;
                City.Food.Max += 2;
            }
            else if (City.Food.Value < 0)
            {
                RemovePeople(Count * 0.2);
                City.Food.Value = 0;
            }
        }

        private void RemoveBusyPeople(double removeBusyPeopleCount)
        {
            var foodPercent = City.FoodLocation.PeopleValue / (Count - FreePeople);
            var woodPercent = City.WoodLocation.PeopleValue / (Count - FreePeople);
            var stonePercent = City.StoneLocation.PeopleValue / (Count - FreePeople);
            var sciencePercent = City.LocationScience.PeopleValue / (Count - FreePeople);
            var subError = 0.0;
            City.FoodLocation.PeopleValue -= (int)(removeBusyPeopleCount * foodPercent);
            subError += GetFractionalPart(removeBusyPeopleCount * foodPercent);
            City.WoodLocation.PeopleValue -= (int)(removeBusyPeopleCount * woodPercent);
            subError += GetFractionalPart(removeBusyPeopleCount * woodPercent);

            City.StoneLocation.PeopleValue -= (int)(removeBusyPeopleCount * stonePercent);
            subError += GetFractionalPart(removeBusyPeopleCount * stonePercent);
            City.LocationScience.PeopleValue -= (int)(removeBusyPeopleCount * sciencePercent);
            subError += GetFractionalPart(removeBusyPeopleCount * sciencePercent);

            while (subError-- >= 1)
                RemoveMan();
        }

        public void RemoveMan()
        {
            var list = new List<Location>
            {
                City.StoneLocation,
                City.WoodLocation,
                City.LocationScience,
                City.FoodLocation
            };
            foreach (var location in list)
            {
                if (location.PeopleValue >= 1)
                {
                    location.PeopleValue--;
                    break;
                }
            }
        }

        private double GetFractionalPart(double value)
        {
            return value - Math.Truncate(value);
        }

        private void RemovePeople(double removeCount)
        {
            var freePeopleProportion = FreePeople / Count;
            var busyPeopleProportion = 1 - freePeopleProportion;
            var busyPeopleRemoveCount = removeCount * busyPeopleProportion;
            var freePeopleRemoveCount = removeCount * freePeopleProportion;
            Count -= removeCount;
            FreePeople -= (int)freePeopleRemoveCount;
            if (FreePeople > Count)
            {
                FreePeople--;
            }
            RemoveBusyPeople(busyPeopleRemoveCount);
        }
    }
}
