using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    /// <summary>
    /// Model describing FoodCategory
    /// </summary>
    public class FoodCategory
    {
        /// <summary>
        /// Id of the food category
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the food category
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
