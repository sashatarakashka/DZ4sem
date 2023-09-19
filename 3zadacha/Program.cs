int[] Array = new int[8];
Random rnd = new Random(); 
for (int i=0; i<8; i++)
{
Array[i] = rnd.Next(0,99);
Console.Write($"{Array[i]} ");
}
Console.WriteLine();