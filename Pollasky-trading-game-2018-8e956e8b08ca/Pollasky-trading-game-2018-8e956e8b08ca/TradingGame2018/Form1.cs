using System;
using System.Windows.Forms;

namespace TradingGame2018
{
    public partial class Form1 : Form
    {
        // Initialise the arrays we will need later
        Label[] items = new Label[6];
        Label[] prices = new Label[6];
        Label[] quant = new Label[6];
        
        // Seed the random number
        Random rand = new Random();

        // Create a structure that will allow us to group
        // information on each location to a single index
        public struct Locations
        {
            
            

            // Add the name of each location to the structure
            public string itemName;
           

            // In this version, price is 1 to 
            // whatever value you put in price
            public int price1;

            // variation is whatever you multiply
            // the base price by to make it lean high,
            // low or neutral
            public double variation1;

            public int price2;
            public double variation2;
            public int price3;
            public double variation3;
            public int price4;
            public double variation4;
            public int price5;
            public double variation5;
            public int price6;
            public double variation6;
        }

        // Create an array of locations
        Locations[] shops = new Locations[6];
        

        public Form1()
        {
            InitializeComponent();



            // Make sure all buy button clicks 
            // go to the same place
            buy1.Click += buy1_Click;
            buy2.Click += buy1_Click;
            buy3.Click += buy1_Click;
            buy4.Click += buy1_Click;
            buy5.Click += buy1_Click;
            buy6.Click += buy1_Click;

            sell1.Click += sell_Click;
            sell2.Click += sell_Click;
            sell3.Click += sell_Click;
            sell4.Click += sell_Click;
            sell5.Click += sell_Click;
            sell6.Click += sell_Click;
        

        }



        private void sell_Click(object sender, EventArgs e)
        {
            Button sentButton = (Button)sender;

            int index = int.Parse(sentButton.Tag.ToString());

            // Check that there are items to sell
            if (int.Parse(quant[index].Text) >= 1)
            {
                money.Text = (double.Parse(money.Text) + double.Parse(prices[index].Text)).ToString();
                quant[index].Text = (int.Parse(quant[index].Text) - 1).ToString();
            }
        }

        private void buy1_Click(object sender, EventArgs e)
        {
            // Cast the sender object as a button
            Button sentButton = (Button)sender;
            int index = int.Parse(sentButton.Tag.ToString());

            // Check that money is available to buy
            if (double.Parse(money.Text) - double.Parse(prices[index].Text)>=0) {
                money.Text = (double.Parse(money.Text) - double.Parse(prices[index].Text)).ToString();
                quant[index].Text = (int.Parse(quant[index].Text) + 1).ToString();
            }
        }
        
        private void setUpGame()
        {
            // Set up the arrays we will need
            items[0] = item1;
            items[1] = item2;
            items[2] = item3;
            items[3] = item4;
            items[4] = item5;
            items[5] = item6;
           

            prices[0] = price1;
            prices[1] = price2;
            prices[2] = price3;
            prices[3] = price4;
            prices[4] = price5;
            prices[5] = price6;

            quant[0] = quant1;
            quant[1] = quant2;
            quant[2] = quant3;
            quant[3] = quant4;
            quant[4] = quant5;
            quant[5] = quant6;



   

            

            // Populate the structures
            // Note: there are better ways of doing this

            //Australia
            //America
            //England
            //China
            //Japan
            //France
            shops[0].itemName = "CNY";
            shops[0].price1 = 10;
            shops[0].variation1 = 1.2;
            shops[0].price2 = 20;
            shops[0].variation2 = 1.4;
            shops[0].price3 = 30;
            shops[0].variation3 = 1.2;
            shops[0].price4 = 1;
            shops[0].variation4 = 1;
            shops[0].price5 = 5;
            shops[0].variation5 = 1.9;
            shops[0].price6 = 3;
            shops[0].variation6 = 3.8;

            shops[1].itemName = "AUD";
            shops[1].price1 = 1;
            shops[1].variation1 = 1;
            shops[1].price2 = 10;
            shops[1].variation2 = 1.8;
            shops[1].price3 = 15;
            shops[1].variation3 = 1.9;
            shops[1].price4 = 30;
            shops[1].variation4 = 0.8;
            shops[1].price5 = 5;
            shops[1].variation5 = 1.9;
            shops[1].price6 = 3;
            shops[1].variation6 = 3.8;

            shops[2].itemName = "USD";
            shops[2].price1 = 11;
            shops[2].variation1 = 1.9;
            shops[2].price2 = 1;
            shops[2].variation2 = 1;
            shops[2].price3 = 25;
            shops[2].variation3 = 1.2;
            shops[2].price4 = 10;
            shops[2].variation4 = 2.8;
            shops[2].price5 = 5;
            shops[2].variation5 = 1.9;
            shops[2].price6 = 3;
            shops[2].variation6 = 3.8;

            shops[3].itemName = "JPY";
            shops[3].price1 = 8;
            shops[3].variation1 = 1.9;
            shops[3].price2 = 1;
            shops[3].variation2 = 1.8;
            shops[3].price3 = 5;
            shops[3].variation3 = 1.9;
            shops[3].price4 = 3;
            shops[3].variation4 = 3.8;
            shops[3].price5 = 1;
            shops[3].variation5 = 1;
            shops[3].price6 = 3;
            shops[3].variation6 = 3.8;

            shops[4].itemName = "GBP";
            shops[4].price1 = 8;
            shops[4].variation1 = 1.9;
            shops[4].price2 = 1;
            shops[4].variation2 = 1.8;
            shops[4].price3 = 1;
            shops[4].variation3 = 1;
            shops[4].price4 = 3;
            shops[4].variation4 = 3.8;
            shops[4].price5 = 5;
            shops[4].variation5= 1.9;
            shops[4].price6 = 3;
            shops[4].variation6 = 3.8;

            shops[5].itemName = "EUR";
            shops[5].price1 = 8;
            shops[5].variation1 = 1.9;
            shops[5].price2 = 1;
            shops[5].variation2 = 1.8;
            shops[5].price3 = 5;
            shops[5].variation3 = 1.9;
            shops[5].price4 = 3;
            shops[5].variation4= 3.8;
            shops[5].price5 = 5;
            shops[5].variation5= 1.9;
            shops[5].price6 = 1;
            shops[5].variation6 = 1;

            // Load the item names
            for (int i = 0; i < items.Length; i++)
            {
                items[i].Text = shops[i].itemName;
            }

            // load the first location
            locations.SelectedIndex = 0;
        }


