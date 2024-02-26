string stringMessage = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = stringMessage.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");


// string[] orderIDs = {
// "B123",
// "C234",
// "A345",
// "C15",
// "B177",
// "G3003",
// "C235",
// "B179"};

// foreach (string orderId in orderIDs)
// {
//     if (orderId.StartsWith('B'))
//     {
//         Console.WriteLine($"Order name of {orderId} starts with 'B'!");
//     }
// }
// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }


// int[] inventory = { 200, 450, 700, 175, 250 };

// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

// string[] fraudulentOrderIDs = new string[3];


// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// // Reassigning the value of the first array element
// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"Reassigned First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"Array Length: {fraudulentOrderIDs.Length}");
// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// Console.WriteLine($"Days until Expiration = {daysUntilExpiration}");

// if (daysUntilExpiration <=10){
//     if(daysUntilExpiration ==0){
//         Console.WriteLine("Your subscription has expired.");
//     } else if (daysUntilExpiration ==1){
//         Console.WriteLine("Your subscription expires within a day! \nRenew now and save 20%!");
//     }  else if (daysUntilExpiration >1 && daysUntilExpiration <=5){
//         Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
//     } else{
//         Console.WriteLine("Your subscription will expire soon. Renew now!");
//     }

// }

// Your code goes here

// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Random dice = new();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);


// // int roll1 = 6;
// // int roll2 = 6;
// // int roll3 = 6;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2 || roll1 == roll3 || roll2 == roll3))
// {
//     if (roll1 == roll2 && roll2 == roll3)
//     {
//         total += 6;
//         Console.WriteLine("You rolled a triples!  +6 bonus to total!");
//     }
//     else
//     {
//         total += 2;
//         Console.WriteLine("You rolled a doubles!  +2 bonus to total!");
//     }

// }


// Console.WriteLine($"Total: {total}");


// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total>=10 && total <16)
// {
//     Console.WriteLine("You win a new laptop!");
// } else if(total == 7){
//     Console.WriteLine("You win a trip to somewhere!");
// } else{
//     Console.WriteLine("You win a kitten!");
// }