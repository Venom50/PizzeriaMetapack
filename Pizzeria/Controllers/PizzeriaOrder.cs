using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Enums;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Pizzeria.Helpers;

namespace Pizzeria.Controllers
{
    public class PizzeriaOrder
    {
        /// <summary>
        /// Represents PizzeriaOrderForm
        /// </summary>
        public PizzeriaOrderForm Form { private get; set; }

        private List<Food> drinks = new();
        private List<Food> soups = new();

        public PizzeriaOrder(PizzeriaOrderForm form)
        {
            Form = form;
        }

        /// <summary>
        /// Connects to the database and gets information about Drinks and Soups
        /// </summary>
        public void GetDrinkAndSoupFromDatabase()
        {
            using var db = new DataContext();

            drinks = db.Food.Where(d => d.Category.Name.Equals(FoodType.Drink.ToString())).Include(d => d.Category).ToListAsync().Result;
            soups = db.Food.Where(s => s.Category.Name.Equals(FoodType.Soup.ToString())).Include(s => s.Category).ToListAsync().Result;
        }

        /// <summary>
        /// Populates drinksListView and soupsListView with data
        /// </summary>
        public void PopulateListViews()
        {
            foreach (var drink in drinks)
            {
                var item = new ListViewItem(new[] { drink.Name, drink.Price.ToString() + "zł" });
                Form.DrinksListView.Items.Add(item);
            }

            foreach (var soup in soups)
            {
                var item = new ListViewItem(new[] { soup.Name, soup.Price.ToString() + "zł" });
                Form.SoupsListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Adds selected Drink to the GlobalConfig.Order
        /// </summary>
        public void AddSelectedDrink()
        {
            if (Form.DrinksListView.SelectedItems.Count > 0)
            {
                var item = Form.DrinksListView.SelectedItems[0];

                if (GlobalConfig.FoodLimit == 0)
                {
                    MessageBox.Show("Exceeded the number of maximum orders.");
                }
                else
                {
                    foreach (Food drink in drinks)
                    {
                        if (item.SubItems[0].Text.Equals(drink.Name) && GlobalConfig.FoodLimit > 0)
                        {
                            var drinkOrder = new FoodOrder(drink);
                            GlobalConfig.Order.FoodOrders.Add(drinkOrder);
                            GlobalConfig.FoodLimit -= 1;
                        }
                    }
                }
            }

            RefreshOrderListView();
        }

        /// <summary>
        /// Adds selected Soup to the GlobalConfig.Order
        /// </summary>
        public void AddSelectedSoup()
        {
            if (Form.SoupsListView.SelectedItems.Count > 0)
            {
                var item = Form.SoupsListView.SelectedItems[0];

                if (GlobalConfig.FoodLimit == 0)
                {
                    MessageBox.Show("Exceeded the number of maximum orders.");
                }
                else
                {
                    foreach (Food soup in soups)
                    {
                        if (item.SubItems[0].Text.Equals(soup.Name) && GlobalConfig.FoodLimit > 0)
                        {
                            var soupOrder = new FoodOrder(soup);
                            GlobalConfig.Order.FoodOrders.Add(soupOrder);
                            GlobalConfig.FoodLimit -= 1;
                        }
                    }
                }     
            }

            RefreshOrderListView();
        }

        /// <summary>
        /// Adds all data from GlobalConfig.Order to orderListView.
        /// Refreshes current total price and orderListView.
        /// </summary>
        public void RefreshOrderListView()
        {
            List<string> additionsList = new List<string>();
            string additionsName;
            decimal additionsPrice = 0M;
            decimal totalPrice = 0M;

            Form.OrderListView.Items.Clear();

            foreach (var foodOrder in GlobalConfig.Order.FoodOrders)
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
                        Form.OrderListView.Items.Add(item);
                    }
                }
                else
                {
                    var item = new ListViewItem(new[] { foodOrder.Dish.Name, foodOrder.Dish.Price.ToString() + "zł" });
                    Form.OrderListView.Items.Add(item);
                }

                totalPrice += additionsPrice + foodOrder.Dish.Price;

                additionsList.Clear();
                additionsName = "";
                additionsPrice = 0M;
            }

            Form.TotalPrice = totalPrice.ToString() + "zł";
            Form.OrderListView.Refresh();
        }

        /// <summary>
        /// Deletes selected item from orderListView and GlobalConfig.Order.FoodOrders
        /// </summary>
        public void DeleteSelectedItem()
        {
            if (Form.OrderListView.SelectedIndices.Count > 0)
            {
                GlobalConfig.Order.FoodOrders.RemoveAt(Form.OrderListView.SelectedIndices[0]);
                MessageBox.Show("Selected item deleted.");

                GlobalConfig.FoodLimit += 1;
            }
        }

        /// <summary>
        /// Sends GlobalConfig.Order to database as Order.
        /// Resets GlobalConfig.Order, clears orderListView and sets totalPrizeLabel to 0zł
        /// </summary>
        public void Order()
        {
            using var db = new DataContext();

            if (Form.Note.Length > 0)
            {
                GlobalConfig.Order.Note = Form.Note;
            }

            if (GlobalConfig.Order.FoodOrders.Count > 0)
            {


                if (Form.Email.Length > 0 && Helper.CheckIfEmailIsCorrect(Form.Email))
                {
                    SendEmail(GenerateEmailBody());

                    db.ChangeTracker.TrackGraph(GlobalConfig.Order, node => node.Entry.State = !node.Entry.IsKeySet ? EntityState.Added : EntityState.Unchanged);
                    db.SaveChanges();

                    GlobalConfig.Order = new Order();
                    Form.OrderListView.Items.Clear();

                    Form.TotalPrice = "0zł";
                    Form.Note = "";
                    Form.Email = "";

                    MessageBox.Show("Order complete.");
                }
                else if (!Helper.CheckIfEmailIsCorrect(Form.Email))
                {
                    MessageBox.Show("Incorrect email form");
                }
                else
                {
                    MessageBox.Show("Enter your email");
                }
            }
            else
            {
                MessageBox.Show("Order something first.");
            }
        }

        /// <summary>
        /// Sends an email given in the emailTextBox with information about the order
        /// </summary>
        /// <param name="emailBody">String that is going to be sent to an email</param>
        private void SendEmail(string emailBody)
        {
            var fromAddress = new MailAddress("testemailforpizzeria@gmail.com", "Pizzeria App");
            var toAddress = new MailAddress(Form.Email);
            string password = "zaq1@WSX";
            string subject = "Order";
            string body = emailBody;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, password)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            };
        }

        /// <summary>
        /// Generates string with all the information about the order
        /// </summary>
        /// <returns>String with all the information about the order</returns>
        private string GenerateEmailBody()
        {
            string totalText = "";

            foreach (ListViewItem item in Form.OrderListView.Items)
            {
                totalText += item.SubItems[0].Text + " " + item.SubItems[1].Text + Environment.NewLine;
            }

            totalText += "Note: " + Form.Note + Environment.NewLine;
            totalText += "Total Price: " + Form.TotalPrice;

            return totalText;
        }

        
    }
}
