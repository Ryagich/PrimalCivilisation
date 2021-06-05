using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimalCivilisation
{
    public partial class ScienceMenu : Form
    {
        public GameCity City;

        public ScienceMenu()
        {
            InitializeComponent();
        }
        public ScienceMenu(GameCity city)
        {
            InitializeComponent();
            City = city;
            UpdateButtons(City.Technologies);
        }

        public void UpdateButtons(Technologies technologies)
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control.Tag is string)
                {
                    var splited = ((string)control.Tag).Split(';');
                    var type = (Technologies.TechnologieType)int.Parse(splited[0]);
                    var level = int.Parse(splited[1]);
                    control.Enabled = level - 1 == technologies.Levels[type]
                                   && technologies.Points > 0;
                }
            }
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
        }

        private void ScienceMenuActivated(object sender, EventArgs e)
        {
            UpdateButtons(City.Technologies);
        }

        private void TechnologieButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            var level = int.Parse(splited[1]);
            City.Technologies.Learn(type);
            UpdateButtons(City.Technologies);
        }

        private void Food1Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 3);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " эффективность добычи еды на человека возрастает вдвое" +
                "\n максимум людей на локации + 10" +
                "\n пассивный прирост еды +3";
        }

        private void Food2Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 3);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " эффективность добычи еды на человека возрастает вдвое" +
                "\n максимум людей на локации + 10" +
                "\n пассивный прирост еды +3";
        }

        private void Food3Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 4);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " эффективность добычи еды на человека возрастает вдвое" +
                "\n максимум людей на локации + 10" +
                "\n пассивный прирост еды +4";
        }

        private void Food4Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 5);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " эффективность добычи еды на человека возрастает вдвое" +
                "\n максимум людей на локации + 10" +
                "\n пассивный прирост еды +5";
        }

        private void Food5Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 6);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " эффективность возрастает на 100%" +
                "\n максимум людей на локации + 10" +
                "\n пассивный прирост еды +6";
        }

        private void Wood1Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 20, 1.5, 10, 2);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Максимум людей на локации +10." +
                " Эффективность возрастает на 50%" +
                "\n максимум древесины +20. Пассивный прирост древесины +2";
        }

        private void Wood2Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 0, 1.5, 10, 3);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Максимум людей на локации +10." +
                " Эффективность возрастает на 50%" +
                "\n максимум древесины +20. Пассивный прирост древесины +3";
        }

        private void Wood3Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 0, 1.5, 10, 4);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Максимум людей на локации +10." +
                " Эффективность возрастает на 50%" +
                "\n максимум древесины +20. Пассивный прирост древесины +4";
        }

        private void Wood4Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 0, 1.5, 10, 5);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Максимум людей на локации +10. " +
                "Эффективность возрастает на 50%" +
                "\n максимум древесины +20. Пассивный прирост древесины +5";
        }

        private void Wood5Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 0, 1.5, 10, 6);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Максимум людей на локации +10. " +
                "Эффективность возрастает на 50%" +
                "\n максимум древесины +20. Пассивный прирост древесины +6";
        }

        private void Stone1Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 10, 1.5, 10, 2);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Максимум людей на локации +10." +
                " Эффективность возрастает на 50%" +
                "\n максимум камня +10. Пассивный прирост камня +2";
        }

        private void Stone2Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 10, 1.5, 10, 2);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Максимум людей на локации +10. " +
                "Эффективность возрастает на 50%" +
                "\n максимум камня +10. Пассивный прирост камня +2";
        }

        private void Stone3Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 10, 1.5, 10, 2);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Максимум людей на локации +10. " +
                "Эффективность возрастает на 50%" +
                "\n максимум камня +10. Пассивный прирост камня +2";
        }

        private void Stone4Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 10, 1.5, 10, 2);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Максимум людей на локации +10. " +
                "Эффективность возрастает на 50%" +
                "\n максимум камня +10. Пассивный прирост камня +2";
        }

        private void Stone5Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 10, 1.5, 10, 2);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Максимум людей на локации +10. " +
                "Эффективность возрастает на 50%" +
                "\n максимум камня +10. Пассивный прирост камня +2";
        }

        private void Science1Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 1.5, 5, 3);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Эффективность возрастает на 50%" +
                "\n Максимум людей на локации +5. " +
                "\n Пассивный прирост науки +3";
        }

        private void Science2Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 1.5, 5, 3);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Эффективность возрастает на 50%" +
                "\n Максимум людей на локации +5." +
                "\n Пассивный прирост науки +3";
        }

        private void Science3Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 1.5, 5, 3);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Эффективность возрастает на 50%" +
                "\n максимум людей на локации +5." +
                "\n Пассивный прирост науки +3";
        }

        private void Science4Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 1.5, 5, 3);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Эффективность возрастает на 50%" +
                "\n максимум людей на локации +5." +
                "\n Пассивный прирост науки +3";
        }

        private void Science5Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Technologies.TechnologieType)int.Parse(splited[0]);
            City.Technologies.Learn(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 1.5, 5, 3);
            UpdateButtons(City.Technologies);
            LabelTechnologiePoints.Text = $"{City.Technologies.Points}";
            lbl_InfoTechnologie.Text = " Эффективность возрастает на 50%" +
                "\n максимум людей на локации +5. " +
                "\n Пассивный прирост науки +3";
        }

        private void UpdateStateLocation(Location location, Resource resource, int resourceMaxAdd,
            double efficiecyAdd, int peopleMaxAddLocation, double passiveIncomeAdd)
        {
            resource.Max += resourceMaxAdd;
            location.Efficiency += efficiecyAdd;
            location.PeopleMax += peopleMaxAddLocation;
            location.PassiveIncome += passiveIncomeAdd;
        }

        private void UpdateStateLocationFood(LocationFood locationFood, Resource food, int resourceMaxAdd,
            double efficiecyAdd, int peopleMaxAddLocation, double passiveIncomeAdd)
        {
            food.Max += resourceMaxAdd;
            locationFood.Efficiency += efficiecyAdd;
            locationFood.PeopleMax += peopleMaxAddLocation;
            locationFood.PassiveIncome += passiveIncomeAdd;
        }

        private void UpdateStateLocationScience(LocationScience locationScience, Resource Science, int resourceMaxAdd,
            double efficiecyAdd, int peopleMaxAddLocation, double passiveIncomeAdd)
        {
            Science.Max += resourceMaxAdd;
            locationScience.Efficiency += efficiecyAdd;
            locationScience.PeopleMax += peopleMaxAddLocation;
            locationScience.PassiveIncome += passiveIncomeAdd;
        }
    }
}
