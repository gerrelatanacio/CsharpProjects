﻿string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = $"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.\n\nHere's a quick comparison:\n\n{currentProduct}\t\t{currentReturn:P2}\t{currentProfit:C}\n\n{newProduct}\t\t{newReturn:P2}\t{newProfit:C}";

// // Your logic here

// Console.WriteLine(comparisonMessage);

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// string myWords = "Learning C#";
// Console.WriteLine(myWords.PadLeft(12));

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orderIDsArray = orderStream.Split(",");

// Array.Sort(orderIDsArray);

// for(int i=0; i<orderIDsArray.Length; i++){
//     //Check if the orderId length is less than 4 characters then add " - Error" in the order id"
//     if(orderIDsArray[i].Length != 4){
//         orderIDsArray[i] = orderIDsArray[i] + "\t- Error";
//     }
//     Console.WriteLine(orderIDsArray[i]);
// }


// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] words = pangram.Split(" ");
// // Array.Reverse(words);
// string pangramFinal ="";

// foreach (string word in words){
//     char[] newWordArray = word.ToCharArray();
//     Array.Reverse(newWordArray);
//     string newWord = String.Join("", newWordArray);
//     pangramFinal = pangramFinal + " " + newWord;
// }

// Console.WriteLine(pangramFinal.Trim());

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"\n-- {pallet}");
// }
// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// //Solve for result1: Divide value1 by value2, display the result as an int
// //Solve for result2: Divide value2 by value3, display the result as a decimal
// //Solve for result3: Divide value3 by value1, display the result as a float

// int result1 = Convert.ToInt32(value1 / value2);
// decimal result2 = value2 / (decimal)value3;
// float result3 = value3 / value1;


// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// decimal parsedValue = 0;
// decimal total = 0;
// string message = "";

// foreach (string value in values){
//     if(decimal.TryParse(value, out parsedValue)){
//         total += parsedValue;
//     }else{
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");


// using System.Diagnostics.Metrics;

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// foreach (string like in myStrings)
// {
//     if (like.Contains("."))
//     {
//         string[] dissassembledLike = like.Split(".");
//         int counter = 0;
//         do
//         {
//             Console.WriteLine(dissassembledLike[counter].Trim());
//             counter++;
//         } while (counter < dissassembledLike.Length);
//     }
//     else
//     {
//         Console.WriteLine(like.Trim());
//     }
// }



// /*string? readLine;
// string? roleEntered = "";
// bool validRole = false;

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

// do
// {
//     roleEntered = readLine = Console.ReadLine();
//     switch (roleEntered)
//     {
//         case "Administrator":
//             Console.WriteLine($"Your input value ({roleEntered}) has been accepted.");
//             validRole = true;
//             break;
//         case "Manager":
//             Console.WriteLine($"Your input value ({roleEntered}) has been accepted.");
//             validRole = true;
//             break;
//         case "User":
//             Console.WriteLine($"Your input value ({roleEntered}) has been accepted.");
//             validRole = true;
//             break;
//         default:
//             Console.WriteLine($"The role name that you entered, \"{roleEntered}\" is not valid. Enter your role name (Administrator, Manager, or User");
//             break;
//     }

// } while (validRole == false);
// */
// /*
// string? readLine;
// int enteredValue = 0;

// Console.WriteLine("Enter an integer value between 5 and 10");
// do
// {
//     readLine = Console.ReadLine();
//     bool validNumber = false;
//     validNumber = int.TryParse(readLine, out enteredValue);

//     if (validNumber == false)
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again - Enter a number between 5 and 10: ");
//         continue;
//     }
//     if (!(enteredValue >= 5 && enteredValue <= 10))
//     {
//         Console.WriteLine($"You entered {enteredValue}. Please enter a number between 5 and 10.");
//         continue;
//     }
//     else
//     {
//         Console.WriteLine($"Your input value ({enteredValue}) has been accepted");
//         continue;
//     }
// } while (!(enteredValue >= 5 && enteredValue <= 10));
// */


// // string? readResult;
// // bool validEntry = false;
// // Console.WriteLine("Enter a string containing at least three characters:");
// // do
// // {
// //     readResult = Console.ReadLine();
// //     if (readResult != null)
// //     {
// //         if (readResult.Length >= 3)
// //         {
// //             validEntry = true;
// //         }
// //         else
// //         {
// //             Console.WriteLine("Your input is invalid, please try again.");
// //         }
// //     }
// // } while (validEntry == false);

