//Input
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

//Calculations
double volumeCm3 = length * width * height; 
double volumeLiters = volumeCm3 / 1000; 
double neededLiters = volumeLiters * (1 - percent / 100);

//Output
Console.WriteLine($"{neededLiters:F3}");