﻿using System;
using System.Security.Cryptography.X509Certificates;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

//Create a container for student exam scores
int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;



    decimal[] currentStudentSummationDetails = GetSumFromIntArray(studentScores);
    decimal currentStudentExamGrade = 0;
    decimal currentStudentOverallGrade = 0;
    decimal extraCreditAverage = 0;
    currentStudentExamGrade = currentStudentSummationDetails[0] / (decimal)examAssignments;
    currentStudentOverallGrade = currentStudentSummationDetails[1] / (decimal)examAssignments;
    extraCreditAverage = currentStudentSummationDetails[2]; 

    if (currentStudentOverallGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentOverallGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentOverallGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentOverallGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentOverallGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentOverallGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentOverallGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentOverallGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentOverallGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentOverallGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentOverallGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentOverallGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamGrade}\t\t{currentStudentOverallGrade}\t{currentStudentLetterGrade}\t{extraCreditAverage} ({currentStudentOverallGrade-currentStudentExamGrade} pts)");
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();


decimal[] GetSumFromIntArray(int[] intArray)
{
    int gradedAssignments = 1;
    int extraCreditAssignments = 0;
    int examScoreTotal = 0;
    decimal extraCreditScoreTotal = 0;
    decimal extraCreditAverage = 0;
    decimal overAllTotal = 0;
    decimal[] sumArray = new decimal[3];

    foreach (int score in intArray)
    {
        if (gradedAssignments <= examAssignments)
        {
            examScoreTotal += score;
            gradedAssignments += 1;
        }
        else
        {
            extraCreditScoreTotal += (decimal)score;
            extraCreditAssignments += 1;
        }

    }

    // Console.WriteLine($"Final Extra Credit Score Total: {extraCreditScoreTotal / 10}");
    extraCreditAverage = extraCreditScoreTotal / extraCreditAssignments;
    overAllTotal = (decimal)examScoreTotal + extraCreditScoreTotal / 10;
    // Console.WriteLine($"Final Overall Score Total: {overAllTotal}");
    sumArray[0] = (decimal)examScoreTotal;
    sumArray[1] = overAllTotal;
    sumArray[2] = extraCreditAverage;


    return sumArray;
}
