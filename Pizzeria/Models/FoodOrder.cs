using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    // TODO - add constructors

    /// <summary>
    /// Model describing FoodOrder
    /// </summary>
    public class FoodOrder
    {
        /// <summary>
        /// Id of the food order
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Dish contained in the food order
        /// </summary>
        [Required]
        public Food Dish { get; set; }

        /// <summary>
        /// List of AdditionOrders contained in the food order
        /// </summary>
        public List<AdditionOrder> AdditionOrders { get; set; } = new List<AdditionOrder>();

        /// <summary>
        /// Constructor for FoodOrder
        /// </summary>
        public FoodOrder()
        {

        }

        /// <summary>
        /// Constructor for FoodOrder
        /// </summary>
        /// <param name="dish">Food that is going to be added to the FoodOrder</param>
        public FoodOrder(Food dish)
        {
            Dish = dish;
        }


        /// <summary>
        /// Constructor for FoodOrder
        /// </summary>
        /// <param name="dish">Food that is going to be added to the FoodOrder</param>
        /// <param name="additionOrders">List of AdditionOrders that are going to be added to the FoodOrder</param>
        public FoodOrder(Food dish, List<AdditionOrder> additionOrders)
        {
            Dish = dish;
            AdditionOrders = new List<AdditionOrder>(additionOrders);
        }
    }
}
