using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class AirPackage : Package
{
    //Created set real number values for the dimensions of our packages
    public const double HEAVY_WEIGHT = 75;
    public const double LARGER_WEIGHT = 100;

    //Created specific values for all the dimesnions and fee
    public AirPackage(Address originAddress, Address destinAddress, double tLength, double tWidth, double tHeight, double tWeight)
        :base(originAddress, destinAddress, tLength, tWidth, tHeight, tWeight)

    {

    }

    //A boolean value created to determine if the the value is heavy or large
    public bool IsHeavy() 
    {
        return (Weight >= HEAVY_WEIGHT);
    }
   
    //A boolean value created to determine if the the value is heavy or large
    public bool IsLarge()
    {
        return (OverallCapacity >= LARGER_WEIGHT);
    }

    //Create a too string mehtod to display our final  information
    public override string ToString()
    
    {
        string NL = Environment.NewLine; 

        return $"AirPackage{base.ToString()}{NL}Heavy: {IsHeavy()}{NL}Large: {IsLarge()}";
    }
}

