using Pizzeria.Controllers;
using System;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class MainDishOrderForm : Form
    {
        private PizzeriaOrder pizzeriaOrder;
        private MainDishOrder mainDishOrder;

        /// <summary>
        /// Represents mainDishesListView
        /// </summary>
        public ListView MainDishesListView
        {
            get => mainDishesListView;
            set
            {
                mainDishesListView = value;
            }
        }

        /// <summary>
        /// Represents mainDishAdditionsListView
        /// </summary>
        public ListView MainDishAdditionsListView
        {
            get => mainDishAdditionsListView;
            set
            {
                mainDishAdditionsListView = value;
            }
        }
        public MainDishOrderForm()
        {
            InitializeComponent();
            mainDishOrder = new MainDishOrder(this);
        }

        public MainDishOrderForm(PizzeriaOrderForm form)
        {
            InitializeComponent();
            pizzeriaOrder = new PizzeriaOrder(form);
            mainDishOrder = new MainDishOrder(this);
        }

        private void MainDishOrderForm_Load(object sender, EventArgs e)
        {
            mainDishOrder.GetMainDishesAndAdditionsFromDatabase();
            mainDishOrder.PopulateListViews();
        }

        private void orderMainDishButton_Click(object sender, EventArgs e)
        {
            mainDishOrder.OrderMainDish();
            pizzeriaOrder.RefreshOrderListView();
        }
    }
}
