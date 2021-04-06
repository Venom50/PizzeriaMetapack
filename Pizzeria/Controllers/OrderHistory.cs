using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria.Controllers
{
    class OrderHistory
    {
        public OrderHistoryForm Form { private get; set; }

        private List<Order> orders = new List<Order>();

        public OrderHistory(OrderHistoryForm form)
        {
            Form = form;
        }

        /// <summary>
        /// Connects to the database and gets information about Orders
        /// </summary>
        public void GetOrdersFromDatabase()
        {
            using var db = new DataContext();

            orders = db.Orders.Include(o => o.FoodOrders).ThenInclude(f => f.Dish).Include(o => o.FoodOrders).
                ThenInclude(f => f.AdditionOrders).ThenInclude(a => a.Addition).ToListAsync().Result;
        }

        /// <summary>
        /// Populates orderHistoryListView with data
        /// </summary>
        public void PopulateOrderHistoryListView()
        {
            foreach (var order in orders)
            {
                var item = new ListViewItem(new[] { order.Id.ToString() });
                Form.OrderHistoryListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Shows details of selected order
        /// </summary>
        public void ShowDetails()
        {
            if (Form.OrderHistoryListView.SelectedItems.Count > 0)
            {
                var item = Form.OrderHistoryListView.SelectedItems[0];

                foreach (Order order in orders)
                {
                    if (item.SubItems[0].Text.Equals(order.Id.ToString()))
                    {
                        ShowOrderDetails(order);
                    }
                }
            }
        }

        /// <summary>
        /// Adds all data from Order to orderDetailsListView.
        /// Refreshes current total price and orderDetailsListView.
        /// </summary>
        private void ShowOrderDetails(Order order)
        {
            List<string> additionsList = new List<string>();
            string additionsName;
            decimal additionsPrice = 0M;
            decimal totalPrice = 0M;

            Form.OrderDetailsListView.Items.Clear();
            Form.Note = "";

            foreach (var foodOrder in order.FoodOrders)
            {
                if (foodOrder.AdditionOrders.Any())
                {
                    foreach (AdditionOrder additionOrder in foodOrder.AdditionOrders)
                    {
                        additionsList.Add(additionOrder.Addition.Name);
                        additionsPrice += additionOrder.Addition.Price;
                    }

                    if (additionsList.Any())
                    {
                        additionsName = string.Join(" + ", additionsList);
                        var item = new ListViewItem(new[] { foodOrder.Dish.Name + " + " + additionsName, (additionsPrice + foodOrder.Dish.Price).ToString() + "zł" });
                        Form.OrderDetailsListView.Items.Add(item);
                    }
                }
                else
                {
                    var item = new ListViewItem(new[] { foodOrder.Dish.Name, foodOrder.Dish.Price.ToString() + "zł" });
                    Form.OrderDetailsListView.Items.Add(item);
                }

                totalPrice += additionsPrice + foodOrder.Dish.Price;

                additionsList.Clear();
                additionsName = "";
                additionsPrice = 0M;
            }

            if (!string.IsNullOrEmpty(order.Note))
            {
                Form.Note = order.Note;
            }

            Form.TotalPrice = totalPrice.ToString() + "zł";
            Form.OrderDetailsListView.Refresh();
        }
    }
}
