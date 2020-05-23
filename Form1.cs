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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        bool isGrandparent = false;

        private void PlanDayLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = PlanDayTabPage;
        }

        private void FoodLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = SmartFoodTabPage;
        }

        private void EnterHouseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = EnterHomeTabPage;
        }

        private void GrandparentLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isGrandparent = true;
            tabControl.SelectedTab = GrandparentTabPage;
        }

        private void PlanDayBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = HomePageTabPage;
        }

        private void SmartFoodBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = HomePageTabPage;
        }

        private void EnterHomeBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = HomePageTabPage;
        }

        private void EnterHomeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = LivingroomTabPage;
        }

        private void GoToBedroomLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = BedroomTabPage;
        }

        private void KitchenLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = KitchenTabPage;
        }

        private void BathroomLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = BathroomTabPage;
        }

        private void BedroomBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = LivingroomTabPage;
        }

        private void BathroomBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = BedroomTabPage;
        }

        private void TurnOnWaterHeaterButton_Click(object sender, EventArgs e)
        {
            if (TurnOnWaterHeaterButton.Text == "Turn On The Water Heater")
            {
                MessageBox.Show("The water heater is On! The water will be hot enough in 30 minutes.");
                TurnOnWaterHeaterButton.Text = "Turn Off The Water Heater";
            }
            else if (TurnOnWaterHeaterButton.Text == "Turn Off The Water Heater")
            {
                MessageBox.Show("The water heater is Off!");
                TurnOnWaterHeaterButton.Text = "Turn On The Water Heater";
            }
            

        }

        private void LivingroomBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = EnterHomeTabPage;
        }

        private void KitchenBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = LivingroomTabPage;
        }

        private void CoffeeMachineButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = ControlCoffeeMachineTabPage;
            CoffeeProgressBar.Value = 0;
            WaitTimeLabel.Text = " ";
        }

        private void WaterBoilerButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = WaterBoilerTabPage;
        }

        private void GrandparentBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isGrandparent = false;
            tabControl.SelectedTab = HomePageTabPage;
        }

        private void GrandparentLivingroomLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            tabControl.SelectedTab = GrandparentLivingroomTabPage;
            LivingroomFallTimer.Enabled = true;
            LivingroomFallTimer.Start();
            LivingroomFallTimer.Interval = 1000;
            
        }

        private void GrandparentBedroomLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            tabControl.SelectedTab = GrandparentBedroomTabPage;
            GrandparentBedroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbedroom;
            LivingroomFallTimer.Stop();
            DoNotAnswerLivingroomTimer.Stop();
            BedroomFallTimer.Enabled = true;
            BedroomFallTimer.Start();
            BedroomFallTimer.Interval = 1000;
        }
        
        
        private void LivingroomLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = GrandparentLivingroomTabPage;
            GrandparentLivingroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentlivingroom;
            BedroomFallTimer.Stop();
            DoNotAnswerBedroomTimer.Stop();
            LivingroomFallTimer.Enabled = true;
            LivingroomFallTimer.Start();
            LivingroomFallTimer.Interval = 1000;
            
        }

        
        private void GrandparentBathroomLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = GrandparentBathroomTabPage;
            GrandparentBathroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbathroom;
            BedroomFallTimer.Stop();
            DoNotAnswerBedroomTimer.Stop();
            BathroomFallTimer.Enabled = true;
            BathroomFallTimer.Start();
            BathroomFallTimer.Interval = 1000;
        }

        private void GrandparentBathroomBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            tabControl.SelectedTab = GrandparentBedroomTabPage;
            GrandparentBedroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbedroom;
            BathroomFallTimer.Stop();
            DoNotAnswerBathroomTimer.Stop();
            BedroomFallTimer.Enabled = true;
            BedroomFallTimer.Start();
            BedroomFallTimer.Interval = 1000;
        }

        private void GrandparentKitchenLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            tabControl.SelectedTab = GrandparentKitchenTabPage;
            GrandparentKitchenPictureBox.Image = SmartCityProject.Properties.Resources.grandparentkitchen;
            LivingroomFallTimer.Stop();
            DoNotAnswerLivingroomTimer.Stop();
            KitchenFallTimer.Enabled = true;
            KitchenFallTimer.Start();
            KitchenFallTimer.Interval = 1000;
        }

        private void GrandparentKitchenBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            tabControl.SelectedTab = GrandparentLivingroomTabPage;
            GrandparentLivingroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentlivingroom;
            KitchenFallTimer.Stop();
            DoNotAnswerKitchenTimer.Stop();
            LivingroomFallTimer.Enabled = true;
            LivingroomFallTimer.Start();
            LivingroomFallTimer.Interval = 1000;
        }

        private void GrandparentLivingroomBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LivingroomFallTimer.Enabled = false;
            tabControl.SelectedTab = GrandparentTabPage;
            GrandparentLivingroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentlivingroom;
            
        }


        private void ControlCoffeeMachineBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isGrandparent == true)
            {
                tabControl.SelectedTab = GrandparentKitchenTabPage;
                CoffeeTimer.Enabled = false;
            }
            else if (isGrandparent == false)
            {
                tabControl.SelectedTab = KitchenTabPage;
                CoffeeTimer.Enabled = false;
            }
        }

        private void ControlCoffeeMachinebutton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = ControlCoffeeMachineTabPage;
            CoffeeProgressBar.Value = 0;
            WaitTimeLabel.Text = " ";
            KitchenFallTimer.Stop();
            DoNotAnswerKitchenTimer.Stop();
        }

        private void CheckCoffeeButton_Click(object sender, EventArgs e)
        {
            CoffeeTimer.Enabled = true;
            CoffeeTimer.Start();
            CoffeeTimer.Interval = 1000;
            CoffeeProgressBar.Maximum = 10;
        }

        private void CoffeeTimer_Tick(object sender, EventArgs e)
        {
            if (CoffeeProgressBar.Value != 10)
            {
                CoffeeProgressBar.Value++;
            }
            else
            {

                CoffeeTimer.Stop();
                tabControl.SelectedTab = ControlCoffeeMachine2TabPage;
            }


        }

        private void CheckWaterButton_Click(object sender, EventArgs e)
        {
            WaterBoilerTimer.Enabled = true;
            WaterBoilerTimer.Start();
            WaterBoilerTimer.Interval = 1000;
            WaterBoilerProgressBar.Maximum = 10;
        }

        private void WaterBoilerTimer_Tick(object sender, EventArgs e)
        {
            if (WaterBoilerProgressBar.Value != 10)
            {
                WaterBoilerProgressBar.Value++;
            }
            else
            {

                WaterBoilerTimer.Stop();
                tabControl.SelectedTab = WaterBoiler2TabPage;
            }
        }
        
        
        private void WaterBoilerBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WaterBoilerTimer.Enabled = false;
            tabControl.SelectedTab = KitchenTabPage;
        }

        private void WaterBoiler2BackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WaterBoilerWaitTimer.Enabled = false;
            tabControl.SelectedTab = KitchenTabPage;
            
        }

        private void WaterBoiler2BackHomepageLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WaterBoilerWaitTimer.Enabled = false;
            tabControl.SelectedTab = HomePageTabPage;
        }

        private void ControlCoffeeMachine2BackHomepageLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = HomePageTabPage;
            WaitTimer.Enabled = false;
        }

        private void AddCoffeeButton_Click(object sender, EventArgs e)
        {
            CoffeeMachinePictureBox.Image = SmartCityProject.Properties.Resources._2;
        }

        private void AddWaterButton_Click(object sender, EventArgs e)
        {
            CoffeeMachinePictureBox.Image = SmartCityProject.Properties.Resources._3;
        }
        
        private void TurnOnButton_Click(object sender, EventArgs e)
        {
            CoffeeMachinePictureBox.Image = SmartCityProject.Properties.Resources._4;
            WaitTimer.Enabled = true;
            WaitTimer.Start();
            WaitTimer.Interval = 1000;
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            if (WaitTimeLabel.Text == " ")
            {
                WaitTimeLabel.Text = "10";
            }
            else if (WaitTimeLabel.Text == "10")
            {
                WaitTimeLabel.Text = "9";
            }
            else if (WaitTimeLabel.Text == "9")
            {
                WaitTimeLabel.Text = "8";
            }
            else if (WaitTimeLabel.Text == "8")
            {
                WaitTimeLabel.Text = "7";
            }
            else if (WaitTimeLabel.Text == "7")
            {
                WaitTimeLabel.Text = "6";
            }
            else if (WaitTimeLabel.Text == "6")
            {
                WaitTimeLabel.Text = "5";
            }
            else if (WaitTimeLabel.Text == "5")
            {
                WaitTimeLabel.Text = "4";
            }
            else if (WaitTimeLabel.Text == "4")
            {
                WaitTimeLabel.Text = "3";
            }
            else if (WaitTimeLabel.Text == "3")
            {
                WaitTimeLabel.Text = "2";
            }
            else if (WaitTimeLabel.Text == "2")
            {
                WaitTimeLabel.Text = "1";
            }
            else if (WaitTimeLabel.Text == "1")
            {
                WaitTimeLabel.Text = "0";
            }
            else if (WaitTimeLabel.Text == "0")
            {
                WaitTimer.Stop();
                CoffeeMachinePictureBox.Image = SmartCityProject.Properties.Resources._5;
                MessageBox.Show("Enjoy your coffee! :-)");
            }
        }
        
        private void ControlCoffeeMachine2BackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isGrandparent == true)
            {
                tabControl.SelectedTab = GrandparentKitchenTabPage;
                WaitTimer.Enabled = false;
            }
            else if (isGrandparent == false)
            {
                tabControl.SelectedTab = KitchenTabPage;
                WaitTimer.Enabled = false;
            }
        }

        private void AddTheWaterButton_Click(object sender, EventArgs e)
        {
            WaterBoilerPictureBox.Image = SmartCityProject.Properties.Resources.boiler2;
        }


        private void TurnOnWaterBoilerButton_Click(object sender, EventArgs e)
        {
            WaterBoilerPictureBox.Image = SmartCityProject.Properties.Resources.boiler2;
            WaterBoilerWaitTimer.Enabled = true;
            WaterBoilerWaitTimer.Start();
            WaterBoilerWaitTimer.Interval = 1000;
        }


        private void WaterBoilerWaitTimer_Tick(object sender, EventArgs e)
        {
            if (WaitTimeWaterBoilerLabel.Text == " ")
            {
                WaitTimeWaterBoilerLabel.Text = "10";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "10")
            {
                WaitTimeWaterBoilerLabel.Text = "9";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "9")
            {
                WaitTimeWaterBoilerLabel.Text = "8";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "8")
            {
                WaitTimeWaterBoilerLabel.Text = "7";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "7")
            {
                WaitTimeWaterBoilerLabel.Text = "6";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "6")
            {
                WaitTimeWaterBoilerLabel.Text = "5";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "5")
            {
                WaitTimeWaterBoilerLabel.Text = "4";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "4")
            {
                WaitTimeWaterBoilerLabel.Text = "3";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "3")
            {
                WaitTimeWaterBoilerLabel.Text = "2";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "2")
            {
                WaitTimeWaterBoilerLabel.Text = "1";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "1")
            {
                WaitTimeWaterBoilerLabel.Text = "0";
            }
            else if (WaitTimeWaterBoilerLabel.Text == "0")
            {
                WaterBoilerWaitTimer.Stop();
                WaterBoilerPictureBox.Image = SmartCityProject.Properties.Resources.cup;
                MessageBox.Show("Enjoy your boiled water! :-)");
            }
        }

        bool ligtsOnLivingroom = true;

        private void SwitchLivingroomPictureBox_Click(object sender, EventArgs e)
        {
            if (ligtsOnLivingroom == true)
            {
                LivingroomPictureBox.Image = SmartCityProject.Properties.Resources.livingroom2;
                LivingroomPictureBox.Refresh();
                ligtsOnLivingroom = false;
            }
            else if (ligtsOnLivingroom == false)
            {
                LivingroomPictureBox.Image = SmartCityProject.Properties.Resources.livingroom;
                LivingroomPictureBox.Refresh();
                ligtsOnLivingroom = true;
            }
        }

        private void ThermostatLivingroomPictureBox_Click(object sender, EventArgs e)
        {
            new ControlTemprature().Show();
        }

        bool lightOnBedroom = true;

        private void SwithBedroomPictureBox_Click(object sender, EventArgs e)
        {
            if (lightOnBedroom == true)
            {
                BedroomPictureBox.Image = SmartCityProject.Properties.Resources.bedroom2;
                BedroomPictureBox.Refresh();
                lightOnBedroom = false;
            }
            else if (lightOnBedroom == false)
            {
                BedroomPictureBox.Image = SmartCityProject.Properties.Resources.bedroom;
                BedroomPictureBox.Refresh();
                lightOnBedroom = true;
            }
        }

        private void ThermostatBedroomPictureBox_Click(object sender, EventArgs e)
        {
            new ControlTemprature().Show();
        }

        bool lightsOnBathroom = true;

        private void SwitchBathroomPictureBox_Click(object sender, EventArgs e)
        {
            if (lightsOnBathroom == true)
            {
                BathroomPictureBox.Image = SmartCityProject.Properties.Resources.bathroom2;
                BathroomPictureBox.Refresh();
                lightsOnBathroom = false;
            }
            else if (lightsOnBathroom == false)
            {
                BathroomPictureBox.Image = SmartCityProject.Properties.Resources.bathroom;
                BathroomPictureBox.Refresh();
                lightsOnBathroom = true;
            }
        }

        private void ThermostatBathroomPictureBox_Click(object sender, EventArgs e)
        {
            new ControlTemprature().Show();
        }

        bool lightsOnKitchen = true;

        private void SwithKitchenPictureBox_Click(object sender, EventArgs e)
        {
            if (lightsOnKitchen == true)
            {
                KitchenPictureBox.Image = SmartCityProject.Properties.Resources.kitchen2;
                KitchenPictureBox.Refresh();
                lightsOnKitchen = false;
            }
            else if (lightsOnKitchen == false)
            {
                KitchenPictureBox.Image = SmartCityProject.Properties.Resources.kitchen;
                KitchenPictureBox.Refresh();
                lightsOnKitchen = true;
            }
        }

        private void ThermostatKitchenPictureBox_Click(object sender, EventArgs e)
        {
            new ControlTemprature().Show();
        }

        bool lightsOnGrandparentLivingroom = true;

        private void SwitcheGrandparentLivingroomPictureBox_Click(object sender, EventArgs e)
        {
            if (lightsOnGrandparentLivingroom == true)
            {
                GrandparentLivingroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentlivingroom2;
                GrandparentLivingroomPictureBox.Refresh();
                lightsOnGrandparentLivingroom = false;
            }
            else if (lightsOnGrandparentLivingroom == false)
            {
                GrandparentLivingroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentlivingroom;
                GrandparentLivingroomPictureBox.Refresh();
                lightsOnGrandparentLivingroom = true;
            }
        }

        private void ThermostatGrandparentLivingroomPictureBox_Click(object sender, EventArgs e)
        {
            new ControlTemprature().Show();
        }

        bool lightsOnGrandparentBedroom = true;
        private void SwitcheGrandparentBedroomPictureBox_Click(object sender, EventArgs e)
        {
            if (lightsOnGrandparentBedroom == true)
            {
                GrandparentBedroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbedroom2;
                GrandparentBedroomPictureBox.Refresh();
                lightsOnGrandparentBedroom = false;
            }
            else if (lightsOnGrandparentBedroom == false)
            {
                GrandparentBedroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbedroom;
                GrandparentBedroomPictureBox.Refresh();
                lightsOnGrandparentBedroom = true;
            }
        }

        private void ThermostatGrandparentBedroomPictureBox_Click(object sender, EventArgs e)
        {
            new ControlTemprature().Show();
        }

        bool lightsOnGrandparentBathroom = true;

        private void SwitchGrandparentBathroomPictureBox_Click(object sender, EventArgs e)
        {
            if (lightsOnGrandparentBathroom == true)
            {
                GrandparentBathroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbathroom2;
                GrandparentBathroomPictureBox.Refresh();
                lightsOnGrandparentBathroom = false;
            }
            else if (lightsOnGrandparentBathroom == false)
            {
                GrandparentBathroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbathroom;
                GrandparentBathroomPictureBox.Refresh();
                lightsOnGrandparentBathroom = true;
            }
        }

        private void ThermostatGrandparentBathroomPictureBox_Click(object sender, EventArgs e)
        {
            new ControlTemprature().Show();
        }

        bool lightsOnGrandparentKitchen = true;

        private void SwithGrandparentKitchenPictureBox_Click(object sender, EventArgs e)
        {
            if (lightsOnGrandparentKitchen == true)
            {
                GrandparentKitchenPictureBox.Image = SmartCityProject.Properties.Resources.grandparentkitchen2;
                GrandparentKitchenPictureBox.Refresh();
                lightsOnGrandparentKitchen = false;
            }
            else if (lightsOnGrandparentKitchen == false)
            {
                GrandparentKitchenPictureBox.Image = SmartCityProject.Properties.Resources.grandparentkitchen;
                GrandparentKitchenPictureBox.Refresh();
                lightsOnGrandparentKitchen = true;
            }
        }

        private void ThermostatGrandparentKitchenPictureBox_Click(object sender, EventArgs e)
        {
            new ControlTemprature().Show();
        }



      

        public void ShowWayButton_Click(object sender, EventArgs e)
        {
            string beginValue = "";
            string endValue = "";
            string transferValue = "";
            string timeValue = "";
            string carPark = "";



            if (HomeRadioButton1.Checked)
            {
                beginValue = HomeRadioButton1.Text;
            }
            else if (WorkRadioButton1.Checked)
            {
                beginValue = WorkRadioButton1.Text;
            }
            else if (UnivercityRadioButton1.Checked)
            {
                beginValue = UnivercityRadioButton1.Text;
            }
            else if (BarRadioButton1.Checked)
            {
                beginValue = BarRadioButton1.Text;
            }

            if (HomeRadioButton2.Checked)
            {
                endValue = HomeRadioButton2.Text;
            }
            else if (WorkRadioButton2.Checked)
            {
                endValue = WorkRadioButton2.Text;
            }
            else if (UnivercityRadioButton2.Checked)
            {
                endValue = UnivercityRadioButton2.Text;
            }
            else if (BarRadioButton2.Checked)
            {
                endValue = BarRadioButton2.Text;
            }

            

            if (HomeRadioButton1.Checked == true && HomeRadioButton2.Checked == true)
            {
                MessageBox.Show("Already there! WOW, how fast can a man be!"+"\n"+"No, seriously, your location can't be the same with your destination.");
            }
            else if (WorkRadioButton1.Checked == true && WorkRadioButton2.Checked == true)
            {
                MessageBox.Show("Already there! WOW, how fast can a man be!" + "\n" + "No, seriously, your location can't be the same with your destination.");
            }
            else if (UnivercityRadioButton1.Checked == true && UnivercityRadioButton2.Checked == true)
            {
                MessageBox.Show("Already there! WOW, how fast can a man be!" + "\n" + "No, seriously, your location can't be the same with your destination.");
            }
            else if (BarRadioButton1.Checked == true && BarRadioButton2.Checked == true)
            {
                MessageBox.Show("Already there! WOW, how fast can a man be!" + "\n" + "No, seriously, your location can't be the same with your destination.");
            }
            else
            {
                if (CarRadioButton.Checked)
                {
                    transferValue = CarRadioButton.Text;
                    MapPictureBox.Image = SmartCityProject.Properties.Resources.bycar;
                    tabControl.SelectedTab = MapTabPage;
                    carPark = "There is a parking spot 400 meters away from your destination to park your car.";


                }
                else if (BicycleRadioButton.Checked)
                {
                    transferValue = BicycleRadioButton.Text;
                    MapPictureBox.Image = SmartCityProject.Properties.Resources.bybicycle;
                    tabControl.SelectedTab = MapTabPage;


                }
                else if (BusRadioButton.Checked)
                {
                    transferValue = BusRadioButton.Text;
                    MapPictureBox.Image = SmartCityProject.Properties.Resources.bybusortrain;
                    tabControl.SelectedTab = MapTabPage;

                }
                else if (TrainRadioButton.Checked)
                {
                    transferValue = TrainRadioButton.Text;
                    MapPictureBox.Image = SmartCityProject.Properties.Resources.bybusortrain;
                    tabControl.SelectedTab = MapTabPage;


                }
                else if (ByFootRadioButton.Checked)
                {
                    transferValue = ByFootRadioButton.Text;
                    MapPictureBox.Image = SmartCityProject.Properties.Resources.byfoot;
                    tabControl.SelectedTab = MapTabPage;

                }
                timeValue = TimeComboBox.Text;

                InformationDestinationLabel.Text = "You want to go from " + beginValue + " to " + endValue + " with " + transferValue + " at " + timeValue + ". " + "Follow the line on the map and you will reach your destination." + carPark;
                TimeComboBox.Text = "Choose time";
                foreach (TabPage page in tabControl.TabPages)
                {
                    foreach (Control c in groupBox1.Controls)
                    {
                        if (c is RadioButton)
                        {
                            ((RadioButton)c).Checked = false;
                        }
                    }
                    foreach (Control c in groupBox2.Controls)
                    {
                        if (c is RadioButton)
                        {
                            ((RadioButton)c).Checked = false;
                        }
                    }
                    foreach (Control c in groupBox3.Controls)
                    {
                        if (c is RadioButton)
                        {
                            ((RadioButton)c).Checked = false;
                        }
                    }
                }

            }
            }





            

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            double totalCost = 0;

            if (FCCheckBox.Checked)
            {
                double FCcost = Convert.ToDouble(FCPrice.Text);
                int FCquantity = Convert.ToInt32(FCNumericUpDown.Value);
                double FCtotal = FCcost * FCquantity;
                totalCost = totalCost + FCtotal;
            }

            if (CCheckBox.Checked)
            {
                double Ccost = Convert.ToDouble(CPrice.Text);
                int Cquantity = Convert.ToInt32(CNumericUpDown.Value);
                double Ctotal = Ccost * Cquantity;
                totalCost = totalCost + Ctotal;
            }

            if (ECheckBox.Checked)
            {
                double Ecost = Convert.ToDouble(EPrice.Text);
                int Equantity = Convert.ToInt32(ENumericUpDown.Value);
                double Etotal = Ecost * Equantity;
                totalCost = totalCost + Etotal;
            }

            if (FJCheckBox.Checked)
            {
                double FJcost = Convert.ToDouble(FJPrice.Text);
                int FJquantity = Convert.ToInt32(FJNumericUpDown.Value);
                double FJtotal = FJcost * FJquantity;
                totalCost = totalCost + FJtotal;
            }

            if (LCheckBox.Checked)
            {
                double Lcost = Convert.ToDouble(LPrice.Text);
                int Lquantity = Convert.ToInt32(LNumericUpDown.Value);
                double Ltotal = Lcost * Lquantity;
                totalCost = totalCost + Ltotal;

            }

            if (SCheckBox.Checked)
            {
                double Scost = Convert.ToDouble(SPrice.Text);
                int Squantity = Convert.ToInt32(SNumericUpDown.Value);
                double Stotal = Scost * Squantity;
                totalCost = totalCost + Stotal;
            }

            if (NCheckBox.Checked)
            {
                double Ncost = Convert.ToDouble(NPrice.Text);
                int Nquantity = Convert.ToInt32(NNumericUpDown.Value);
                double Ntotal = Ncost * Nquantity;
                totalCost = totalCost + Ntotal;
            }

            if (CarbCheckBox.Checked)
            {
                double Carbcost = Convert.ToDouble(CarbPrice.Text);
                int Carbquantity = Convert.ToInt32(CarbNumericUpDown.Value);
                double Carbtotal = Carbcost * Carbquantity;
                totalCost = totalCost + Carbtotal;
            }

            if (BCheckBox.Checked)
            {
                double Bcost = Convert.ToDouble(BPrice.Text);
                int Bquantity = Convert.ToInt32(BNumericUpDown.Value);
                double Btotal = Bcost * Bquantity;
                totalCost = totalCost + Btotal;
            }

            if (SandCheckBox.Checked)
            {
                double Sandcost = Convert.ToDouble(SandPrice.Text);
                int Sandquantity = Convert.ToInt32(SandNumericUpDown.Value);
                double Sandtotal = Sandcost * Sandquantity;
                totalCost = totalCost + Sandtotal;
            }

            if (PSCheckBox.Checked)
            {
                double PScost = Convert.ToDouble(PSPrice.Text);
                int PSquantity = Convert.ToInt32(PSNumericUpDown.Value);
                double PStotal = PScost * PSquantity;
                totalCost = totalCost + PStotal;
            }

            if (BurCheckBox.Checked)
            {
                double Burcost = Convert.ToDouble(BurPrice.Text);
                int Burquantity = Convert.ToInt32(BurNumericUpDown.Value);
                double Burtotal = Burcost * Burquantity;
                totalCost = totalCost + Burtotal;
            }

            if (YCheckBox.Checked)
            {
                double Ycost = Convert.ToDouble(YPrice.Text);
                int Yquantity = Convert.ToInt32(YNumericUpDown.Value);
                double Ytotal = Ycost * Yquantity;
                totalCost = totalCost + Ytotal;
            }

            if (APCheckBox.Checked)
            {
                double APcost = Convert.ToDouble(APPrice.Text);
                int APquantity = Convert.ToInt32(APNumericUpDown.Value);
                double APtotal = APcost * APquantity;
                totalCost = totalCost + APtotal;
            }

            if (FSCheckBox.Checked)
            {
                double FScost = Convert.ToDouble(FSPrice.Text);
                int FSquantity = Convert.ToInt32(FSNumericUpDown.Value);
                double FStotal = FScost * FSquantity;
                totalCost = totalCost + FStotal;
            }

            if (PCheckBox.Checked)
            {
                double Pcost = Convert.ToDouble(PPrice.Text);
                int Pquantity = Convert.ToInt32(PNumericUpDown.Value);
                double Ptotal = Pcost * Pquantity;
                totalCost = totalCost + Ptotal;
            }

            foreach (TabPage page in tabControl.TabPages)
            {
                foreach (Control c in SmartFoodTabPage.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = false;
                    }
                    else if (c is NumericUpDown)
                    {
                        ((NumericUpDown)c).Value = 0;
                    }
                }
            }
            double convertedPrice = Convert.ToDouble(TotalCost.Text);
            convertedPrice = convertedPrice + totalCost;
            string TotalPrice = Convert.ToString(convertedPrice);
            TotalCost.Text = TotalPrice;

        }
        
        
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            foreach (TabPage page in tabControl.TabPages)
            {
                foreach (Control c in SmartFoodTabPage.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = false;
                    }
                    else if (c is NumericUpDown)
                    {
                        ((NumericUpDown)c).Value = 0;
                    }
                }
            }
        }
        
        private void CardTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed!");
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (CashRadioButton.Checked == true)
            {
                MessageBox.Show("Thanks for your order!");
                CardTextBox.Text = "";
                CashRadioButton.Checked = true;
                TotalCost.Text = "0";
            }

            if (CardRadioButton.Checked == true)
            {
                if (CardTextBox.Text == "")
                {
                    MessageBox.Show("Please fill in the number of your credit card.");
                }

                else
                {
                    MessageBox.Show("Thanks for your order!");
                    CardTextBox.Text = "";
                    CashRadioButton.Checked = true;
                    TotalCost.Text = "0";
                }

            }
        }

        int livingroomTime = 0;
        private void LivingroomFallTimer_Tick(object sender, EventArgs e)
        {
            livingroomTime++;
            if (livingroomTime == 5)
            {
                LivingroomFallTimer.Stop();
                livingroomTime = 0;
                GrandparentLivingroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentlivingroomfallen;
                DoNotAnswerLivingroomTimer.Enabled = true;
                DoNotAnswerLivingroomTimer.Start();
                DoNotAnswerLivingroomTimer.Interval = 1000;
                switch (MessageBox.Show("Are you OK?",
              "WonderWord",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question))
                {


                    case DialogResult.Yes:
                        DoNotAnswerLivingroomTimer.Stop();
                        livingroomTime2 = 0;
                        GrandparentLivingroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentlivingroom;
                        switch (MessageBox.Show("Do you want to order any supplies from the Super Market?",
                           "WonderWord",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                tabControl.SelectedTab = SuperMarketTabPage;
                                break;

                            case DialogResult.No:
                                break;
                        }
                        break;
                        

                    case DialogResult.No:
                        DoNotAnswerLivingroomTimer.Stop();
                        livingroomTime2 = 0;
                        switch (MessageBox.Show("Do you need a doctor?",
                           "WonderWord",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question))
                        {


                            case DialogResult.Yes:
                                MessageBox.Show("A doctor will be there immediately");
                                GrandparentLivingroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentlivingroomnurse;
                                break;

                            case DialogResult.No:
                                GrandparentLivingroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentlivingroom;
                                break;


                        }
                        break;
                }

            }
        }

        int livingroomTime2 = 0;
        private void DoNotAnswerLivingroomTimer_Tick(object sender, EventArgs e)
        {
            livingroomTime2++;
            if (livingroomTime2 == 5)
            {
                
                MessageBox.Show("Because you are not responding to the system, we will call the nearest hospital and your family to come and help you.");
                GrandparentLivingroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentlivingroom;

            }
        }

        int bedroomTime = 0;
        private void BedroomFallTimer_Tick(object sender, EventArgs e)
        {
            bedroomTime++;
            if (bedroomTime == 5)
            {
                BedroomFallTimer.Stop();
                bedroomTime = 0;
                GrandparentBedroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbedroomfallen;
                DoNotAnswerBedroomTimer.Enabled = true;
                DoNotAnswerBedroomTimer.Start();
                DoNotAnswerBedroomTimer.Interval = 1000;
                switch (MessageBox.Show("Are you OK?",
              "WonderWord",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question))
                {


                    case DialogResult.Yes:
                        DoNotAnswerBedroomTimer.Stop();
                        bedroomTime2 = 0;
                        GrandparentBedroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbedroom;
                        switch (MessageBox.Show("Do you want to order any supplies from the Super Market?",
                           "WonderWord",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                tabControl.SelectedTab = SuperMarketTabPage;
                                break;

                            case DialogResult.No:
                                break;
                        }
                        break;

                    case DialogResult.No:
                        DoNotAnswerBedroomTimer.Stop();
                        bedroomTime2 = 0;
                        switch (MessageBox.Show("Do you need a doctor?",
                           "WonderWord",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question))
                        {


                            case DialogResult.Yes:
                                MessageBox.Show("A doctor will be there immediately");
                                GrandparentBedroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbedroomnurse;
                                break;

                            case DialogResult.No:
                                GrandparentBedroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbedroom;
                                break;


                        }
                        break;
                }

            }
        }

        int bedroomTime2 = 0;
        private void DoNotAnswerBedroomTimer_Tick(object sender, EventArgs e)
        {
            bedroomTime2++;
            if (bedroomTime2 == 5)
            {

                MessageBox.Show("Because you are not responding to the system, we will call the nearest hospital and your family to come and help you.");
                GrandparentBedroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbedroom;

            }
        }

        int bathroomTime = 0;

        private void BathroomFallTimer_Tick(object sender, EventArgs e)
        {
            bathroomTime++;
            if (bathroomTime == 5)
            {
                BathroomFallTimer.Stop();
                bathroomTime = 0;
                DoNotAnswerBathroomTimer.Enabled = true;
                DoNotAnswerBathroomTimer.Start();
                DoNotAnswerBathroomTimer.Interval = 1000;
                GrandparentBathroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbathroomfallen;
                switch (MessageBox.Show("Are you OK?",
              "WonderWord",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        GrandparentBathroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbathroom;
                        DoNotAnswerBathroomTimer.Stop();
                        bathroomTime2 = 0;
                        switch (MessageBox.Show("Do you want to order any supplies from the Super Market?",
                           "WonderWord",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                tabControl.SelectedTab = SuperMarketTabPage;
                                break;

                            case DialogResult.No:
                                break;
                        }
                        break;

                    case DialogResult.No:
                        DoNotAnswerBathroomTimer.Stop();
                        bathroomTime2 = 0;
                        switch (MessageBox.Show("Do you need a doctor?",
                           "WonderWord",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question))
                        {


                            case DialogResult.Yes:
                                MessageBox.Show("A doctor will be there immediately");
                                GrandparentBathroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbathroomnurse;
                                break;

                            case DialogResult.No:
                                GrandparentBathroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbathroom;
                                break;


                        }
                        break;
                }

            }
        }

        int bathroomTime2 = 0;

        private void DoNotAnswerBathroomTimer_Tick(object sender, EventArgs e)
        {
            bathroomTime2++;
            if (bathroomTime2 == 5)
            {

                MessageBox.Show("Because you are not responding to the system, we will call the nearest hospital and your family to come and help you.");
                GrandparentBathroomPictureBox.Image = SmartCityProject.Properties.Resources.grandparentbathroom;

            }
        }

        int kitchenTime = 0;

        private void KitchenFallTimer_Tick(object sender, EventArgs e)
        {
            kitchenTime++;
            if (kitchenTime == 5)
            {
                KitchenFallTimer.Stop();
                kitchenTime = 0;
                GrandparentKitchenPictureBox.Image = SmartCityProject.Properties.Resources.grandparentkitchenfallen;
                DoNotAnswerKitchenTimer.Enabled = true;
                DoNotAnswerKitchenTimer.Start();
                DoNotAnswerKitchenTimer.Interval = 1000;
                switch (MessageBox.Show("Are you OK?",
              "WonderWord",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question))
                {


                    case DialogResult.Yes:
                        DoNotAnswerKitchenTimer.Stop();
                        kitchenTime2 = 0;
                        GrandparentKitchenPictureBox.Image = SmartCityProject.Properties.Resources.grandparentkitchen;
                        switch (MessageBox.Show("Do you want to order any supplies from the Super Market?",
                           "WonderWord",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                tabControl.SelectedTab = SuperMarketTabPage;
                                break;

                            case DialogResult.No:
                                break;
                        }
                        break;

                    case DialogResult.No:
                        DoNotAnswerKitchenTimer.Stop();
                        kitchenTime2 = 0;
                        switch (MessageBox.Show("Do you need a doctor?",
                           "WonderWord",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question))
                        {


                            case DialogResult.Yes:
                                MessageBox.Show("A doctor will be there immediately");
                                GrandparentKitchenPictureBox.Image = SmartCityProject.Properties.Resources.grandparentkitchennurse;
                                break;

                            case DialogResult.No:
                                GrandparentKitchenPictureBox.Image = SmartCityProject.Properties.Resources.grandparentkitchen;
                                break;


                        }
                        break;
                }

            }
        }

        int kitchenTime2 = 0;

        private void DoNotAnswerKitchenTimer_Tick(object sender, EventArgs e)
        {
            kitchenTime2++;
            if (kitchenTime2 == 5)
            {

                MessageBox.Show("Because you are not responding to the system, we will call the nearest hospital and your family to come and help you.");
                GrandparentKitchenPictureBox.Image = SmartCityProject.Properties.Resources.grandparentkitchen;

            }
        }

        private void OrderMapButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = SmartFoodTabPage;
        }

        private void MapBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = HomePageTabPage;
        }

        bool tvON = true;

        private void TVButton_Click(object sender, EventArgs e)
        {
            if (tvON == true && lightOnBedroom == true)
            {
                BedroomPictureBox.Image = SmartCityProject.Properties.Resources.bedroom3;
                BedroomPictureBox.Refresh();
                TVButton.BackColor = Color.Green;
                TVButton.Text = "Turn On TV";
                tvON = false;
            }
            else if (tvON == true && lightOnBedroom == false)
            {
                BedroomPictureBox.Image = SmartCityProject.Properties.Resources.bedroom4;
                BedroomPictureBox.Refresh();
                TVButton.BackColor = Color.Green;
                TVButton.Text = "Turn On TV";
                tvON = false;
            }
            else if (tvON == false && lightOnBedroom == true)
            {
                BedroomPictureBox.Image = SmartCityProject.Properties.Resources.bedroom;
                BedroomPictureBox.Refresh();
                TVButton.BackColor = Color.Red;
                TVButton.Text = "Turn Off TV";
                tvON = true;
            }
            else if (tvON == false && lightOnBedroom == false)
            {
                BedroomPictureBox.Image = SmartCityProject.Properties.Resources.bedroom2;
                BedroomPictureBox.Refresh();
                TVButton.BackColor = Color.Red;
                TVButton.Text = "Turn Off TV";
                tvON = true;
            }
        }




        private void AddToCartSuperMarketButton_Click(object sender, EventArgs e)
        {
            double totalCost2 = 0;

            if (ApplesCheckBox.Checked)
            {
                double Applescost = Convert.ToDouble(ApplesPrice.Text);
                int Applesquantity = Convert.ToInt32(ApplesNumericUpDown.Value);
                double Applestotal = Applescost * Applesquantity;
                totalCost2 = totalCost2 + Applestotal;
            }
          
            if (BananasCheckBox.Checked)
            {
                double Bananascost = Convert.ToDouble(BananasPrice.Text);
                int Bananasquantity = Convert.ToInt32(BananasNumericUpDown.Value);
                double Bananastotal = Bananascost * Bananasquantity;
                totalCost2 = totalCost2 + Bananastotal;
            }

            if (PeppersCheckBox.Checked)
            {
                double Pepperscost = Convert.ToDouble(PeppersPrice.Text);
                int Peppersquantity = Convert.ToInt32(PeppersNumericUpDown.Value);
                double Pepperstotal = Pepperscost * Peppersquantity;
                totalCost2 = totalCost2 + Pepperstotal;
            }

            if (PeppersCheckBox.Checked)
            {
                double Pepperscost = Convert.ToDouble(PeppersPrice.Text);
                int Peppersquantity = Convert.ToInt32(PeppersNumericUpDown.Value);
                double Pepperstotal = Pepperscost * Peppersquantity;
                totalCost2 = totalCost2 + Pepperstotal;
            }

            if (LettuceCheckBox.Checked)
            {
                double Lettucecost = Convert.ToDouble(LettucePrice.Text);
                int Lettucequantity = Convert.ToInt32(LettuceNumericUpDown.Value);
                double Lettucetotal = Lettucecost * Lettucequantity;
                totalCost2 = totalCost2 + Lettucetotal;
            }

            if (TomatoesCheckBox.Checked)
            {
                double Tomatoescost = Convert.ToDouble(TomatoesPrice.Text);
                int Tomatoesquantity = Convert.ToInt32(TomatoesNumericUpDown.Value);
                double Tomatoestotal = Tomatoescost * Tomatoesquantity;
                totalCost2 = totalCost2 + Tomatoestotal;
            }

            if (PotatoesCheckBox.Checked)
            {
                double Potatoescost = Convert.ToDouble(PotatoesPrice.Text);
                int Potatoesquantity = Convert.ToInt32(PotatoesNumericUpDown.Value);
                double Potatoestotal = Potatoescost * Potatoesquantity;
                totalCost2 = totalCost2 + Potatoestotal;
            }


            if (MilkCheckBox.Checked)
            {
                double Milkcost = Convert.ToDouble(MilkPrice.Text);
                int Milkquantity = Convert.ToInt32(MilkNumericUpDown.Value);
                double Milktotal = Milkcost * Milkquantity;
                totalCost2 = totalCost2 + Milktotal;
            }

            if (CheeseCheckBox.Checked)
            {
                double Cheesecost = Convert.ToDouble(CheesePrice.Text);
                int Cheesequantity = Convert.ToInt32(CheeseNumericUpDown.Value);
                double Cheesetotal = Cheesecost * Cheesequantity;
                totalCost2 = totalCost2 + Cheesetotal;
            }

            if (YogurtCheckBox.Checked)
            {
                double Yogurtcost = Convert.ToDouble(YogurtPrice.Text);
                int Yogurtquantity = Convert.ToInt32(YogurtNumericUpDown.Value);
                double Yogurttotal = Yogurtcost * Yogurtquantity;
                totalCost2 = totalCost2 + Yogurttotal;
            }

            if (CreamCheckBox.Checked)
            {
                double Creamcost = Convert.ToDouble(CreamPrice.Text);
                int Creamquantity = Convert.ToInt32(CreamNumericUpDown.Value);
                double Creamtotal = Creamcost * Creamquantity;
                totalCost2 = totalCost2 + Creamtotal;
            }

            if (ButterCheckBox.Checked)
            {
                double Buttercost = Convert.ToDouble(ButterPrice.Text);
                int Butterquantity = Convert.ToInt32(ButterNumericUpDown.Value);
                double Buttertotal = Buttercost * Butterquantity;
                totalCost2 = totalCost2 + Buttertotal;
            }

            if (ChickenCheckBox.Checked)
            {
                double Chickencost = Convert.ToDouble(ChickenPrice.Text);
                int Chickenquantity = Convert.ToInt32(ChickenNumericUpDown.Value);
                double Chickentotal = Chickencost * Chickenquantity;
                totalCost2 = totalCost2 + Chickentotal;
            }

            if (PorkCheckBox.Checked)
            {
                double Porkcost = Convert.ToDouble(PorkPrice.Text);
                int Porkquantity = Convert.ToInt32(PorkNumericUpDown.Value);
                double Porktotal = Porkcost * Porkquantity;
                totalCost2 = totalCost2 + Porktotal;
            }

            if (SausagesCheckBox.Checked)
            {
                double Sausagescost = Convert.ToDouble(SausagesPrice.Text);
                int Sausagesquantity = Convert.ToInt32(SausagesNumericUpDown.Value);
                double Sausagestotal = Sausagescost * Sausagesquantity;
                totalCost2 = totalCost2 + Sausagestotal;
            }

            if (HamCheckBox.Checked)
            {
                double Hamcost = Convert.ToDouble(HamPrice.Text);
                int Hamquantity = Convert.ToInt32(HamNumericUpDown.Value);
                double Hamtotal = Hamcost * Hamquantity;
                totalCost2 = totalCost2 + Hamtotal;
            }

            if (BaconCheckBox.Checked)
            {
                double Baconcost = Convert.ToDouble(BaconPrice.Text);
                int Baconquantity = Convert.ToInt32(BaconNumericUpDown.Value);
                double Bacontotal = Baconcost * Baconquantity;
                totalCost2 = totalCost2 + Bacontotal;
            }

             if (TurkeyCheckBox.Checked)
            {
                double Turkeycost = Convert.ToDouble(TurkeyPrice.Text);
                int Turkeyquantity = Convert.ToInt32(TurkeyNumericUpDown.Value);
                double Turkeytotal = Turkeycost * Turkeyquantity;
                totalCost2 = totalCost2 + Turkeytotal;
            }

             if (SpaggetiCheckBox.Checked)
             {
                 double Spaggeticost = Convert.ToDouble(SpaggetiPrice.Text);
                 int Spaggetiquantity = Convert.ToInt32(SpaggetiNumericUpDown.Value);
                 double Spaggetitotal = Spaggeticost * Spaggetiquantity;
                 totalCost2 = totalCost2 + Spaggetitotal;
             }

             if (RiceCheckBox.Checked)
             {
                 double Ricecost = Convert.ToDouble(RicePrice.Text);
                 int Ricequantity = Convert.ToInt32(RiceNumericUpDown.Value);
                 double Ricetotal = Ricecost * Ricequantity;
                 totalCost2 = totalCost2 + Ricetotal;
             }

             if (OliveOilCheckBox.Checked)
             {
                 double OliveOilcost = Convert.ToDouble(OliveOilPrice.Text);
                 int OliveOilquantity = Convert.ToInt32(OliveOilNumericUpDown.Value);
                 double OliveOiltotal = OliveOilcost * OliveOilquantity;
                 totalCost2 = totalCost2 + OliveOiltotal;
             }

             if (VinegarCheckBox.Checked)
             {
                 double Vinegarcost = Convert.ToDouble(VinegarPrice.Text);
                 int Vinegarquantity = Convert.ToInt32(VinegarNumericUpDown.Value);
                 double Vinegartotal = Vinegarcost * Vinegarquantity;
                 totalCost2 = totalCost2 + Vinegartotal;
             }

             if (SugarCheckBox.Checked)
             {
                 double Sugarcost = Convert.ToDouble(SugarPrice.Text);
                 int Sugarquantity = Convert.ToInt32(SugarNumericUpDown.Value);
                 double Sugartotal = Sugarcost * Sugarquantity;
                 totalCost2 = totalCost2 + Sugartotal;
             }

             if (CornFlakesCheckBox.Checked)
             {
                 double CornFlakescost = Convert.ToDouble(CornFlakesPrice.Text);
                 int CornFlakesquantity = Convert.ToInt32(CornFlakesNumericUpDown.Value);
                 double CornFlakestotal = CornFlakescost * CornFlakesquantity;
                 totalCost2 = totalCost2 + CornFlakestotal;
             }

             if (ChipsCheckBox.Checked)
             {
                 double Chipscost = Convert.ToDouble(ChipsPrice.Text);
                 int Chipsquantity = Convert.ToInt32(ChipsNumericUpDown.Value);
                 double Chipstotal = Chipscost * Chipsquantity;
                 totalCost2 = totalCost2 + Chipstotal;
             }

             if (ChocolateCheckBox.Checked)
             {
                 double Chocolatecost = Convert.ToDouble(ChocolatePrice.Text);
                 int Chocolatequantity = Convert.ToInt32(ChocolateNumericUpDown.Value);
                 double Chocolatetotal = Chocolatecost * Chocolatequantity;
                 totalCost2 = totalCost2 + Chocolatetotal;
             }

             if (BreadCheckBox.Checked)
             {
                 double Breadcost = Convert.ToDouble(BreadPrice.Text);
                 int Breadquantity = Convert.ToInt32(BreadNumericUpDown.Value);
                 double Breadtotal = Breadcost * Breadquantity;
                 totalCost2 = totalCost2 + Breadtotal;
             }

             if (SandwichCheckBox.Checked)
             {
                 double Sandwichcost = Convert.ToDouble(SandwichPrice.Text);
                 int Sandwichquantity = Convert.ToInt32(SandwichNumericUpDown.Value);
                 double Sandwichtotal = Sandwichcost * Sandwichquantity;
                 totalCost2 = totalCost2 + Sandwichtotal;
             }

             if (MeatBallsCheckBox.Checked)
             {
                 double MeatBallscost = Convert.ToDouble(MeatBallsPrice.Text);
                 int MeatBallsquantity = Convert.ToInt32(MeatBallsNumericUpDown.Value);
                 double MeatBallstotal = MeatBallscost * MeatBallsquantity;
                 totalCost2 = totalCost2 + MeatBallstotal;
             }

             if (PizzaCheckBox.Checked)
             {
                 double Pizzacost = Convert.ToDouble(PizzaPrice.Text);
                 int Pizzaquantity = Convert.ToInt32(PizzaNumericUpDown.Value);
                 double Pizzatotal = Pizzacost * Pizzaquantity;
                 totalCost2 = totalCost2 + Pizzatotal;
             }

             if (BurgerCheckBox.Checked)
             {
                 double Burgercost = Convert.ToDouble(BurgerPrice.Text);
                 int Burgerquantity = Convert.ToInt32(BurgerNumericUpDown.Value);
                 double Burgertotal = Burgercost * Burgerquantity;
                 totalCost2 = totalCost2 + Burgertotal;
             }

             if (RedWineCheckBox.Checked)
             {
                 double RedWinecost = Convert.ToDouble(RedWinePrice.Text);
                 int RedWinequantity = Convert.ToInt32(RedWineNumericUpDown.Value);
                 double RedWinetotal = RedWinecost * RedWinequantity;
                 totalCost2 = totalCost2 + RedWinetotal;
             }

             if (WhiteWineCheckBox.Checked)
             {
                 double WhiteWinecost = Convert.ToDouble(WhiteWinePrice.Text);
                 int WhiteWinequantity = Convert.ToInt32(WhiteWineNumericUpDown.Value);
                 double WhiteWinetotal = WhiteWinecost * WhiteWinequantity;
                 totalCost2 = totalCost2 + WhiteWinetotal;
             }

             if (SodaCheckBox.Checked)
             {
                 double Sodacost = Convert.ToDouble(SodaPrice.Text);
                 int Sodaquantity = Convert.ToInt32(SodaNumericUpDown.Value);
                 double Sodatotal = Sodacost * Sodaquantity;
                 totalCost2 = totalCost2 + Sodatotal;
             }

             if (CocaColaCheckBox.Checked)
             {
                 double CocaColacost = Convert.ToDouble(CocaColaPrice.Text);
                 int CocaColaquantity = Convert.ToInt32(CocaColaNumericUpDown.Value);
                 double CocaColatotal = CocaColacost * CocaColaquantity;
                 totalCost2 = totalCost2 + CocaColatotal;
             }

             if (WaterCheckBox.Checked)
             {
                 double Watercost = Convert.ToDouble(WaterPrice.Text);
                 int Waterquantity = Convert.ToInt32(WaterNumericUpDown.Value);
                 double Watertotal = Watercost * Waterquantity;
                 totalCost2 = totalCost2 + Watertotal;
             }

             if (RedbullCheckBox.Checked)
             {
                 double Redbullcost = Convert.ToDouble(RedbullPrice.Text);
                 int Redbullquantity = Convert.ToInt32(RedbullNumericUpDown.Value);
                 double Redbulltotal = Redbullcost * Redbullquantity;
                 totalCost2 = totalCost2 + Redbulltotal;
             }

             if (JuiceCheckBox.Checked)
             {
                 double Juicecost = Convert.ToDouble(JuicePrice.Text);
                 int Juicequantity = Convert.ToInt32(JuiceNumericUpDown.Value);
                 double Juicetotal = Juicecost * Juicequantity;
                 totalCost2 = totalCost2 + Juicetotal;
             }

             if (DeodorantCheckBox.Checked)
             {
                 double Deodorantcost = Convert.ToDouble(DeodorantPrice.Text);
                 int Deodorantquantity = Convert.ToInt32(DeodorantNumericUpDown.Value);
                 double Deodoranttotal = Deodorantcost * Deodorantquantity;
                 totalCost2 = totalCost2 + Deodoranttotal;
             }

             if (PadsCheckBox.Checked)
             {
                 double Padscost = Convert.ToDouble(PadsPrice.Text);
                 int Padsquantity = Convert.ToInt32(PadsNumericUpDown.Value);
                 double Padstotal = Padscost * Padsquantity;
                 totalCost2 = totalCost2 + Padstotal;
             }

             if (ToothpasteCheckBox.Checked)
             {
                 double Toothpastecost = Convert.ToDouble(ToothpastePrice.Text);
                 int Toothpastequantity = Convert.ToInt32(ToothpasteNumericUpDown.Value);
                 double Toothpastetotal = Toothpastecost * Toothpastequantity;
                 totalCost2 = totalCost2 + Toothpastetotal;
             }

             if (PaperCheckBox.Checked)
             {
                 double Papercost = Convert.ToDouble(PaperPrice.Text);
                 int Paperquantity = Convert.ToInt32(PaperNumericUpDown.Value);
                 double Papertotal = Papercost * Paperquantity;
                 totalCost2 = totalCost2 + Papertotal;
             }

             if (ShowerGelCheckBox.Checked)
             {
                 double ShowerGelcost = Convert.ToDouble(ShowerGelPrice.Text);
                 int ShowerGelquantity = Convert.ToInt32(ShowerGelNumericUpDown.Value);
                 double ShowerGeltotal = ShowerGelcost * ShowerGelquantity;
                 totalCost2 = totalCost2 + ShowerGeltotal;
             }

             if (LotionCheckBox.Checked)
             {
                 double Lotioncost = Convert.ToDouble(LotionPrice.Text);
                 int Lotionquantity = Convert.ToInt32(LotionNumericUpDown.Value);
                 double Lotiontotal = Lotioncost * Lotionquantity;
                 totalCost2 = totalCost2 + Lotiontotal;
             }

             if (ShampooCheckBox.Checked)
             {
                 double Shampoocost = Convert.ToDouble(ShampooPrice.Text);
                 int Shampooquantity = Convert.ToInt32(ShampooNumericUpDown.Value);
                 double Shampoototal = Shampoocost * Shampooquantity;
                 totalCost2 = totalCost2 + Shampoototal;
             }

             if (PerfumeCheckBox.Checked)
             {
                 double Perfumecost = Convert.ToDouble(PerfumePrice.Text);
                 int Perfumequantity = Convert.ToInt32(PerfumeNumericUpDown.Value);
                 double Perfumetotal = Perfumecost * Perfumequantity;
                 totalCost2 = totalCost2 + Perfumetotal;
             }

             if (ArielCheckBox.Checked)
             {
                 double Arielcost = Convert.ToDouble(ArielPrice.Text);
                 int Arielquantity = Convert.ToInt32(ArielNumericUpDown.Value);
                 double Arieltotal = Arielcost * Arielquantity;
                 totalCost2 = totalCost2 + Arieltotal;
             }

             if (SouplineCheckBox.Checked)
             {
                 double Souplinecost = Convert.ToDouble(SouplinePrice.Text);
                 int Souplinequantity = Convert.ToInt32(SouplineNumericUpDown.Value);
                 double Souplinetotal = Souplinecost * Souplinequantity;
                 totalCost2 = totalCost2 + Souplinetotal;
             }

             if (AjaxCheckBox.Checked)
             {
                 double Ajaxcost = Convert.ToDouble(AjaxPrice.Text);
                 int Ajaxquantity = Convert.ToInt32(AjaxNumericUpDown.Value);
                 double Ajaxtotal = Ajaxcost * Ajaxquantity;
                 totalCost2 = totalCost2 + Ajaxtotal;
             }

             if (KlinexCheckBox.Checked)
             {
                 double Klinexcost = Convert.ToDouble(KlinexPrice.Text);
                 int Klinexquantity = Convert.ToInt32(KlinexNumericUpDown.Value);
                 double Klinextotal = Klinexcost * Klinexquantity;
                 totalCost2 = totalCost2 + Klinextotal;
             }

             if (DettolCheckBox.Checked)
             {
                 double Dettolcost = Convert.ToDouble(DettolPrice.Text);
                 int Dettolquantity = Convert.ToInt32(DettolNumericUpDown.Value);
                 double Dettoltotal = Dettolcost * Dettolquantity;
                 totalCost2 = totalCost2 + Dettoltotal;
             }

             if (AirWickCheckBox.Checked)
             {
                 double AirWickcost = Convert.ToDouble(AirWickPrice.Text);
                 int AirWickquantity = Convert.ToInt32(AirWickNumericUpDown.Value);
                 double AirWicktotal = AirWickcost * AirWickquantity;
                 totalCost2 = totalCost2 + AirWicktotal;
             }

             foreach (TabPage page in tabControl.TabPages)
             {
                 foreach (Control c in SuperMarketPanel.Controls)
                 {
                     if (c is CheckBox)
                     {
                         ((CheckBox)c).Checked = false;
                     }
                     else if (c is NumericUpDown)
                     {
                         ((NumericUpDown)c).Value = 0;
                     }
                 }
             }
            double convertedPrice2 = Convert.ToDouble(TotalCostSuperMarket.Text);
            convertedPrice2 = convertedPrice2 + totalCost2;
            string TotalPrice2 = Convert.ToString(convertedPrice2);
            TotalCostSuperMarket.Text = TotalPrice2;



        }
        
        
        private void ClearAllSuperMarketButton_Click(object sender, EventArgs e)
        {
            foreach (TabPage page in tabControl.TabPages)
            {
                foreach (Control c in SuperMarketPanel.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = false;
                    }
                    else if (c is NumericUpDown)
                    {
                        ((NumericUpDown)c).Value = 0;
                    }
                }
            }
        }

        private void OrderSuppliesButton_Click(object sender, EventArgs e)
        {
            if (CashSuperMarketRadioButton.Checked == true)
            {
                MessageBox.Show("Thanks for your order!");
                CreditCardNumberTextBox.Text = "";
                CashSuperMarketRadioButton.Checked = true;
                TotalCostSuperMarket.Text = "0";
            }

            if (CreditCardSuperMarketRadioButton.Checked == true)
            {
                if (CreditCardNumberTextBox.Text == "")
                {
                    MessageBox.Show("Please fill in the number of your credit card.");
                }

                else
                {
                    MessageBox.Show("Thanks for your order!");
                    CreditCardNumberTextBox.Text = "";
                    CashSuperMarketRadioButton.Checked = true;
                    TotalCostSuperMarket.Text = "0";
                    
                }

            }
        }
        
        
        private void CreditCardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed!");
            }
        }

        
        private void BackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = HomePageTabPage;
        }

        

        private void OrderFromSuperMarketButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = SuperMarketTabPage;
            KitchenFallTimer.Stop();
            DoNotAnswerKitchenTimer.Stop();
        }

        private void OnlineHelpPictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help2PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help3PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help4PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help5PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help6PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help7PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help8PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help9PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help10PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help11PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help12PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help13PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

        private void Help14PictureBox_Click(object sender, EventArgs e)
        {
            new OnlineHelp().Show();
        }

    }
}      
