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
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }
        private void BuildingMenu_Activated(object sender, EventArgs e)
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

        private void bt_farm1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_farm2_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_farm3_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationFood(City.FoodLocation, City.Food, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_Sawmill1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_Sawmill2_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_Sawmill3_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.WoodLocation, City.Wood, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_Mine1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_Mine2_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_Mine3_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocation(City.StoneLocation, City.Stone, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_Shrine_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_Shrine2_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void bt_Shrine3_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var splited = ((string)button.Tag).Split(';');
            var type = (Buildings.BuildingType)int.Parse(splited[0]);
            City.Buildings.Build(type);
            UpdateStateLocationScience(City.LocationScience, City.Science, 0, 2, 10, 2);
            UpdateButtons(City.Buildings);
            lbl_BuildingPoints.Text = $"{City.Buildings.WoodPoints} / {City.Buildings.StonePoints}";
        }

        private void BuildingsMenu_Load(object sender, EventArgs e)
        {
            UpdateButtons(City.Buildings);
        }
    }
}
