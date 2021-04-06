using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class GlobalConfig
    {

        /// <summary>
        /// Global Order for the application
        /// </summary>
        public static Order Order { get; set; } = new Order();

        /// <summary>
        /// The total amount of food that can be ordered
        /// </summary>
        public static int FoodLimit { get; set; } = 15;
    }
}
