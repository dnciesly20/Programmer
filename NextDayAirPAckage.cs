using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NextDayAirPackage : AirPackage
{
    //Use real numbers to determine this fee. Base  from store to store
    private decimal _expressFee;

    //Created specific values for all the dimesnions and fee
    public NextDayAirPackage(Address originAddress, Address destinAddress, double tLength, double tWidth, double tHeight, double tWeight, decimal expFee)
       : base(originAddress, destinAddress, tLength, tWidth, tHeight, tWeight)
    {
        ExpressFee = expFee;
    }

    //Get and set property that will return the value of the Express Fee
    public decimal ExpressFee
    {
        get
        {
            return _expressFee;
        }
        set
        {
            if (value > 0)
                value = _expressFee;
            else
                throw new ArgumentOutOfRangeException("Express Fee", value, "The Express Fee value has to be greater than O");
        }

    }

    //Calc COst method that will return the value of the NextDayAirPackage
    public override decimal CalcCost()
    {
        const double HEAVY_PACKAGE = .25;
        const double LARGE_PACKAGE = .25;
        const double OVERALL_DiMESNION = .40;
        const double WEIGHT_PACKAGE = .30;
        decimal totalcost;

        //Total Cost method that will return the overall cost of the package
        totalcost = (decimal)(OVERALL_DiMESNION * OverallCapacity + WEIGHT_PACKAGE * Weight) + ExpressFee;
        if (IsHeavy())
            totalcost = (decimal)(HEAVY_PACKAGE * Weight);
        if (IsLarge())
            totalcost = (decimal)(LARGE_PACKAGE * OverallCapacity);

        return totalcost; 
            
    }

    //Create a too string mehtod to display our final  information
    public override string ToString()
    {
        string NL = Environment.NewLine;

        return $"NextDayAirPackage{base.ToString()}{NL}Express Fee: {ExpressFee:C}";
    }
}
