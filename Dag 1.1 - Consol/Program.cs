// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Write your first C# code

//C# is a case-sensitive language.

//The difference between Console.Write and Console.WriteLine
//To print an entire message to the output console, you used the first technique, Console.WriteLine().
//At the end of the line, it added a line feed similar to how to create a new line of text by pressing Enter or Return.

//To print to the output console, but without adding a line feed at the end, you used the second technique, Console.Write().
//So, the next call to Console.Write() prints another message to the same line.

//What is compilation? – A special program called a compiler converts your source code into a different format that the computer's central processing unit (CPU) can execute
//What is syntax? – The rules for writing C# code is called syntax. 


Console.WriteLine("Hello World");

//Detailed explaination of what the different thing mean og do 
//Console.WriteLine("Hello World");
//When the phrase is surrounded by double-quotation marks in your C# code, it's called a literal string.
//The Console part is called a class. Classes "own" methods; or you could say that methods live inside of a class.
//The period is the member access operator. In other words, the dot is how you "navigate" from the class to one of its methods.
//The WriteLine() part is called a method. You can always spot a method because it has a set of parentheses after it. Each method has one job. The WriteLine() method's job is to write a line of data to the output console.
//The parentheses are known as the method invocation operator.
//Finally, the semicolon is the end of statement operator. A statement is a complete instruction in C#. The semicolon tells the compiler that you've finished entering the command.

Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");

Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");

//Store and retrieve data using literal and variable value in C#

//What is a literal value? – A literal value is a constant value that never changes.
//Use the string data type whenever you have alphanumeric words, phrases, or data for presentation, not calculation.

Console.WriteLine('b');

//Single quotes create a character literal. Single quptrs cannot be used for strings.


//Use interger Literals
//If you want to display a numeric whole number (no fractions) value in the output console, you can use an int literal. 
Console.WriteLine(123);

//Use floating-point literals
//A floating-point number is a number that contains a decimal, for example 3.14159. C# supports three data types to represent decimal numbers: float, double, and decimal. Each type supports varying degrees of precision.
//Float – 6-9 digits, Double – 15-17 digits, Decimal – 28-29 digits
//To create a float literal, append the letter F after the number. In this context, the F is called a literal suffix. The literal suffix tells the compiler you wish to work with a value of float type. You can use either a lower-case f or upper-case F as the literal suffix for a float.
Console.WriteLine(0.25F);

//To create a double literal, just enter a decimal number. The compiler defaults to a double literal when a decimal number is entered without a literal suffix.
Console.WriteLine(2.625);

//To create a decimal literal, append the letter m after the number. 
Console.WriteLine(12.39816m);

//Use Boolean Literals
//If you wanted to print a value representing either true or false, you could use a bool literal.
Console.WriteLine(true);
Console.WriteLine(false);

//Recap:

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
