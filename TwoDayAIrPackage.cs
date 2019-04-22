using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TwoDayAirPackage : AirPackage
{
    //Set to tell us if the delivery will receive a discount
    public enum Delivery { Early, Saver }

    //Created specific values for all the dimesnions and fee
    public TwoDayAirPackage(Address originAddress, Address destinAddress, double tLength, double tWidth, double tHeight, double tWeight, Delivery deltype)
       : base(originAddress, destinAddress, tLength, tWidth, tHeight, tWeight)
    {
        DeliveryType = deltype;
    }

    //Get and Set property to return the delivery type
    public Delivery DeliveryType
    {
        get;


        set;
    }

    //Creat a Calc Cost Method to display the total cost of our packages
    public override decimal CalcCost()
    {
        //Real Numbers that represent the price our package dimensions and package discount
        const double OVERALL_DIMENSION = .25;
        const double WEIGHT_PACKAGE = .25;
        const double PACKAGE_DISCOUNT = .10;

        decimal totalcost;

        //Represents to the total cost of the package with/wo discount
        totalcost = (decimal)(OVERALL_DIMENSION * OverallCapacity + WEIGHT_PACKAGE * Weight);
        if (DeliveryType == Delivery.Saver)
            totalcost = (decimal)(1 - PACKAGE_DISCOUNT);

        return totalcost;

    }
    //Create a too string mehtod to display our final  information
    public override string ToString()
    {
        string NL = Environment.NewLine; 

        return $"TwoDayAirPackage{base.ToString()}{NL}Delivery Type: {DeliveryType}";
    }
}
