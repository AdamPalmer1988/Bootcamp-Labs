namespace UsedCarLot;

internal class Car
{
    //parameter
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    //constructors
    public Car() { }

    public Car(string make, string model, int year, decimal price)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Price = price;
    }

    //methods

    public override string ToString()
    {
        return "Make: " + Make + " Model: " + Model + " Year: " + Year + " Price: " + Price ;
    }

    public static void ListCars(List<Car> Cars)
    {
        for (int i = 0; i < Cars.Count; i++) 
        {
            Console.WriteLine($"{i + 1}. {Cars[i].ToString()}");
        }
      
    }
    //Add a public static method to Car called Remove which takes an integer parameter and removes the car whose index is that parameter
    public static void Remove(List<Car> Cars, int carNumber)
    {
        Cars.RemoveAt(carNumber);
    }
}
