using UsedCarLot;

List<Car> Cars = new List<Car>();

Car Nikolai = new();
Car Fourd = new();
Car Chewie = new();

UsedCar Prior = new("Hyonda", "Prior", 2015, 14795.50m, 35987.6);
UsedCar Chirpus = new("GC", "Chirpus", 2013, 8500.00m, 12345.0);
UsedCar Witherell = new("GC", "Witherell", 2016, 14450.00m, 3500.3);

Nikolai.Make = "Nikolai";
Nikolai.Model = "Model S";
Nikolai.Year = 2017;
Nikolai.Price = 54999.90m;

Fourd.Make = "Fourd";
Fourd.Model = "Escapade";
Fourd.Year = 2017;
Fourd.Price = 31999.90m;

Chewie.Make = "Chewie";
Chewie.Model = "Vette";
Chewie.Year = 2017;
Chewie.Price = 44989.98m;

Cars.Add(Nikolai);
Cars.Add(Fourd);
Cars.Add(Chewie);
Cars.Add(Prior);
Cars.Add(Chirpus);
Cars.Add(Witherell);

Car.ListCars(Cars);

int carNumber = 0;

Console.WriteLine("Which car would you like to buy?");
carNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"You are purchasing {Cars[carNumber - 1]}");

Car.Remove(Cars, carNumber -1);

Console.WriteLine("The remaining cars available are...");
Car.ListCars(Cars);