// // int heroHealth = 10;
// // int monsterHealth = 10;
// // Random attack = new Random();
// // int counter = 1;

// // do
// // {
// //     Console.WriteLine($"Current Counter at: {counter}");
// //     if (counter % 2 != 0)
// //     {
// //         int currentAttack = attack.Next(1, 11);
// //         monsterHealth -= currentAttack;
// //         Console.WriteLine($"Monster was damaged and lost {currentAttack} health and now has {monsterHealth} health.");
// //     }
// //     else {
// //         int currentAttack = attack.Next(1, 11);
// //         heroHealth -= currentAttack;
// //         Console.WriteLine($"Hero was damaged and lost {currentAttack} health and now has {heroHealth} health.");
// //     }

// //     if (heroHealth<=0 || monsterHealth <=0){
// //         if (monsterHealth<=0) Console.WriteLine("Hero Wins");
// //         else Console.WriteLine("Monster Wins");
// //     }

// //     counter++;

// // } while (heroHealth > 0 && monsterHealth > 0);

// // Random random = new Random();
// // int current = random.Next(1, 11);

// // do
// // {
// //     current = random.Next(1, 11);

// //     if (current >= 8) continue;

// //     Console.WriteLine(current);
// // } while (current != 7);

// /*
// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");
// */


// // Random random = new Random();
// // int current = 0;
// // int iteration = 0;

// // do
// // {
// //     current = random.Next(1, 11);
// //     Console.WriteLine(current);
// //     iteration+=1;
// // } while (current != 7);
// // Console.WriteLine($"It needed {iteration} iterations to get value rolls of 7");

// // for (int i = 1; i <=100; i++){
// //     if ((i%3 ==0) && (i%5 ==0)) Console.WriteLine($"{i} - FizzBuzz");
// //     else if(i%3 ==0) Console.WriteLine($"{i} - Fizz");
// //     else if (i%5 ==0) Console.WriteLine($"{i} - Buzz");
// //     else Console.WriteLine($"{i} - ");
// // }

// // string sku = "01-MN-L";

// // string[] product = sku.Split('-');


// // string productCode = product[0];
// // string type = "";
// // string colorCode = product[1];
// // string color = "";
// // string sizeCode = product[2];
// // string size = "";

// // switch (productCode)
// // {
// //     case "01":
// //         type = "Sweat Shirt";
// //         break;
// //     case "02":
// //         type = "T-Shirt";
// //         break;
// //     case "03":
// //         type = "Sweat pants";
// //         break;
// //     default:
// //         type = "Other";
// //         break;
// // }


// // switch (colorCode)
// // {
// //     case "BL":
// //         color = "Black";
// //         break;
// //     case "MN":
// //         color = "Maroon";
// //         break;
// //     default:
// //         type = "White";
// //         break;
// // }


// // switch (sizeCode)
// // {
// //     case "S":
// //         size = "Small";
// //         break;
// //     case "M":
// //         size = "Medium";
// //         break;
// //     case "L":
// //         size = "Large";
// //         break;
// //     default:
// //         size = "One Size Fits All";
// //         break;
// // }


// // Console.WriteLine($"Product: {size} {color} {type}");
// // int x = 1;
// // if (x > 0)
// // {
// //     int y = 8;
// //     x += y;

// // }
// // Console.WriteLine(x);

// // int[] numbers = { 4, 8, 15, 16, 23, 42 };
// // int total = 0;
// // bool found = false;

// // foreach (int number in numbers)
// // {
// //     total += number;
// //     if (number == 42) found = true;

// // }

// // if (found) Console.WriteLine("Set contains 42");
// // Console.WriteLine($"Total: {total}");
// // bool flag = true;
// // int value = 5;

// // if (flag)
// // {
// //     value = 10;
// //     Console.WriteLine($"Inside the code block: {value}");
// // }

// // Console.WriteLine($"Outside the code block: {value}");


// // string permission = "Admxin|MaXnager";
// // int level = 10;

// // Console.WriteLine("");

// // if (permission.Contains("Admin"))
// // {
// //     if (level > 55)
// //     {
// //         Console.WriteLine("Welcome, Super Admin user.");
// //     }
// //     else if (level <= 55)
// //     {
// //         Console.WriteLine("Welcome, Admin user.");
// //     }

// // }
// // else if (permission.Contains("Manager"))
// // {
// //     if (level >= 20)
// //     {
// //         Console.WriteLine("Contact an Admin for access.");
// //     }
// //     else if (level < 20)
// //     {
// //         Console.WriteLine("You do not have sufficient privileges.");
// //     }

