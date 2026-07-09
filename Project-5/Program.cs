using System.Diagnostics.Metrics;

decimal a = 5.91211231m;
Console.WriteLine(a); // 5.91211231

int b = (int) a;
Console.WriteLine(b); // 5

int c = Convert.ToInt32(a);
Console.WriteLine(c); // 6


string myString = "10";
int myInt = int.Parse(myString);
Console.WriteLine(myInt.GetType()); // System.Int32



// ARRAY
string[] myArray = ["b","a","d","c"];

Array.Sort(myArray);
foreach (var item in myArray)
{
    Console.WriteLine(item); // a b c d
}

Array.Clear(myArray, 1,2);
foreach (var item in myArray)
{
    Console.WriteLine(item); // a [] [] d
}

Array.Resize(ref myArray, 6);
var counter = 0;
foreach (var item in myArray)
{
    Console.WriteLine($"Index: {counter}\tValue: {item}");
    counter++;
    /*
    Index: 0        Value: a
Index: 1        Value: 
Index: 2        Value: 
Index: 3        Value: d
Index: 4        Value: 
Index: 5        Value: 
*/
}



string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));