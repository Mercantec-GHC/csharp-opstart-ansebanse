// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write your first C# code

Console.WriteLine("Hello World");
//Console.WriteLine("Hello World");

Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");

Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");

//Store and retrieve data using literal and variable value in C#

Console.WriteLine('b');
Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);

Console.WriteLine(true);
Console.WriteLine(false);

Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);

//string firstName;

//char userOption;

//int gameScore;

//decimal particlesPerMillion;

//bool processedCustomer;

//string firstName;
//firstName = "Bob";
//Console.WriteLine(firstName);

string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

var message = "Hello world!";

//Challange 

string name;
name = "Bob";

int number;
number = 3;

decimal degree;
degree = 34.4m;

Console.WriteLine("Hello, ");
Console.WriteLine(name);
Console.WriteLine("! You have ");
Console.WriteLine(number);
Console.Write(" message in your inbox. The temperature is ");
Console.Write(degree);
Console.WriteLine("celsius.");

//Preform basic string formatting in C#
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("Hello \"World\"!");

Console.WriteLine("c:\\source\\repos");


Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

//string firstName = "Bob";
//string message = "Hello " + firstName;
//Console.WriteLine(message);

//string firstName = "Bob";
//string greeting = "Hello";
//string message = greeting + " " + firstName + "!";
//Console.WriteLine(message);

//string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

//string message = greeting + " " + firstName + "!";
string message1 = $"{greeting} {firstName}!";

//string firstName = "Bob";
//string message = $"Hello {firstName!";
//Console.WriteLine(message1);

int version = 11;
string updateText = "Update to Windows";
//string message = $"{updateText} {version}";
Console.WriteLine(message);

//int version = 11;
//string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//string projectName = "ACME";

//string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

//string projectName = "ACME";
//string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
//Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

//string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
//string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
//Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

//Perform basic operations on numbers in C#

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string first1Name = "Bob";
int widgetsSold = 7;
Console.WriteLine(first1Name + " sold " + widgetsSold + " widgets.");

string first2Name = "Bob";
int widgets2Sold = 7;
Console.WriteLine(first2Name + " sold " + widgets2Sold + 7 + " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

int first = 7;
int second = 5;
decimal quotient1 = (decimal)first / (decimal)second;
Console.WriteLine(quotient1);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

//Increment and decrement 
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

//int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
//va2lue++;           // value is now 2.

//int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

//int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");

//There's 2 steps to this line 
//1. Retrieve the current value of the variable value and use that in the string interpolation operation.
//2. Increment the value.

Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

//Solution to convert Fahrenheit to Celsius 
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");
