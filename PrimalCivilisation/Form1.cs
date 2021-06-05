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
    public partial class Form1 : Form
    {
        public ScienceMenu ScienceMenu;
        public BuildingsMenu BuildingMenu;
        public GameCity City;
        public int Turn { get; set; }
        public Form1()
        {
            Turn = 1;
            City = new GameCity();
            ScienceMenu = new ScienceMenu(City);
            BuildingMenu = new BuildingsMenu(City);

            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void ButtonMinusFoodClick(object sender, EventArgs e)
        {
            if (City.FoodLocation.PeopleValue > 0)
            {
                City.FoodLocation.PeopleValue--;
                City.People.FreePeople++;
                UpdateLabels();
            }
        }

        private void ButtonAddFoodClick(object sender, EventArgs e)
        {
            if (City.FoodLocation.PeopleValue < City.FoodLocation.PeopleMax
                && City.People.FreePeople > 0)
            {
                City.FoodLocation.PeopleValue++;
                City.People.FreePeople--;
                UpdateLabels();
            }
        }

        private void ButtonMinusWoodClick(object sender, EventArgs e)
        {
            if (City.WoodLocation.PeopleValue > 0)
            {
                City.WoodLocation.PeopleValue--;
                City.People.FreePeople++;
                UpdateLabels();
            }
        }

        private void ButtonAddWoodClick(object sender, EventArgs e)
        {
            if (City.WoodLocation.PeopleValue < City.WoodLocation.PeopleMax
                && City.People.FreePeople > 0)
            {
                City.WoodLocation.PeopleValue++;
                City.People.FreePeople--;
                UpdateLabels();
            }
        }

        private void ButtonMinusQuarryClick(object sender, EventArgs e)
        {
            if (City.StoneLocation.PeopleValue > 0)
            {
                City.StoneLocation.PeopleValue--;
                City.People.FreePeople++;
                UpdateLabels();
            }
        }

        private void ButtonAddQuarryClick(object sender, EventArgs e)
        {
            if (City.StoneLocation.PeopleValue < City.StoneLocation.PeopleMax
                && City.People.FreePeople > 0)
            {
                City.StoneLocation.PeopleValue++;
                City.People.FreePeople--;
                UpdateLabels();
            }
        }

        private void ButtonMinusShrineClick(object sender, EventArgs e)
        {
            if (City.LocationScience.PeopleValue > 0)
            {
                City.LocationScience.PeopleValue--;
                City.People.FreePeople++;
                UpdateLabels();
            }
        }

        private void ButtonAddShrineClick(object sender, EventArgs e)
        {
            if (City.LocationScience.PeopleValue < City.LocationScience.PeopleMax
                && City.People.FreePeople > 0)
            {
                City.LocationScience.PeopleValue++;
                City.People.FreePeople--;
                UpdateLabels();
            }
        }

        public void UpdateLabels()
        {
            LabelHuntingValue.Text = $"{City.FoodLocation.PeopleValue} / {City.FoodLocation.PeopleMax}";
            LabelFoodInfo.Text = $"{City.Food.Value:F1} / {City.Food.Max:F1}";
            City.FoodLocation.UpdateIncome((int)City.People.Count);
            LabelFoodAdd.Text = $"{City.FoodLocation.GetIncome():F1}";

            LabelWoodValue.Text = $"{City.WoodLocation.PeopleValue} / {City.WoodLocation.PeopleMax}";
            LabelWoodInfo.Text = $"{City.Wood.Value:F1} / {City.Wood.Max:F1}";
            LabelWoodAdd.Text = $"+ {City.WoodLocation.GetIncome():F1}";

            LabelShrineValue.Text = $"{City.LocationScience.PeopleValue} / {City.LocationScience.PeopleMax}";
            LabelScienceInfo.Text = $"{City.Science.Value:F1} / {City.Science.Max:F1}";
            LabelScienceAdd.Text = $"+{City.LocationScience.GetIncome():F1}";

            LabelQuarryValue.Text = $"{City.StoneLocation.PeopleValue} / {City.StoneLocation.PeopleMax}";
            LabelStoneInfo.Text = $"{City.Stone.Value:F1} / {City.Stone.Max:F1}";
            LabelStoneAdd.Text = $"+{City.StoneLocation.GetIncome():F1}";

            LabelPopulation.Text = $"{City.People.FreePeople} / {City.People.Count}";

            LabeWood.Text = $"Wood ({City.Buildings.WoodPoints})";
            LabeStone.Text = $"Stone ({City.Buildings.StonePoints})";
            LabeScience.Text = $"Science ({City.Technologies.Points})";

            LabelDanger.Text = $"{City.Enemy.GetDanger(Turn):F2}%";
        }

        private void ButtonTurnClick(object sender, EventArgs e)
        {
            LabelTurn.Text = Turn.ToString();
            Turn++;
            City.Update();
            City.Technologies.UpdateSciencePoints();
            City.Buildings.UpgradePoints();
            City.People.UpdatePeopleCount();
            UpdateLabels();
            City.RandomEvent(Turn);
            UpdateLabels();
            City.CheckPeople();
        }

        private void ButtonTechnologiesClick(object sender, EventArgs e)
        {
            ScienceMenu.Top = Top;
            ScienceMenu.Left = Left;
            ScienceMenu.StartPosition = FormStartPosition.Manual;
            Hide();
            ScienceMenu.ShowDialog();
            Top = ScienceMenu.Top;
            Left = ScienceMenu.Left;
            Show();
            UpdateLabels();
        }

        private void ButtonBuildungClick(object sender, EventArgs e)
        {
            BuildingMenu.Top = Top;
            BuildingMenu.Left = Left;
            BuildingMenu.StartPosition = FormStartPosition.Manual;
            Hide();
            BuildingMenu.ShowDialog();
            Top = BuildingMenu.Top;
            Left = BuildingMenu.Left;
            Show();
            UpdateLabels();
        }
    }
}