        private void randomEvents()
        {
            if (double.Parse(bankBalance.Text) <= 0)
            {
                MessageBox.Show("You have untill the end of the game to come even with the bank again or your kneecaps will be shattered");
            }

            if (locations = locations1 )
            {

            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise the screen and components
            setUpGame();

           
        }
        
        private void locations_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This event is triggered every time the 
            // combobox is changed

            // Cast the sender object as a combobox
            ComboBox sentCombo = (ComboBox)sender;

            // Set the prices
            // Formula here is random number between
            // 1 and the price set in the structure
            // multiplied by the variation
            price1.Text = (rand.Next(1, shops[sentCombo.SelectedIndex].price1) * shops[sentCombo.SelectedIndex].variation1).ToString();
            price2.Text = (rand.Next(1, shops[sentCombo.SelectedIndex].price2) * shops[sentCombo.SelectedIndex].variation2).ToString();
            price3.Text = (rand.Next(1, shops[sentCombo.SelectedIndex].price3) * shops[sentCombo.SelectedIndex].variation3).ToString();
            price4.Text = (rand.Next(1, shops[sentCombo.SelectedIndex].price4) * shops[sentCombo.SelectedIndex].variation4).ToString();
            price5.Text = (rand.Next(1, shops[sentCombo.SelectedIndex].price5) * shops[sentCombo.SelectedIndex].variation5).ToString();
            price6.Text = (rand.Next(1, shops[sentCombo.SelectedIndex].price6) * shops[sentCombo.SelectedIndex].variation6).ToString();
        }

        private void price1_Click(object sender, EventArgs e)
        {

        }

        private void bankBalance_Click(object sender, EventArgs e)
        {

        }

        private void buyLoan_Click(object sender, EventArgs e)
        {
   
                money.Text = (double.Parse(money.Text) + 10).ToString();
                bankBalance.Text = (double.Parse(bankBalance.Text) - 10).ToString();
            }

        private void buyWithdraw_Click(object sender, EventArgs e)
        {
            if (double.Parse(bankBalance.Text) <= 0)
            {
                MessageBox.Show("Your balance is in debt, you may not withdraw");
            }
            else
            {
            
                money.Text = (double.Parse(money.Text) + 10).ToString();
                bankBalance.Text = (double.Parse(bankBalance.Text) - 10).ToString();
            }
        }

        private void buyDeposit_Click(object sender, EventArgs e)
        {
            if (double.Parse(money.Text) <= 0)
            {
                MessageBox.Show("You're broke, you have no money to deposit");
            }
            else
            {

                money.Text = (double.Parse(money.Text) - 10).ToString();
                bankBalance.Text = (double.Parse(bankBalance.Text) + 10).ToString();
            }
        }
    }

    }

