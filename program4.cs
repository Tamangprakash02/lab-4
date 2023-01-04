Random coin = new Random();
int flip = coin.Next(0, 4);
Console.WriteLine((flip == 0) ? "heads" : "tails");