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
    public partial class BuildingsMenu : Form
    {
        public GameCity City;

        public BuildingsMenu(GameCity city)
        {
            InitializeComponent();
            City = city;

        }

        public void UpdateButtons(Buildings building)
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control.Tag is string)
                {
                    var splited = ((string)control.Tag).Split(';');
                    var type = (Buildings.BuildingType)int.Parse(splited[0]);
                    var level = int.Parse(splited[1]);
                    control.Enabled = level - 1 == building.Levels[type]
                                  && building.WoodPoints > 0 && building.StonePoints > 0;
                }
            }
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }
        private void BuildingMenuActivated(object sender, EventArgs e)
        {
            UpdateButtons(City.Buildings);
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

        private void ButtonFarm1Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonFarm2Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonFarm3Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonSawmill1Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonSawmill2Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonSawmill3Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonMine1Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonMine2Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonMine3Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonShrine1Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonShrine2Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void ButtonShrine3Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            LabelBuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void BuildingsMenuLoad(object sender, EventArgs e)
        {
            UpdateButtons(City.Buildings);
        }
    }
}
