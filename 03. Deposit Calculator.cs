double deposit = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine()) / 100;

double sum = deposit + months * ((deposit * percent) / 12);

Console.WriteLine(sum);