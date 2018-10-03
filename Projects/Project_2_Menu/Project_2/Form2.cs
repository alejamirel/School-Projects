using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Project_2
{
    public partial class Form1 : Form
    {
        string name;

        const double FRUITSALAD_PRICE = 9.95;
        const double PASTASALAD_PRICE = 12.00;
        const double SMOOTHIE_PRICE = 4.95;
        const double FRUITJUICE_PRICE = 3.95;
        const double CUPCAKE_PRICE = 3.00;
        const double SHORTCAKE_PRICE = 6.00;

        double saladOrderPrice, drinkOrderPrice, dessertOrderPrice, 
            saladOrderQuantity, drinkOrderQuantity, dessertOrderQuantity;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            name = Interaction.InputBox("Hi, please enter your name.", "Customer's Name");

        }

        private void FruitSaladradioButton_CheckedChanged(object sender, EventArgs e)
        {
            SaladPricetextBox.Text = FRUITSALAD_PRICE.ToString("C");
            saladOrderPrice = FRUITSALAD_PRICE;
            SaladQuantitytextBox.Focus();

            SalasSelLabel.Text = "Salad Selected: Fruit Salad";
        }

        private void PastaSaladradioButton_CheckedChanged(object sender, EventArgs e)
        {
            SaladPricetextBox.Text = PASTASALAD_PRICE.ToString("C");
            saladOrderPrice = PASTASALAD_PRICE;
            SaladQuantitytextBox.Focus();

            SalasSelLabel.Text = "Salad Selected: Pasta Salad";
        }

        private void SmoothieradioButton_CheckedChanged(object sender, EventArgs e)
        {
            DrinkPricetextBox.Text = SMOOTHIE_PRICE.ToString("C");
            drinkOrderPrice = SMOOTHIE_PRICE;
            DrinkQuantitytextBox.Focus();

            DrinkSelLabel.Text = "Drink Selected: Smoothie";
        }

        private void FruitJuiceradioButton_CheckedChanged(object sender, EventArgs e)
        {
            DrinkPricetextBox.Text = FRUITJUICE_PRICE.ToString("C");
            drinkOrderPrice = FRUITJUICE_PRICE;
            DrinkQuantitytextBox.Focus();

            DrinkSelLabel.Text = "Drink Selected: Fruit Juice";
        }

        private void CupcakeradioButton_CheckedChanged(object sender, EventArgs e)
        {
            DessertPricetextBox.Text = CUPCAKE_PRICE.ToString("C");
            dessertOrderPrice = CUPCAKE_PRICE;
            DessertQuantitytextBox.Focus();

            DessertSelLabel.Text = "Dessert Selected: Cupcake";
        }

        private void ShortcakeradioButton_CheckedChanged(object sender, EventArgs e)
        {
            DessertPricetextBox.Text = SHORTCAKE_PRICE.ToString("C");
            dessertOrderPrice = SHORTCAKE_PRICE;
            DessertQuantitytextBox.Focus();

            DessertSelLabel.Text = "Dessert Selected: Shortcake";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            saladOrderQuantity = double.Parse(SaladQuantitytextBox.Text);
            drinkOrderQuantity = double.Parse(DrinkQuantitytextBox.Text);
            dessertOrderQuantity = double.Parse(DessertQuantitytextBox.Text);

            double OrderQuantity = saladOrderQuantity + drinkOrderQuantity + dessertOrderQuantity;


            double totalCost = (saladOrderPrice * saladOrderQuantity) +(drinkOrderPrice* drinkOrderQuantity)+ (dessertOrderPrice*dessertOrderQuantity);

            MessageLabel.Text = string.Format("The total sales amount was: {0:C}" + "\n Total Order Quantity was:{1}" + "\n Thank you for your purchase, {2}!", totalCost, OrderQuantity, name);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FruitSaladradioButton.Checked = false;
            PastaSaladradioButton.Checked = false;
            SmoothieradioButton.Checked = false;
            FruitJuiceradioButton.Checked = false;
            CupcakeradioButton.Checked = false;
            ShortcakeradioButton.Checked = false;

            SaladPricetextBox.Text = "";
            DrinkPricetextBox.Text = "";
            DessertPricetextBox.Text = "";
            SaladQuantitytextBox.Text = "";
            DrinkQuantitytextBox.Text = "";
            DessertQuantitytextBox.Text = "";

            MessageLabel.Text = string.Empty;
            SalasSelLabel.Text = "";
            DrinkSelLabel.Text = "";
            DessertSelLabel.Text = "";

            CalculateButton.Focus();

            SaladPricetextBox.Text = "0";
            DrinkPricetextBox.Text = "0";
            DessertPricetextBox.Text = "0";
            SaladQuantitytextBox.Text = "0";
            DrinkQuantitytextBox.Text = "0";
            DessertQuantitytextBox.Text = "0";
            
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
