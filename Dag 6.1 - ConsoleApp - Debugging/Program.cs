// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Hello, World!");

//Review the principles of code debugging and exception handling
//Testing, debugging and exception handling

//Software testing and developer responsibilities
//Functional testing - Unit testing - Integration testing - System testing - Acceptance testing
//Nonfunctional testing - Security testing - Performance testing - Usability testing - Compatibility testing

//Code debugging and developer responsibilities

string[] students = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };

int studentCount = students.Length;

Console.WriteLine("The final name is: " + students[studentCount]);

//Exception handling and developer responsibilities
//errors that occur during the application runtime are referred to as exceptions

//Recap
//Testing, debugging, and exception handling are all important tasks for software developers.
//Testing can be categorized into functional and nonfunctional testing, and developers are expected to perform some level of testing.
//Code debugging is the process of isolating issues and identifying ways to fix them, and it's a developer responsibility.
//Exception handling is the process of managing errors that occur during runtime, and developers are responsible for handling exceptions by using "try" and "catch" statements in their code.

//Examine the code debugger approach to debugging code
//Code debugging process:
//Reading through your code (just one more time) hoping that this time the issue jumps out at you.
//Breadcrumbing a few Console.WriteLine("here") messages in your code to the track progress through your app.
//Rerunning your app with different data. Hoping that if you see what works, you'll understand what doesn't work.


//Why use a debugger?
//Control of your program execution. You can pause your program and run it step by step, which allows you to see what code is executed and how it affects your program's state.
//Observation of your program's state. For example, you can look at the value of your variables and function parameters at any point during your code execution.

//Recap
//Code debugging is a crucial skill in the software development process that every developer learns.
//The best approach to debugging your applications is to use a debugger, not rereading your code five times or adding console.WriteLine() statements throughout your code.
//Debuggers enable you to pause your application, step through your code line-by-line, and observe the state of variables and function parameters.

//Examine exceptions and how expetions are used
//What are exceptions?
//An exception gets created at runtime when your code produces an error.
//The exception can be treated like a variable that has some extra capabilities.
//You can write code that accesses the exception and takes corrective action.


//Implement the Visual Studio Code debugging tools for C#
//Første trin til debugging i Visual Studio på Windows er at åbne dit projekt i Visual Studio og navigere til det script eller kode, du ønsker at debugge.
//Her er en kort beskrivelse af de mest nødvendige ting.
//Under det er der lidt mere uddybende om et par emner.

//1. Sæt Breakpoints
//Klik på den grå bjælke ved siden af linjenummeret på den linje, du ønsker at debugge.
//Et rødt stoppunkt (breakpoint) vil fremkomme.
//Når koden kører, vil den stoppe ved denne breakpoint.

//2. Køre Din Kode:
//Klik på 'Start Debugging' eller tryk F% for at starte din kode.
//Programment vil køre intil det når din breakpoint

//3. Gennemse Din Kode:
//Nu kan du træde igennem din kode ved at bruge knapperne 'Step Into', 'Step Over' og 'Step Out' eller ved at trykke F10 og F11.
//Dette giver dig mulighed for at kontrollere, hvordan hvert trin i koden udføres og se værdierne af forskellige variabler på hvert trin.

//4. Se variabler:
//'Autos' og 'Locals' fanerne kan du se de aktuelle værdier af dine variabler. Dette kan hjælpe dig med at finde, hvor tingene går galt.

//5.Ændre variabelværdier:
//Du kan ændre værdien af variabler midt i en debugging session ved at højreklikke på variabelnavnet i 'Autos' eller 'Locals' fanen og vælge 'Modify Value'.
//Dette kan være nyttigt til at teste, hvordan forskellige værdier påvirker udførelsen af din kode.

//6. Fortsæt Kørsel:
//Når du er færdig med at træde igennem din kode, kan du trykke 'Continue' eller F5 for at fortsætte kørslen af din kode.

//Breakpoints
//I Visual Studio er der fem forskellige typer af breakpoints, der kan hjælpe med at gøre debugging - processen mere effektiv:

//1. Breakpoint:
//Dette er den mest almindelige type breakpoint, som stopper udførelsen af programmet ved en bestemt linje i koden.

