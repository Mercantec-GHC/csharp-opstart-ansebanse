// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Hello, World!");

//Guided project – Develop foreach and if-elseif structures to process array data in C#
//Project overview

//You're developing a Student Grading application that automates the calculation of grades for each student in a class. The parameters for your application are:

//Create a C# console application. 
//Start with four students. Each student has five exam scores.

//Each exam score is an integer value, 0-100, where 100 represents 100% correct.

//A student's overall exam score is the average of their five exam scores.

//Criteria for extra credit assignments:

//Include extra credit assignment scores in the student's scores array.
//Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
//Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.
//Your application needs to automatically assign letter grades based on the calculated final score for each student.

//Your application needs to output/display each student’s name and formatted grade.

//Your application needs to support adding other students and scores with minimal impact to the code.

//You've already completed an initial version of the application. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:

//The code declares variables used to define student names and individual exam scores for each student.
//The code includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
//The code includes a hard coded letter grade that the developer must apply manually.
//The code includes Console.WriteLine() statements to display the student grading report.
//Your goal is to update the existing code to include the following features:

//Use arrays to store student names and assignment scores.

//Use a foreach statement to iterate through the student names as an outer program loop.

//Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.

//Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.

//Use an updated algorithm within the outer loop to calculate the average exam score for each student.

//Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.

//Integrate extra credit scores when calculating the student's final score and letter grade as follows:

//Your code must detect extra credit assignments based on the number of elements in the student's scores array.
//Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

//Create and run simple C# console applications
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);


//Implement a method of the Math class that returns the larger of two numbers
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);


//What is a Boolean expression 
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

//Opgave:
Random dice1 = new Random();

int roll1 = dice1.Next(1, 7);
int roll2 = dice1.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

//Solution to the apply business rules challenge

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

//Store and iterate through sequences of data using Arrays and the foreach statement in C#
//What is an array? – a sequence of individual data elements accessible through a single variable name.
// Declare a new array

string[] fraudulentOrderIDs = new string[3];

//Solution for the nested iteration and selction statement challenge 
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

//Create readable code with conventions, whitespace, and comments in C#

Random random1 = new Random();
string[] orderIDs1 = new string[5];

for (int i = 0; i < orderIDs1.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs1[i] = prefix + suffix;
}

foreach (var orderID in orderIDs1)
{
    Console.WriteLine(orderID);
}