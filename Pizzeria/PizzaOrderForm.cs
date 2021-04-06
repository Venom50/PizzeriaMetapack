using Pizzeria.Controllers;
using System;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class PizzaOrderForm : Form
    {
        private PizzeriaOrder pizzeriaOrder;
        private PizzaOrder pizzaOrder;

        /// <summary>
        /// Represents pizzasListView
        /// </summary>
        public ListView PizzasListView
        {
            get => pizzasListView;
            set
            {
                pizzasListView = value;
            }
        }

        /// <summary>
        /// Represents pizzaAdditionsListView
        /// </summary>
        public ListView PizzaAdditionsListView
        {
            get => pizzaAdditionsListView;
            set
            {
                pizzaAdditionsListView = value;
            }
        }

        public PizzaOrderForm()
        {
            InitializeComponent();
            pizzaOrder = new PizzaOrder(this);
        }

        public PizzaOrderForm(PizzeriaOrderForm form)
        {
            InitializeComponent();
            pizzeriaOrder = new PizzeriaOrder(form);
            pizzaOrder = new PizzaOrder(this);
        }

        private void PizzaOrderForm_Load(object sender, EventArgs e)
        {
            pizzaOrder.GetPizzasAndAdditionsFromDatabase();
            pizzaOrder.PopulateListViews();
        }

        private void orderPizzaButton_Click(object sender, EventArgs e)
        {
            pizzaOrder.OrderMainDish();
            pizzeriaOrder.RefreshOrderListView();
        }
    }
}