//2. Condition Breakpoint:
//Dette breakpoint stopper kun udførelsen af programmet, hvis en bestemt betingelse er opfyldt.
//For eksempel kan du sætte et condition breakpoint, der stopper udførelsen, hvis en variabel når en bestemt værdi.

//3. Tracepoint:
//Dette er en speciel type breakpoint, der ikke stopper udførelsen af programmet, men i stedet logger en besked eller udfører en bestemt handling.
//Dette er nyttigt for at spore, hvad der sker i programmet uden at skulle stoppe det.

//4. Temporary Breakpoint:
//Dette er en type breakpoint, der kun er aktiv én gang.
//Når programmet når dette breakpoint, stopper det, og breakpointet fjernes derefter.
//Det er nyttigt, hvis du har et bestemt sted i koden, du vil inspicere, men kun én gang.

//5. Dependent Breakpoint:
//Dette er en type breakpoint, der kun aktiveres, når et andet breakpoint bliver ramt.
//Det er nyttigt, hvis du kun ønsker at stoppe udførelsen på et bestemt punkt i koden, efter et andet bestemt punkt er blevet ramt.

//Generelt bruger vi kun vores normale standart breakpoint, men der er nogle enkelte cases, hvor de andre er fordelagtige.

//Softwaretest (https://mercantec.notion.site/mercantec/Softwaretest-8e572827d9324fde873bf80b1bdda576)

//Debug C# console applications
//Examine exceptions and the exception handling process
//Common scenarios that require exception handling

//User input: Exceptions can occur when code processes user input. For example, exceptions occur when the input value is in the wrong format or out of range.
//Data processing and computations: Exceptions can occur when code performs data calculations or conversions. For example, exceptions occur when code attempts to divide by zero, cast to an unsupported type, or assign a value that's out of range.
//File input/output operations: Exceptions can occur when code reads from or writes to a file. For example, exceptions occur when the file doesn't exist, the program doesn't have permission to access the file, or the file is in use by another process.
//Database operations: Exceptions can occur when code interacts with a database. For example, exceptions occur when the database connection is lost, a syntax error occurs in a SQL statement, or a constraint violation occurs.
//Network communication: Exceptions can occur when code communicates over a network. For example, exceptions occur when the network connection is lost, a timeout occurs, or the remote server returns an error.
//Other external resources: Exceptions can occur when code communicates with other external resources. Web Services, REST APIs, or third-party libraries, can throw exceptions for various reasons. For example, exceptions occur due to network connections issues, malformed data, etc.

//Exception handling keywords, code blocks, and patterns
//Exception handling in C# is implemented by using the try, catch, and finally keywords:

try
{
    // try code block - code that may generate an exception
}
catch
{
    // catch code block - code to handle an exception
}
finally
{
    // finally code block - code to clean up resources
}

//The try-catch pattern consists of a try block followed by one or more catch clauses. Each catch block is used to specify handlers for different exceptions.
//The try-finally pattern consists of a try block followed by a finally block. Typically, the statements of a finally block run when control leaves a try statement.
//The try-catch-finally pattern implements all three types of exception handling blocks. A common scenario for the try-catch-finally pattern is when resources are obtained and used in a try block, exceptional circumstances are managed in a catch block, and the resources are released or otherwise managed in the finally block.

//How are exceptions represented in code? – Exceptions are represented in code as objects, which means they're an instance of a class.

//Expection handling process

try
{
    // Step 1: code execution begins
    try
    {
        // Step 2: an exception occurs here
    }
    finally
    {
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
    }

}
catch // Step 3: the system finds a catch clause that can handle the exception
{
    // Step 5: the system transfers control to the first line of the catch code block
}

//In this example, the following process occurs:

//1. Execution begins in the code block of the outer try statement.
//2. An exception is thrown in the code block of the inner try statement.
//3. The runtime finds the catch clause associated with the outer try statement.
//4. Before the runtime transfers control to the first line of the catch code block, it executes the finally clause associated with the inner try statement.
//5. The runtime then transfers control to the first line of the catch code block and executes the code that handles the exception.

//Recap:
//Common scenarios that may require exception handling include user input, data processing, file I/O operations, database operations, and network communication.
//Exception handling in C# is implemented using try, catch, and finally keywords. Each keyword has an associated code block that serves a specific purpose.
//Exceptions are represented as types and derived from the System.Exception class in .NET.Exceptions contain information that identifies the type of exception, and properties that provide additional details.
//When an exception occurs, the .NET runtime searches for the nearest catch clause that can handle it. The search starts with the method where the exception was thrown, and moves down the call stack if necessary.

