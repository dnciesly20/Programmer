using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Creating an Abstract PAckage class that is derived from the Parcel class
public abstract class Package : Parcel
{
    private double _thelength;
    private double _thewidth;
    private double _theheight;
    private double _theweight;

    //Created specific values for all the dimesnions and fee
    public Package(Address originAddress, Address destAddress, double tLength, double tWidth, double tHeight, double tWeight)
        : base(originAddress, destAddress)

    {
        Length = tLength;
        Width = tWidth;
        Height = tHeight;
        Weight = tWeight;

    }

    //Creating a property that gets the value of the Length
    public double Length
    {
        get
        {
            return _thelength;
        }

        //Creating a property that sets the value of the Length
        set
        {
            if (value > 0)
                _thelength = value;
            else
                throw new ArgumentOutOfRangeException("Length", value, "The Length has to have a value greater than 0");
        }
    }

    //Creasting a property that gets the vale of the Width
    public double Width
    {
        get
        {
            return _thewidth;
        }

        //Creating a property that sets the value of the Width
        set
        {
            if (value > 0)
                _thewidth = value;
            else
                throw new ArgumentOutOfRangeException("Width", value, "The Width has to have a value greater than 0");
        }
    }

    //Creating a property that gets the value of the Height
    public double Height
    {
        get
        {
            return _theheight;
        }

        //Creating a property thats sets the value of the Height
        set
        {
            if (value > 0)
                _theheight = value;
            else
                throw new ArgumentOutOfRangeException("Height", value, "The Height has to have a value greater than 0");
        }
    }
    
    //Creating a property that gets the value of the weight
    public double Weight
    {
        get
        {
            return _theweight;
        }
        
        //Creating a property that sets the value of the weight
        set
        {
            if (value > 0)
                _theweight = value;
            else
                throw new ArgumentOutOfRangeException("Weight", value, "The Weight has to have a value greater than 0");
        }
    }

    //Creating a property that gets the overall dimensions of the object
    protected double OverallCapacity
    {
        get
        {
            return (Length + Width + Height);
        }       
    }
    
    //Create a too string mehtod to display our final  information
    public override string ToString()
    
    {
        string NL = Environment.NewLine; 

        return $"Package{NL}{base.ToString()}{NL}Length: {Length:N1}{NL}Width: {Width:N1}{NL}" +
            $"Height: {Height:N1}{NL}Weight: {Weight:N1}";
    }
}

