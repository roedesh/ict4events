using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialRentalSysteem
{
    class RentalComparer
    {
        public class SortByName : IComparer<Rental>
        {
            int IComparer<Rental>.Compare(Rental x, Rental y)
            {
                Rental X = (Rental)x, Y = (Rental)y;
                return (X.FullName.CompareTo(Y.FullName));
            }
        }
        public class SortByType : IComparer<Rental>
        {
            int IComparer<Rental>.Compare(Rental x, Rental y)
            {
                Rental X = (Rental)x, Y = (Rental)y;
                return (X.ItemType.CompareTo(Y.ItemType));
            }
        }
    }
}
