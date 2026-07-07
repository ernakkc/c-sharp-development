Console.WriteLine("Hello World!");
Console.WriteLine("This is a simple C# program.");
Console.WriteLine('b');

/*
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits
*/
Console.WriteLine(123);
Console.WriteLine(12.2F);
Console.WriteLine(12312.2131312m);

// BOOLEAN
Console.WriteLine(true);
Console.WriteLine(false);

// Veriable Definition
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

userOption = 'a';
gameScore = 100;
processedCustomer = true;

Console.WriteLine(userOption);
Console.WriteLine(gameScore);

var message = "Hello World!";
Console.WriteLine(message);

// Formatting Strings
Console.WriteLine("Merhaba\tDünya");
Console.WriteLine("Merhaba\nDünya");
Console.WriteLine("Merhaba \"Dünya\"");
Console.WriteLine("c:\\source\\repos");
Console.WriteLine(@"First Row
                 Second Row   ");
Console.WriteLine(@"c:\source\repos");
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");
string firstName = "Eren";
string fullName = firstName + "Akkoç";
Console.WriteLine(fullName);
string messagee = $"{firstName} Akkoç";
Console.WriteLine(messagee);


decimal degisken = 1.49429349234923429;
(int) degisken;