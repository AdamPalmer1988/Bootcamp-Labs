namespace UsedCarLot;

internal class UsedCar : Car
{
    //parameters
    public double Milage { get; set; }

    //constructors

    public UsedCar (string Make, string Model, int Year, decimal Price, double Milage) : base(Make, Model, Year, Price) 
    {
        this.Milage = Milage;
    }

    //methods
    public override string ToString()
    {
        return "Make: " + Make + " Model: " + Model + 
            " Year: " + Year + " Price: " + Price + 
            " Milage: " + Milage;
    }
}
