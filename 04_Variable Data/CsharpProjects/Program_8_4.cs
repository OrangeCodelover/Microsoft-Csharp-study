// //Composite Formatting
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// //string interpolation
// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// // To display $ for each regions
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// // To display numeric format specificer with 2 digits
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// // With 4 digits
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// // To display percentage
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// //Combined
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);


// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine("As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine("");
Console.WriteLine($"Currently, you own {currentShares :N2} shares at a return of {currentReturn :P2}.");
Console.WriteLine("");
Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn :P2}.  Given your current volume, your potential profit would be {newProfit :C}.");

Console.WriteLine("\nHere's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
// comparisonMessage = $"{currentProduct.PadRight(15)} {currentReturn:P2}  {currentProfit:C}";
// comparisonMessage += "\n";
// comparisonMessage += $"{newProduct.PadRight(15)} {newReturn:P2}  {newProfit:C}";

comparisonMessage = currentProduct.PadRight(15);
comparisonMessage += string.Format("{0 :P}", currentReturn).PadLeft(15);
comparisonMessage += string.Format("{0 :C}", currentProfit).PadLeft(20);
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(15);
comparisonMessage += string.Format("{0 :P}", newReturn).PadLeft(15);
comparisonMessage += string.Format("{0 :C}", newProfit).PadLeft(20);

Console.WriteLine(comparisonMessage);