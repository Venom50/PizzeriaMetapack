using Pizzeria.Controllers;
using System;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class OrderHistoryForm : Form
    {
        private OrderHistory orderHistory;

        /// <summary>
        /// Represents orderHistoryListView
        /// </summary>
        public ListView OrderHistoryListView
        {
            get => orderHistoryListView;
            set
            {
                orderHistoryListView = value;
            }
        }

        /// <summary>
        /// Represents orderHistoryListView
        /// </summary>
        public ListView OrderDetailsListView
        {
            get => orderDetailsListView;
            set
            {
                orderDetailsListView = value;
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

        public OrderHistoryForm()
        {
            InitializeComponent();
            orderHistory = new OrderHistory(this);
        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            orderHistory.GetOrdersFromDatabase();
            orderHistory.PopulateOrderHistoryListView();
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            orderHistory.ShowDetails();
        }
    }
}
