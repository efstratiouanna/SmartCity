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
    public partial class OnlineHelp : Form
    {
        public OnlineHelp()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl1.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl1.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl1.Font, Brushes.Black, x, y);
        }

        

        private void OnlineHelp_Load(object sender, EventArgs e)
        {
         HomePageHelpLabel.Text = "1. Click on this link to easily make your day plan." +"\n"+
             "2. Click on this link to order online snacks and beverages." +"\n"+
            "3. Click on this link to enter your virtual home." +"\n"+
             "4. If you are an older person, click on this link to get access at your house (using cameras). ";


         PlanDayLabel.Text = "1. Select one of given locations."+"\n"+
             "2. Select one of given destinations."+"\n"+
             "3. Select one of given means of transfer."+"\n"+
             "4. Choose the time you want to be at your destination."+"\n"+
             "5. Click on this button to show the way."+"\n"+
             "6. Click on this link to return to the Home Page.";



         SmartFoodHelpLabel.Text = "1. Select the quantity of the product you want." + "\n" +
              "2. Check the products you want." + "\n" +
              "3. Click this button to clear all the selected items." + "\n" +
              "4. Click this button to add all the selected items at your cart." + "\n" +
              "5. Here you can see the total cost of your order." + "\n" +
              "6. Select a way of payment." + "\n" +
              "7. Click here to send your order."+"\n"+
              "8. Click on this link to return to the Home Page.";

         SuperMarketHelpLabel.Text = "1. Check the products you want." + "\n" +
               "2. Select the quantity of the product you want." + "\n" +
               "3. Click this button to clear all the selected items." + "\n" +
               "4. Click this button to add all the selected items at your cart." + "\n" +
               "5. Here you can see the total cost of your order." + "\n" +
               "6. Select a way of payment." + "\n" +
               "7. Click here to send your order." + "\n" +
               "8. Click on this link to return to the Home Page.";


         EnterHomeHelpLabel.Text = "1.Click on this link to return to the Home Page. " + "\n" +
              "2. Click on this button to get in the house.";


         LivingroomHelpLabel.Text = "1. Click on the switch to turn on/off the lights of the room."+"\n"+
             "2. Click on the thermostat to set the temprature of the room."+"\n"+
             "3. Click on this link to enter the bedroom."+"\n"+
             "4. Click on this link to enter the kitchen." + "\n"+
             "5. Click on this link to leave the house.";


        BedroomHelpLabel.Text = "1. Click on the switch to turn on/off the lights of the room."+"\n"+
             "2. Click on the thermostat to set the temprature of the room."+"\n"+
             "3. Click here to turn on/off the TV."+"\n"+
             "4. Click on this link to enter the bathroom." + "\n"+
             "5. Click on this link to return to the livingroom.";

        BathroomHelpLabel.Text = "1. Click on the switch to turn on/off the lights of the room." + "\n" +
             "2. Click on the thermostat to set the temprature of the room." + "\n" +
             "3. Click here to turn on/off the water heater." + "\n" +
             "4. Click on this link to return to the bedroom.";


        KitchenHelpLabel.Text = "1. Click on the switch to turn on/off the lights of the room." + "\n" +
             "2. Click on the thermostat to set the temprature of the room." + "\n" +
             "3. Click here to control the water boiler." + "\n" +
             "4. Click here to control the coffee machine." + "\n" +
             "5. Click on this link to return to the livingroom."; 



        GrandparentHomeHelpLabel.Text = "1. Click on this button to get in the house. " + "\n" +
              "2. Click on this link to return to the Home Page.";

        GrandparentLivingroomHelpLabel.Text = "1. Click on the switch to turn on/off the lights of the room." + "\n" +
             "2. Click on the thermostat to set the temprature of the room." + "\n" +
             "3. Click on this link to enter the kitchen." + "\n" +
             "4. Click on this link to enter the bedroom." + "\n" +
             "5. Click on this link to leave the house.";


        GrandparentBedroomHelpLabel.Text = "1. Click on the switch to turn on/off the lights of the room." + "\n" +
             "2. Click on the thermostat to set the temprature of the room." + "\n" +
             "3. Click on this link to enter the bathroom." + "\n" +
             "4. Click on this link to return to the livingroom.";

        GrandparentBathroomHelpLabel.Text = "1. Click on the switch to turn on/off the lights of the room." + "\n" +
             "2. Click on the thermostat to set the temprature of the room." + "\n" +
             "3. Click on this link to return to the bedroom.";


        GrandparentKitchenHelpLabel.Text = "1. Click on the switch to turn on/off the lights of the room." + "\n" +
             "2. Click on the thermostat to set the temprature of the room." + "\n" +
             "3. Click here to control the coffee machine." + "\n" +
             "4. Click here to order supplies from Super Market." + "\n" +
             "5. Click on this link to return to the livingroom."; 


        } 


        
    }
}
