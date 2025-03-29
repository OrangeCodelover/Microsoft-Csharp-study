// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

/////////// Doesn't work
////
// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

/////////// It works
///
// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// string value = "-103.5";
// decimal result = 0;
// if (decimal.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// decimal NumericResult = 0;
// decimal sumNumericResult = 0;
// string sumStringResult = "";
// for (int i = 0; i < values.Length; i++)
// {
//     if (decimal.TryParse(values[i], out NumericResult))
//     {
//         sumNumericResult += NumericResult;
//         // Console.WriteLine("The sum so far is :" + sumNumericResult);
//     }
//     else
//     {
//         sumStringResult += values[i];
//     }
// }
// Console.WriteLine($"Message: {sumStringResult}");
// Console.WriteLine($"Total: {sumNumericResult}");

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// decimal result1 = (decimal)value1 / value2;
// result1 = Convert.ToInt32(result1);
int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");