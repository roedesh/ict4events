using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialRentalSysteem
{
    class RentalManager
    {
        /// <summary>
        /// The RentalManager manages all the rentals.
        /// </summary>
        public List<Rental> RentedItems { get; set; }
        public RentalManager()
        {
            RentedItems = new List<Rental>();
        }
        public void AddRental(Rental rental)
        {
            RentedItems.Add(rental);
        }
    }
}