//Examine compiler-generated exceptions
//Compiler-generated exceptions

//ArrayTypeMismatchException: Thrown when an array can't store a given element because the actual type of the element is incompatible with the actual type of the array.
string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;

Object obj = (Object)13;
objs[2] = obj; // ArrayTypeMismatchException occurs

//DivideByZeroException: Thrown when an attempt is made to divide an integral value by zero.
int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2); // DivideByZeroException occurs


//FormatException: Thrown when the format of an argument is invalid.
int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs

//IndexOutOfRangeException: Thrown when an attempt is made to index an array when the index is less than zero or outside the bounds of the array.
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs

//InvalidCastException: Thrown when an explicit conversion from a base type to an interface or to a derived type fails at runtime.
object obj = "This is a string";
int num = (int)obj;

//NullReferenceException: Thrown when an attempt is made to reference an object whose value is null.
int[] values = null;
for (int i = 0; i <= 9; i++)
    values[i] = i * 2;

string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());

//OverflowException: Thrown when an arithmetic operation in a checked context overflows.
decimal x = 400;
byte i;

i = (byte)x; // OverflowException occurs
Console.WriteLine(i);

//Recap:
//The .NET runtime throws an exception when an operation fails.
//The exception type is dependent on the code that causes the exception.
//Your application should catch runtime exceptions.

//Solution for the try-catch challenge
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch
    {
        Console.WriteLine("Exception caught in Process1");
    }

}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}

//Solution for the catch specific exeptions challange
checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}

try
{
    string? str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");

//Create and throw exceptions in C# console applications
//Examine how to create and throw exceptions in C#

//Create an exception object
//ArgumentException or ArgumentNullException: Use these exception types when a method or constructor is called with an invalid argument value or null reference.
//InvalidOperationException: Use this exception type when the operating conditions of a method don't support the successful completion of a particular method call.
//NotSupportedException: Use this exception type when an operation or feature is not supported.
//IOException: Use this exception type when an input/output operation fails.
//FormatException: Use this exception type when the format of a string or data is incorrect.

//The new keyword is used to create an instance of an exception.
//For example, you can create an instance of the ArgumentException exception type as follows:

ArgumentException invalidArgumentException = new ArgumentException();

//Some considerations to keep in mind when throwing an exception include:
//The Message property should explain the reason for the exception. However, information that's sensitive, or that represents a security concern shouldn't be put in the message text.
//The StackTrace property is often used to track the origin of the exception. This string property contains the name of the methods on the current call stack, together with the file name and line number in each method that's associated with the exception. A StackTrace object is created automatically by the common language runtime (CLR) from the point of the throw statement. Exceptions must be thrown from the point where the stack trace should begin.

//When to throw an exception
string[][] userEnteredValues = new string[][]
{
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
};

foreach (string[] userEntries in userEnteredValues)
{
    try
    {
        BusinessProcess1(userEntries);
    }
    catch (Exception ex)
    {
        if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
        {
            Console.WriteLine(ex.Message);
        }
    }
}

static void BusinessProcess1(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            // completes required calculations based on userValue
            // ...
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
    }
}

//Re-throwing exceptions


// Thing to avoid when throwing exceptions
//In addition to throwing a new exception, throw can be used re-throw an exception from inside a catch code block.

//Things to avoid when throwing exceptions

//Don't use exceptions to change the flow of a program as part of ordinary execution. Use exceptions to report and handle error conditions.
//Exceptions shouldn't be returned as a return value or parameter instead of being thrown.
//Don't throw System.Exception, System.SystemException, System.NullReferenceException, or System.IndexOutOfRangeException intentionally from your own source code.
//Don't create exceptions that can be thrown in debug mode but not release mode. To identify runtime errors during the development phase, use Debug.Assert instead.

//Recap:
//When creating and throwing an exception, the exception type must match the intended purpose of the exception as closely as possible.
//To throw an exception, you create an instance of an exception-derived class, configure its properties, and then use the throw keyword.
//When creating an exception object, it's important to provide clear error messages and additional information to help users correct the issue.

//Solution for the create and throw exceptions challange
string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");

}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
}
