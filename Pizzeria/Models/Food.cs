using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    /// <summary>
    /// Model describing Food
    /// </summary>
    public class Food : IProduct
    {
        /// <summary>
        /// Id of the food
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the food
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Price of the food
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Food category of the food
        /// </summary>
        [Required]
        public FoodCategory Category { get; set; }
    }
}
