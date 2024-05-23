int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

//Find the Minimum value
Console.WriteLine("Min:");
Console.WriteLine(nums.Min());

//Find the Maximum value
Console.WriteLine("Max:");
Console.WriteLine(nums.Max());

//Find the Maximum value less than 10000
Console.WriteLine("Find the Maximum value less than 10000:");
List<int> maximumLessThan1000 = nums.Where(x => x < 10000).ToList();

Console.WriteLine(maximumLessThan1000.Max());

//Find all values between 10 and 1000
Console.WriteLine("Find all values between 10 and 1000:");
List<int> valuesBetween10and1000 = nums.Where(x => x < 1001 && x > 9).ToList();

for (int i = 0; i < valuesBetween10and1000.Count; i++)
{
    Console.WriteLine(valuesBetween10and1000[i]);
}

//Find all Values between 100000 and 999999 inclusive

Console.WriteLine("Find all Values between 100000 and 999999 inclusive:");
List<int> valuesBetween10000and999999inclusive = nums.Where(x => x > 9999 && x < 1000000).ToList();

for (int i = 0; i < valuesBetween10000and999999inclusive.Count; i++)
{
    Console.WriteLine(valuesBetween10000and999999inclusive[i]);
}

//Count all the even number

Console.WriteLine("Count all the even numbers:");
List<int> allTheEvenNumbers = nums.Where(x => x % 2 == 0).ToList();

for (int i = 0; i < allTheEvenNumbers.Count; i++ )
{
    Console.WriteLine(allTheEvenNumbers[i]);
}