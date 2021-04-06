using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    /// <summary>
    /// Model describing AdditionOrder
    /// </summary>
    public class AdditionOrder
    {
        /// <summary>
        /// Id of the addition order
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Addition of the addition order
        /// </summary>
        [Required]
        public Addition Addition { get; set; }

        /// <summary>
        /// Constructor for AdditionOrder
        /// </summary>
        public AdditionOrder()
        {

        }

        /// <summary>
        /// Constructor for AdditionOrder
        /// </summary>
        /// <param name="addition">Addition that is going to be added to the AdditionOrder</param>
        public AdditionOrder(Addition addition)
        {
            Addition = addition;
        }
    }
}
