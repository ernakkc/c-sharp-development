string[] first = new string[3];
first[0] = "A123";
first[1] = "B456";
first[2] = "C789";
Console.WriteLine(first);

string[] second = ["A123", "B456", "C789"];
Console.WriteLine(second);

string[] third = {"A123", "B456", "C789"};
Console.WriteLine(third);

/*
System.String[]
System.String[]
System.String[]
*/

Console.WriteLine(first.Length); // 3

foreach (var item in first)
{
    Console.Write(item + "\t"); // A123    B456    C789    
}

