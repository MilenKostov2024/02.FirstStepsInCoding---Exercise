// Четене на входните данни
int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

// Цени на материалите
double nylonPricePerSqM = 1.50;
double paintPricePerLiter = 14.50;
double thinnerPricePerLiter = 5.00;
double bagPrice = 0.40;

// Добавки към материалите
double totalNylon = nylon + 2;
double totalPaint = paint * 1.10;

// Общо разходи за материали
double nylonCost = totalNylon * nylonPricePerSqM;
double paintCost = totalPaint * paintPricePerLiter;
double thinnerCost = thinner * thinnerPricePerLiter;
double materialCost = nylonCost + paintCost + thinnerCost + bagPrice;

// Разходи за майстори
double laborCost = materialCost * 0.30 * hours;

// Общо разходи
double totalCost = materialCost + laborCost;

// Резултат
Console.WriteLine($"{totalCost:F2}");