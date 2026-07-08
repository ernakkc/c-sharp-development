string myStr = "Merhaba Dünya!";
Console.WriteLine(myStr);

string newStr = string.Format("{0} {1}!", "Merhaba", "Dünya");
Console.WriteLine(newStr);

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units"); 
Console.WriteLine($"Measurement: {measurement:P20} units"); 

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12, '-')); 