// Четене на входните данни
int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegetarianMenus = int.Parse(Console.ReadLine());

// Цени на менюта
double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegetarianMenuPrice = 8.15;

// Изчисляване на сумата за менюта
double totalMenuCost = (chickenMenus * chickenMenuPrice) + (fishMenus * fishMenuPrice) + (vegetarianMenus * vegetarianMenuPrice);

// Изчисляване на цената на десерта
double dessertCost = totalMenuCost * 0.20;

// Добавяне на доставка
double deliveryCost = 2.50;

// Обща цена
double totalCost = totalMenuCost + dessertCost + deliveryCost;

// Резултат
Console.WriteLine($"{totalCost:F2}");