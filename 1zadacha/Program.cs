Console.Clear();
Console.WriteLine("Введите два числа ");
string text = Console.ReadLine();
int a = Convert.ToInt32(text);
string text2 = Console.ReadLine();
int b = Convert.ToInt32(text2);
double pow = Math.Pow(a,b);
Console.WriteLine(pow);