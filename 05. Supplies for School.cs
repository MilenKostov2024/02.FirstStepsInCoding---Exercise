//Prices
double penPacketPrice = 5.80;
double marketsPacketPrice = 7.20;
double cleanerLiterPrice = 1.20;

//Input
int penPacketsCount = int.Parse(Console.ReadLine());
int markersPacketsCount = int.Parse(Console.ReadLine());
int cleanerLitersCount = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

//Calculations
double bill = (penPacketPrice * penPacketsCount) +
    (marketsPacketPrice * marketsPacketPrice) +
    (cleanerLiterPrice * cleanerLiterPrice);

double billWithDiscount = bill - (bill * (percentDiscount / 100));

//Output
Console.WriteLine(billWithDiscount);