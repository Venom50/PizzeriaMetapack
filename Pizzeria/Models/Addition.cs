using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    /// <summary>
    /// Model describing Addition
    /// </summary>
    public class Addition : IProduct
    {
        /// <summary>
        /// Id of the addition
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the addition
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Price of the addition
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Food category of the addition
        /// </summary>
        [Required]
        public FoodCategory Category { get; set; }
    }
}
