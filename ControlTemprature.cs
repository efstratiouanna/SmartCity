using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCityProject
{
    public partial class ControlTemprature : Form
    {
        public ControlTemprature()
        {
            InitializeComponent();
        }

        private void ApplyTempratureButton_Click(object sender, EventArgs e)
        {
            decimal livingroomTemprature = LivingroomNumericUpDown.Value;
            decimal kitchenTemprature = KitchenNumericUpDown.Value;
            decimal bedroomTemprature = BedroomNumericUpDown.Value;
            decimal bathroomTemprature = BathroomNumericUpDown.Value;
            MessageBox.Show("Temprature has been applied to all home's rooms!" + "\n" + "Livingroom: " + 
                livingroomTemprature + "°C  " + "Kitchen: " + kitchenTemprature + "°C  " + "Bedroom: " +
                bedroomTemprature + "°C  " + "Bathroom: " + bathroomTemprature + "°C");
            this.Hide();
        }
    }
}
