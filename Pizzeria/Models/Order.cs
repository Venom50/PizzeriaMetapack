using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    /// <summary>
    /// Model describing Order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Id of the order
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// List of FoodOrders contained in the order
        /// </summary>
        public List<FoodOrder> FoodOrders { get; set; } = new List<FoodOrder>();

        /// <summary>
        /// Note of the order
        /// </summary>
        public string Note { get; set; }
    }
}