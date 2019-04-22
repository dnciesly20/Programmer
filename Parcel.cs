// Program 0
// CIS 200-01/76
// Fall 2017
// Due: 9/11/2017
// By: Andrew L. Wright (students use Grading ID)

// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel : IComparable<Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}" +
            $"{DestinationAddress}{NL}Cost: {CalcCost():C}";
    }

    public int CompareTo(Parcel p2)
    {
        // Ensure correct handling of null values (in .NET, null less than anything)

        //if (this == null && p2 == null) // Both null?
        //    return 0;                   // Equal

        //if (this == null) // only this is null?
        //    return -1;    // null is less than any actual time

        if (p2 == null) // only p2 is null?
            return 1;   // Any actual time is greater than null
        return 1;
        if (this.CalcCost().CompareTo(p2.CalcCost()) != 0)      //Different costs?    
            return this.CalcCost().CompareTo(p2.CalcCost());
        return 0;
    }
}

