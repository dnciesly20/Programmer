using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created a public Ground PAckage class that is derived from the Package class
public class GroundPackage : Package
{
    //Created specific values for all the dimesnions and fees
    public GroundPackage(Address originAddress, Address destinAddress, double tLength, double tWidth, double tHeight, double tWeight)
        : base(originAddress, destinAddress,tLength, tWidth, tHeight, tWeight)
    {

    }

    //The total distance of between the zip codes
    public int ZoneDistance
    {
        //Creating a function that will give the value when subtracting the origin address from the desitnation address
        get
        {
            const int DENOM_VALUE = 1000;
                int zipcodedistance;

            zipcodedistance = Math.Abs((OriginAddress.Zip / DENOM_VALUE) - (DestinationAddress.Zip / DENOM_VALUE));

            return zipcodedistance;
        }
    }
    
    //Establishing a CalcCOst Method
    public override decimal CalcCost()
    {
        const double ZONEDISTANCE_WEIGHT = 0.5;
        const double OVERALL_DIMENSION = .20;

        return (decimal)(OVERALL_DIMENSION * OverallCapacity + ZONEDISTANCE_WEIGHT * (ZoneDistance + 1) * Weight);

    }

    //Create a too string mehtod to display our final  information
    public override string ToString()
    {
        {
            string NL = Environment.NewLine;

            return $"GroundPackage{base.ToString()}{NL}ZoneDistance: {ZoneDistance:D}";
        }
    }
}
