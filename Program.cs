// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello C#!");
Random dice = new Random();

int roll1 = dice.Next(1,7);

int roll2 = dice.Next(101);

int roll3 = dice.Next(30, 40);

Console.WriteLine($"first roll: {roll1}, second roll: {roll2}, third roll: {roll3}");
