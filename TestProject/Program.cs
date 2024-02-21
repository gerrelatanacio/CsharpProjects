// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);


// int roll1 = 6;
// int roll2 = 6;
// int roll3 = 6;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 && roll2 == roll3){
    total+=6;
} else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    total += 2;
}


Console.WriteLine($"Total: {total}");


if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}