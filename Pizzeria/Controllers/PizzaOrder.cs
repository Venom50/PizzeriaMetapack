using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Enums;
using Pizzeria.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pizzeria.Controllers
{
    class PizzaOrder
    {
        public PizzaOrderForm Form { get; set; }

        private List<Food> pizzas = new List<Food>();
        private List<Addition> additions = new List<Addition>();
        private List<AdditionOrder> additionOrders = new List<AdditionOrder>();

        public PizzaOrder(PizzaOrderForm form)
        {
            Form = form;
        }

        /// <summary>
        /// Connects to the database and gets information about Pizzas and Additions
        /// </summary>
        public void GetPizzasAndAdditionsFromDatabase()
        {
            using var db = new DataContext();

            pizzas = db.Food.Where(m => m.Category.Name.Equals(FoodType.Pizza.ToString())).Include(m => m.Category).ToListAsync().Result;
            additions = db.Additions.Where(a => a.Category.Name.Equals(FoodType.Pizza.ToString())).Include(a => a.Category).ToListAsync().Result;
        }

        /// <summary>
        /// Populates pizzasListView and pizzaAdditionsListView with data
        /// </summary>
        public void PopulateListViews()
        {
            foreach (var pizza in pizzas)
            {
                var item = new ListViewItem(new[] { pizza.Name, pizza.Price.ToString() + "zł" });
                Form.PizzasListView.Items.Add(item);
            }

            foreach (var addition in additions)
            {
                var item = new ListViewItem(new[] { addition.Name, addition.Price.ToString() + "zł" });
                Form.PizzaAdditionsListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Adds selected Pizzas and Additions to the GlobalConfig.Order
        /// </summary>
        public void OrderMainDish()
        {
            if (Form.PizzasListView.SelectedItems.Count > 0)
            {
                var pizzaItem = Form.PizzasListView.SelectedItems[0];

                foreach (Food pizza in pizzas)
                {
                    if (pizzaItem.SubItems[0].Text.Equals(pizza.Name) && GlobalConfig.FoodLimit > 0)
                    {
                        if (Form.PizzaAdditionsListView.CheckedItems.Count > 0)
                        {
                            foreach (ListViewItem item in Form.PizzaAdditionsListView.CheckedItems)
                            {
                                foreach (Addition addition in additions)
                                {
                                    if (item.SubItems[0].Text.Equals(addition.Name))
                                    {
                                        var additionOrder = new AdditionOrder(addition);
                                        additionOrders.Add(additionOrder);
                                    }
                                }
                            }
                        }
                        FoodOrder pizzaFoodOrder;
                        if (additionOrders.Any())
                        {
                            pizzaFoodOrder = new FoodOrder(pizza, additionOrders);
                        }
                        else
                        {
                            pizzaFoodOrder = new FoodOrder(pizza);
                        }

                        GlobalConfig.Order.FoodOrders.Add(pizzaFoodOrder);
                        GlobalConfig.FoodLimit -= 1;
                    }
                    else if (GlobalConfig.FoodLimit == 0)
                    {
                        MessageBox.Show("Exceeded the number of maximum orders.");
                    }
                }
            }

            additionOrders.Clear();
        }
    }
}
