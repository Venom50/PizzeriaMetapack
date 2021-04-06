using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models
{
    /// <summary>
    /// Interface describing IProduct
    /// </summary>
    interface IProduct
    {
        /// <summary>
        /// Id of the product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price of the product
        /// </summary>
        public decimal Price { get; set; }
    }
}
