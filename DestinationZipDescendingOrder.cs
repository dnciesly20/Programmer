using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DestinationZipDescendingOrder : Comparer<Parcel>
    {
        // Precondition:  None
        // Postcondition: Reverses natural time order, so descending
        //                When t1 < t2, method returns positive #
        //                When t1 == t2, method returns zero
        //                When t1 > t2, method returns negative #
        public override int Compare(Parcel p1, Parcel p2)
        {
            // Ensure correct handling of null values (in .NET, null less than anything)
            if (p1 == null && p2 == null) // Both null?
                return 0;                 // Equal

            if (p1 == null) // only t1 is null?
                return -1;  // null is less than any actual time

            if (p2 == null) // only t2 is null?
                return 1;   // Any actual time is greater than null

            return (-1) * p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip); // Reverses natural order, so descending
        }
    }
}
