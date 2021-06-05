using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimalCivilisation
{
    class Events
    {
        public static void IncreaseLocationFood(GameCity city)
        {
            MessageBox.Show("Поле отлично плодоносит. Эффективность добычи еды увеличилась на 20%");
            city.FoodLocation.Efficiency += 0.2;
        }

        public static void FindBerryField(GameCity city)
        {
            MessageBox.Show("рабочие нашли ягодное поле. Еда +8");
            city.Food.Add(+8);
        }

        public static void DecreaseLocationFood(GameCity city)
        {
            MessageBox.Show("Засуха. Эффективность добычи еды упала на 10%");
            city.FoodLocation.Efficiency -= 0.1;
        }
        public static void StoleFood(GameCity city)
        {
            MessageBox.Show("Рабочие украли еду. Еда -3");
            city.Food.Add(-3);
        }

        public static void DecreaseLocationStone(GameCity city)
        {
            MessageBox.Show("Твердая порода. Эффективность добычи камня снизилась на 20%");
            city.StoneLocation.Efficiency -= 0.2;
        }
        public static void Goldmine(GameCity city)
        {
            MessageBox.Show("Золотая жила. Эффективнось добычи камня и науки возросла на 30%");
            city.StoneLocation.Efficiency += 0.3;
            city.LocationScience.Efficiency += 0.3;
        }

        public static void StoleStone(GameCity city)
        {
            MessageBox.Show("Рабочие украли камень. Камень -5");
            city.Stone.Add(-5);
        }
        public static void FindStone(GameCity city)
        {
            MessageBox.Show("Рабочие добыли камня сверх нормы. Камень +8");
            city.Stone.Add(+8);
        }

        public static void StoleWood(GameCity city)
        {
            MessageBox.Show("Рабочие украли дерево. Дерево -5");
            city.Wood.Add(-5);
        }
        public static void FindWood(GameCity city)
        {
            MessageBox.Show("Рабочие добыли дерева сверх нормы. Дерево +8");
            city.Wood.Add(+8);
        }

        public static void StupidScientists(GameCity city)
        {
            MessageBox.Show("Ученые пропили свои достижения. Вы потеряли 5 очков науки и 1 очко технологий ");
            city.Science.Add(-5);
            city.Technologies.Points -= 1;
        }
        public static void CleverScientists(GameCity city)
        {
            MessageBox.Show("Бешенно умные ученые. Вы получили 8 очков науки и 1 очко технологий");
            city.Science.Add(+8);
            city.Technologies.Points += 1;
        }

        public static void Flood(GameCity city)
        {
            var result = MessageBox.Show("Наводнение\r\n Построить дамбу(ДА)/Попытаться выпить воду(НЕТ)", "Выбор", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                city.Food.Add(5);
                MessageBox.Show("К берегу прибило мертвые туши животных. Еда +5");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    city.People.RemoveMan();
                    city.People.Count--;
                }
                MessageBox.Show("Некоторые люди пили так усердно, что захлебнулись. 5 людей погибло");
                city.CheckPeople();
            }
        }

        public static void GreatMigration(GameCity city)
        {
            var result = MessageBox.Show("Великая миграция\r\n Охотиться(ДА)/Молиться богам(НЕТ)", "Выбор", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                city.Food.Add(35);
                MessageBox.Show("Ваши охотники вернулись с огромной добычей. Еда +35");
            }
            else
            {
                city.Science.Add(20);
                MessageBox.Show("Массовая миграция животных - не что инное как божий знак. Наука +20");
            }
        }
    }
}
