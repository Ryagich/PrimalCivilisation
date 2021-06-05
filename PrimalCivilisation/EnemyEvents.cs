using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    class EnemyEvents
    {
        public static void StrongAndCleverEnemy(GameCity city)
        {
            var result = MessageBox.Show("Нападение сильных и умных врагов\r\n Дать бой(ДА)/Попыться обмануть(НЕТ)", "Выбор", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < 5; i++)
                {
                    city.People.RemoveMan();
                    city.People.Count--;

                }
                MessageBox.Show("Враг оказался сильнее. 5 человек захваченно в рабство. В бою сила ваших воинов выросла на 12%");
                city.Enemy.ProtectionEfficiency += 0.12;
                city.CheckPeople();
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    city.People.RemoveMan();
                    city.People.Count--;

                }
                MessageBox.Show("Враг оказался умнее. 2 человека захваченно в рабство");
                city.CheckPeople();
            }
        }

        public static void StrongEnemy(GameCity city)
        {
            var result = MessageBox.Show("Нападению сильных, но глупых врагов\r\n Дать бой(ДА)/Попыться обмануть(НЕТ)", "Выбор", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < 3; i++)
                {
                    city.People.RemoveMan();
                    city.People.Count--;
                }
                MessageBox.Show("Враги оказались сильнее. 3 человека съедененно");
                city.CheckPeople();
            }
            else
            {
                city.Science.Add(-10);
                MessageBox.Show("Вы успешно обвели своих врагов вокруг пальца, но потеряли 10 науки");
            }
        }

        public static void CleverEnemy(GameCity city)
        {
            var result = MessageBox.Show("Нападение умных, но слабых врагов\r\n Дать бой(ДА)/Попыться обмануть(НЕТ)", "Выбор", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                city.Enemy.ProtectionEfficiency += 0.1;
                MessageBox.Show("Вы успешно справились с вражеским нападением Сила защиты выросла на 10%");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    city.People.RemoveMan();
                    city.People.Count--;
                }
                MessageBox.Show("Враги не купились на вашу ловушку и угнали в рабство 5 человек");
                city.CheckPeople();
            }
        }
        public static void WeakAndStupidEnemy(GameCity city)
        {
            var result = MessageBox.Show("Нападение никчесных врагов\r\n Дать бой(ДА)/Попыться обмануть(НЕТ)", "Выбор", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                city.Enemy.ProtectionEfficiency += 0.1;
                MessageBox.Show("Вы успешно справились с вражеским нападением Сила защиты выросла на 10%");
            }
            else
            {
                city.Science.Add(-3);
                MessageBox.Show("Вы успешно обвели своих врагов вокруг пальца, но потеряли 3 науки");
            }
        }
    }
}
