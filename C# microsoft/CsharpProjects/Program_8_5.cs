////////////////////Project 1/////////////////////////////////

// Console.WriteLine("Please choose a number between 5 and 10:");
// string? userInput = Console.ReadLine();

// int numericValue = 0;
// bool validNumber = false;

// validNumber = int.TryParse(userInput, out numericValue);

// // Console.WriteLine($"Please choose a number between 5 and 10: {userInput}");
// do
// {
//     validNumber = int.TryParse(userInput, out numericValue);
//     if (numericValue >=5 && numericValue <=10)
//     {
//         Console.WriteLine($"Your answer __{numericValue}__ has been accepted.");
//         break;
//     }

//     else 
//     {
//         Console.WriteLine("Try again");
//         Console.WriteLine("Please choose a number between 5 and 10:");
//         userInput = Console.ReadLine();
//     }
// } while (validNumber);

////////////////////Project 2/////////////////////////////////

// using System.IO.Compression;

// Console.WriteLine("Enter your role name (Adminstrator, Manager, or User)");
// string? userInput = Console.ReadLine();

// do{
//     userInput = userInput.Trim();
//     userInput = userInput.ToLower();

//     if (userInput == "administrator")
//     {
//         Console.WriteLine($"Your input value {userInput} has been accepted.");
//         break;
//     }

//     else if (userInput == "manager")
//     {
//         Console.WriteLine($"Your input value {userInput} has been accepted.");
//         break;
//     }

//     else if (userInput == "user")
//     {
//         Console.WriteLine($"Your input value {userInput} has been accepted.");
//         break;
//     }

//     else 
//     {
//         Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");

//         userInput = Console.ReadLine();
//     }
// }while(true);

////////////////////Project 3/////////////////////////////////

using System;
using System.Xml;

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;
foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf(".");
    string myNewString = myString;
    if (periodLocation > 0)
    {
        do
        {
            Console.WriteLine(myNewString.Substring(0, periodLocation));
            myNewString = myNewString.Remove(0, periodLocation + 1);
            // Console.WriteLine($"my string: {myNewString}");
            myNewString = myNewString.TrimStart(' ');
            periodLocation = myNewString.IndexOf(".");
            if (periodLocation == -1) Console.WriteLine(myNewString);
        }
        while (periodLocation != -1);
    }
    else Console.WriteLine(myString);


}