// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets =  ["B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// Console.WriteLine(result);

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// my solution
// string pangram = "The quick brown fox jumps over the lazy dog";
// string pangramJoin = "";
// string[] pangramSplit = pangram.Split(" ");
// for (int i = 0; i < pangramSplit.Length; i++)
// {
//     char[] valueArray = pangramSplit[i].ToCharArray();
//     Array.Reverse(valueArray);
//     Console.WriteLine(valueArray);
//     string newPangram = new string(valueArray);
//     Console.WriteLine($"New item: {newPangram}");
//     pangramJoin += newPangram + " ";

// }
// Console.WriteLine($"New String: {pangramJoin}");

// string pangram = "The quick brown fox jumps over the lazy dog";

// //Step 1 - Split
// string[] message = pangram.Split(" ");
// //Step 2 - create a new array
// string[] newMessage = new string[message.Length];
// //Step 3 loop it though with reversed value
// for(int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters); 
// }

// string result = String.Join(" ", newMessage);
// Console.WriteLine (result);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderStreamSplit = orderStream.Split(",");
Array.Sort(orderStreamSplit);

for(int i = 0; i < orderStreamSplit.Length; i++)
{

    if (orderStreamSplit[i].Length != 4)
    {
        Console.WriteLine(orderStreamSplit[i] + "\t- Error");
    }
    else Console.WriteLine(orderStreamSplit[i]);
}