// // }
// // else
// // {
// //     Console.WriteLine("You do not have sufficient privileges.");
// // }

// // Random coin = new();
// // String coinFlipResult = coin.Next(0,2) == 0 ? "\nheads" : "tails";

// // Console.Write(coinFlipResult);
// // Console.WriteLine("a" == "a");
// // Console.WriteLine("a" == "A");
// // Console.WriteLine(1 == 2);

// // string myValue = "a";
// // Console.WriteLine(myValue == "a");


// // string stringMessage = "The quick brown fox jumps over the lazy dog.";
// // // convert the message into a char array
// // char[] charMessage = stringMessage.ToCharArray();
// // // Reverse the chars
// // Array.Reverse(charMessage);
// // int x = 0;
// // // count the o's
// // foreach (char i in charMessage) { if (i == 'o') { x++; } }
// // // convert it back to a string
// // string new_message = new String(charMessage);
// // // print it out
// // Console.WriteLine(new_message);
// // Console.WriteLine($"'o' appears {x} times.");


// // string[] orderIDs = {
// // "B123",
// // "C234",
// // "A345",
// // "C15",
// // "B177",
// // "G3003",
// // "C235",
// // "B179"};

// // foreach (string orderId in orderIDs)
// // {
// //     if (orderId.StartsWith('B'))
// //     {
// //         Console.WriteLine($"Order name of {orderId} starts with 'B'!");
// //     }
// // }
// // string[] names = { "Rowena", "Robin", "Bao" };
// // foreach (string name in names)
// // {
// //     Console.WriteLine(name);
// // }


// // int[] inventory = { 200, 450, 700, 175, 250 };

// // int sum = 0;
// // int bin = 0;
// // foreach (int items in inventory)
// // {
// //     sum += items;
// //     bin++;
// //     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// // }

// // Console.WriteLine($"We have {sum} items in inventory.");

// // string[] fraudulentOrderIDs = new string[3];


// // fraudulentOrderIDs[0] = "A123";
// // fraudulentOrderIDs[1] = "B456";
// // fraudulentOrderIDs[2] = "C789";

// // Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// // Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// // // Reassigning the value of the first array element
// // fraudulentOrderIDs[0] = "F000";
// // Console.WriteLine($"Reassigned First: {fraudulentOrderIDs[0]}");

// // Console.WriteLine($"Array Length: {fraudulentOrderIDs.Length}");
// // Random random = new Random();
// // int daysUntilExpiration = random.Next(12);
// // int discountPercentage = 0;

// // Console.WriteLine($"Days until Expiration = {daysUntilExpiration}");

// // if (daysUntilExpiration <=10){
// //     if(daysUntilExpiration ==0){
// //         Console.WriteLine("Your subscription has expired.");
// //     } else if (daysUntilExpiration ==1){
// //         Console.WriteLine("Your subscription expires within a day! \nRenew now and save 20%!");
// //     }  else if (daysUntilExpiration >1 && daysUntilExpiration <=5){
// //         Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
// //     } else{
// //         Console.WriteLine("Your subscription will expire soon. Renew now!");
// //     }

// // }

// // Your code goes here

// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


// // Random dice = new();

// // int roll1 = dice.Next(1, 7);
// // int roll2 = dice.Next(1, 7);
// // int roll3 = dice.Next(1, 7);


// // // int roll1 = 6;
// // // int roll2 = 6;
// // // int roll3 = 6;

// // int total = roll1 + roll2 + roll3;

// // Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// // if ((roll1 == roll2 || roll1 == roll3 || roll2 == roll3))
// // {
// //     if (roll1 == roll2 && roll2 == roll3)
// //     {
// //         total += 6;
// //         Console.WriteLine("You rolled a triples!  +6 bonus to total!");
// //     }
// //     else
// //     {
// //         total += 2;
// //         Console.WriteLine("You rolled a doubles!  +2 bonus to total!");
// //     }

// // }


// // Console.WriteLine($"Total: {total}");


// // if (total >= 16)
// // {
// //     Console.WriteLine("You win a new car!");
// // }
// // else if (total>=10 && total <16)
// // {
// //     Console.WriteLine("You win a new laptop!");
// // } else if(total == 7){
// //     Console.WriteLine("You win a trip to somewhere!");
// // } else{
// //     Console.WriteLine("You win a kitten!");
// // }