using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Enums;
using Pizzeria.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pizzeria.Controllers
{
    class MainDishOrder
    {
        /// <summary>
        /// Represents MainDishOrderForm
        /// </summary>
        public MainDishOrderForm Form { private get; set; }

        private List<Food> mainDishes = new List<Food>();
        private List<Addition> additions = new List<Addition>();
        private List<AdditionOrder> additionOrders = new List<AdditionOrder>();

        public MainDishOrder(MainDishOrderForm form)
        {
            Form = form;
        }

        /// <summary>
        /// Connects to the database and gets information about MainDishes and Additions
        /// </summary>
        public void GetMainDishesAndAdditionsFromDatabase()
        {
            using var db = new DataContext();

            mainDishes = db.Food.Where(m => m.Category.Name.Equals(FoodType.MainDish.ToString())).Include(m => m.Category).ToListAsync().Result;
            additions = db.Additions.Where(a => a.Category.Name.Equals(FoodType.MainDish.ToString())).Include(a => a.Category).ToListAsync().Result;
        }

        /// <summary>
        /// Populates mainDishesListView and mainDishAdditionsListView with data
        /// </summary>
        public void PopulateListViews()
        {
            foreach (var mainDish in mainDishes)
            {
                var item = new ListViewItem(new[] { mainDish.Name, mainDish.Price.ToString() + "zł" });
                Form.MainDishesListView.Items.Add(item);
            }

            foreach (var addition in additions)
            {
                var item = new ListViewItem(new[] { addition.Name, addition.Price.ToString() + "zł" });
                Form.MainDishAdditionsListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Adds selected MainDishes and Additions to the GlobalConfig.Order
        /// </summary>
        public void OrderMainDish()
        {
            if (Form.MainDishesListView.SelectedItems.Count > 0)
            {
                var mainDishItem = Form.MainDishesListView.SelectedItems[0];

                foreach (Food mainDish in mainDishes)
                {
                    if (mainDishItem.SubItems[0].Text.Equals(mainDish.Name) && GlobalConfig.FoodLimit > 0)
                    {
                        if (Form.MainDishAdditionsListView.CheckedItems.Count > 0)
                        {
                            foreach (ListViewItem item in Form.MainDishAdditionsListView.CheckedItems)
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
                        FoodOrder mainDishFoodOrder;
                        if (additionOrders.Any())
                        {
                            mainDishFoodOrder = new FoodOrder(mainDish, additionOrders);
                        }
                        else
                        {
                            mainDishFoodOrder = new FoodOrder(mainDish);
                        }

                        GlobalConfig.Order.FoodOrders.Add(mainDishFoodOrder);
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
