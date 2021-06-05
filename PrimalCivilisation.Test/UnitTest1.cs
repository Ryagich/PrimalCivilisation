using NUnit.Framework;
using System;


namespace PrimalCivilisation.Test
{
    public class Tests
    {
        [Test]
        public void DangerFirstTurnAndTwoFreePeople()
        {
            var turn = 1;
            var peopleCount = 2;
            var extentedDanger = 8.00;
            var city = new GameCity();
            city.People.Count = peopleCount;
            city.People.FreePeople = peopleCount;
            var enemy = new Enemy(city);
            var actualDanger = Math.Round(enemy.GetDanger(turn));
            Assert.AreEqual(extentedDanger, actualDanger);
        }

        [Test]
        public void DangerFirstTurnAndFiveFreePeople()
        {
            var extentedDanger = 10.00;

            var city = new GameCity();
            city.People.Count = 0;
            city.People.FreePeople = 0;

            var enemy = new Enemy(city);
            var actualDanger = Math.Round(enemy.GetDanger(1));

            Assert.AreEqual(extentedDanger, actualDanger);
        }

        [Test]
        public void DeletePeople()
        {
            var extentedPeopleCount = 8;

            var city = new GameCity();
            city.People.Count = 10;
            city.Food.Value = -1;
            city.People.UpdatePeopleCount();
            var actualPeopleCount = city.People.Count;

            Assert.AreEqual(extentedPeopleCount, actualPeopleCount);
        }
        [Test]
        public void AddPeople()
        {
            var extentedPeopleCount = 11;

            var city = new GameCity();
            city.People.Count = 10;
            city.Food.Max = 10;
            city.Food.Value = 15;
            city.People.UpdatePeopleCount();
            var actualPeopleCount = city.People.Count;

            Assert.AreEqual(extentedPeopleCount, actualPeopleCount);
        }

        [Test]
        public void WoodIncomeIfEfficiencyZerro()
        {
            var city = new GameCity();
            city.WoodLocation.Efficiency = 0;
            city.WoodLocation.PeopleValue = 1;
            city.WoodLocation.PassiveIncome = 0;
            var extentedIncome = 1;
            var actualIncome = city.WoodLocation.GetIncome();
            Assert.AreEqual(extentedIncome, actualIncome);
        }

        [Test]
        public void WoodIncomeIfEfficiencyTwo()
        {
            var city = new GameCity();
            city.WoodLocation.Efficiency = 2;
            city.WoodLocation.PeopleValue = 1;
            city.WoodLocation.PassiveIncome = 0;
            var extentedIncome = 2;
            var actualIncome = city.WoodLocation.GetIncome();
            Assert.AreEqual(extentedIncome, actualIncome);
        }

        [Test]
        public void WoodIncomeIfEfficiencyMinusOne()
        {
            var city = new GameCity();
            city.WoodLocation.Efficiency = -1;
            city.WoodLocation.PeopleValue = 1;
            city.WoodLocation.PassiveIncome = 0;
            var extentedIncome = 1;
            var actualIncome = city.WoodLocation.GetIncome();
            Assert.AreEqual(extentedIncome, actualIncome);
        }

        [Test]
        public void WoodIncomeIfEfficiencyOneAndPassiveIncomeOne()
        {
            var city = new GameCity();
            city.WoodLocation.Efficiency = 1;
            city.WoodLocation.PeopleValue = 1;
            city.WoodLocation.PassiveIncome = 1;
            var extentedIncome = 2;
            var actualIncome = city.WoodLocation.GetIncome();
            Assert.AreEqual(extentedIncome, actualIncome);
        }

        [Test]
        public void UpdatePassiveIncomeFood()
        {
            var city = new GameCity();
            city.People.Count = 10;
            var extentedPassiveIncome = -5;
            city.FoodLocation.UpdateIncome(10);
            var actualIncome = city.FoodLocation.PassiveIncome;
            Assert.AreEqual(extentedPassiveIncome, actualIncome);
        }

        [Test]
        public void UpdateScience()
        {
            var city = new GameCity();
            city.Science.Max = 10;
            city.Science.Value = 0;
            city.LocationScience.PeopleValue = 1;
            city.LocationScience.UpdateScience();
            var actualScience = city.Science.Value;
            var extentedScience = 1.3;

            Assert.AreEqual(extentedScience, actualScience);
        }

        [Test]
        public void UpdateSCiencePoints()
        {
            var extentedSciencePoints = 1;
            var city = new GameCity();
            city.Science.Value = 0;
            city.Science.Max = 10;
            city.Technologies.Points = 0;
            city.Science.Add(15);
            city.Technologies.UpdateSciencePoints();
            var actualSciencePoints = city.Technologies.Points;
            Assert.AreEqual(extentedSciencePoints, actualSciencePoints);
        }

        [Test]
        public void UpdateWoodPoints()
        {
            var extentedWoodPoints = 1;
            var city = new GameCity();
            city.Wood.Value = 0;
            city.Wood.Max = 10;
            city.Buildings.WoodPoints = 0;
            city.Wood.Add(15);
            city.Buildings.UpgradePoints();
            var actualWoodPoints = city.Buildings.WoodPoints;
            Assert.AreEqual(extentedWoodPoints, actualWoodPoints);
        }

        [Test]
        public void UpdateStonePoints()
        {
            var extentedStonePoints = 1;
            var city = new GameCity();
            city.Stone.Value = 0;
            city.Stone.Max = 10;
            city.Buildings.StonePoints = 0;
            city.Stone.Add(15);
            city.Buildings.UpgradePoints();
            var actualWoodPoints = city.Buildings.StonePoints;
            Assert.AreEqual(extentedStonePoints, actualWoodPoints);
        }
    }
}