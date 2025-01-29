// Input
int annualFee = int.Parse(Console.ReadLine());

// Calculations
double sneakers = annualFee * 0.6;  // 40% по-евтино
double outfit = sneakers * 0.8;     // 20% по-евтино от кецовете
double ball = outfit / 4;           // 1/4 от екипа
double accessories = ball / 5;      // 1/5 от топката

double totalCost = annualFee + sneakers + outfit + ball + accessories;

// Output
Console.WriteLine($"{totalCost:F2}"); // Форматиране до 2 знака след запетаята