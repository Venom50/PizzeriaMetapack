using System;
using System.Windows.Forms;
using Pizzeria.Controllers;

namespace Pizzeria
{
    public partial class PizzeriaOrderForm : Form
    {
        private PizzeriaOrder pizzeriaOrder;

        /// <summary>
        /// Represents drinksListView
        /// </summary>
        public ListView DrinksListView
        {
            get => drinksListView;
            set
            {
                drinksListView = value;
            }
        }

        /// <summary>
        /// Represents soupsListView
        /// </summary>
        public ListView SoupsListView
        {
            get => soupsListView;
            set
            {
                soupsListView = value;
            }
        }

        /// <summary>
        /// Represents orderListView
        /// </summary>
        public ListView OrderListView
        {
            get => orderListView;
            set
            {
                orderListView = value;
            }
        }

        /// <summary>
        /// Represents totalPrizeLabel.Text
        /// </summary>
        public string TotalPrice
        {
            get => totalPrizeLabel.Text;
            set
            {
                totalPrizeLabel.Text = value;
            }
        }

        /// <summary>
        /// Represents noteRichTextBox.Text
        /// </summary>
        public string Note
        {
            get => noteRichTextBox.Text;
            set
            {
                noteRichTextBox.Text = value;
            }
        }

        /// <summary>
        /// Represents emailTextBox.Text
        /// </summary>
        public string Email
        {
            get => emailTextBox.Text;
            set
            {
                emailTextBox.Text = value;
            }
        }

        public PizzeriaOrderForm()
        {
            InitializeComponent();
            pizzeriaOrder = new PizzeriaOrder(this);
        }

        private void PizzeriaOrderForm_Load(object sender, EventArgs e)
        {
            pizzeriaOrder.GetDrinkAndSoupFromDatabase();
            pizzeriaOrder.PopulateListViews();
        }

        private void pizzaOrderFormButton_Click(object sender, EventArgs e)
        {
            var pizzaOrderForm = new PizzaOrderForm(this);
            pizzaOrderForm.Show();
        }

        private void mainDishOrderFormButton_Click(object sender, EventArgs e)
        {
            var mainDishOrderForm = new MainDishOrderForm(this);
            mainDishOrderForm.Show();
        }

        private void addSelectedDrinkButton_Click(object sender, EventArgs e)
        {
            pizzeriaOrder.AddSelectedDrink(); 
            pizzeriaOrder.RefreshOrderListView();
        }

        private void addSelectedSoupButton_Click(object sender, EventArgs e)
        {
            pizzeriaOrder.AddSelectedSoup();
            pizzeriaOrder.RefreshOrderListView();
        }

        private void deleteSelectedOrderElementButton_Click(object sender, EventArgs e)
        {
            pizzeriaOrder.DeleteSelectedItem();
            pizzeriaOrder.RefreshOrderListView();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            pizzeriaOrder.Order();
        }

        private void orderHistoryButton_Click(object sender, EventArgs e)
        {
            var orderHistoryForm = new OrderHistoryForm();
            orderHistoryForm.Show();
        }
    }
}
