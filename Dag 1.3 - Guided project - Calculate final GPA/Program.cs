//Guided project– Calculate final GPA
//Project Overview

//You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:

//You're given the student's name and class information.
//Each class has a name, the student's grade, and the number of credit hours for that class.
//Your application needs to perform basic math operations to calculate the GPA for the given student.
//Your application needs to output/display the student’s name, class information, and GPA.
//To calculate the GPA:

//Multiply the grade value for a course by the number of credit hours for that course.
//Do this for each course, then add these results together.
//Divide the resulting sum by the total number of credit hours.

//Create variables to store the grade values for each course  
string studentName = "Alice de Dog"; //Person of revalvase 

string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

//Grade achieved in each course.
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

//Declaration of numeric grade value 
int gradeA = 4;
int gradeB = 3;

//Declaring the course to a value with the use of the created valiables
int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

//Calutalting the final GPA:
decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;

//Writing out all of the scored data:
Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");