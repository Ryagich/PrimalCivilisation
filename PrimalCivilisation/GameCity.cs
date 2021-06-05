using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    public class GameCity
    {
        public Resource Food;
        public Resource Wood;
        public Resource Stone;
        public Resource Science;

        public LocationFood FoodLocation;
        public Location WoodLocation;
        public Location StoneLocation;
        public LocationScience LocationScience;

        public People People;

        public Technologies Technologies;
        public Buildings Buildings;

        public Enemy Enemy;

        public GameCity()
        {
            Food = new Resource(0, 10);
            Wood = new Resource(0, 10);
            Stone = new Resource(0, 10);
            Science = new Resource(0, 10);
            FoodLocation = new LocationFood(Food, 0, 10, 0, 0);
            WoodLocation = new Location(Wood, 0, 10, 0.5, 0.9);
            StoneLocation = new Location(Stone, 0, 10, 0, 0.7);
            LocationScience = new LocationScience(Science, 0, 10, 0, 1.3);
            People = new People(this);
            Technologies = new Technologies(this);
            Buildings = new Buildings(this);
            Enemy = new Enemy(this);
        }

        public void Update()
        {
            FoodLocation.UpdateFood((int)People.Count);
            WoodLocation.Update();
            StoneLocation.Update();
            LocationScience.UpdateScience();
            People.UpdatePeopleCount();
        }

        public void RandomEvent(int turn)
        {
            var rnd = new Random();

            if (rnd.NextDouble() > 0.85)
            {
                var methods = typeof(Events).GetMethods();
                methods = methods.Where(a => a.IsStatic).ToArray();
                methods[rnd.Next(methods.Length)].Invoke(null, new object[] { this });
            }
            else if (rnd.NextDouble() < Enemy.GetDanger(turn) / 10 && rnd.NextDouble() > 0.7)
            {
                var methods = typeof(EnemyEvents).GetMethods();
                methods = methods.Where(a => a.IsStatic).ToArray();
                methods[rnd.Next(methods.Length)].Invoke(null, new object[] { this });
            }
        }

        public void CheckPeople()
        {
            if (People.Count < 1)
            {
                System.Windows.Forms.MessageBox.Show("Вы проиграли");
            }    
        }
    }
}
