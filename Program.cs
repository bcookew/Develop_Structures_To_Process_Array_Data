﻿using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

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

int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");
foreach (string name in studentNames)
{
    string currentStudent = name;
    string currentStudentLetterGrade = string.Empty;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
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

    int sumAssignmentScores = 0;
    int gradedAssignments = 0;
    
    foreach (int score in studentScores)
    {
        gradedAssignments++;
        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
            sumAssignmentScores += score / 10;
    }
    
    gradedAssignments = 0;

    decimal currentStudentGrade = 0;

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
    currentStudentLetterGrade = DetermineLetterGradeFromScore(currentStudentGrade);

    Console.WriteLine($"{name}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


string DetermineLetterGradeFromScore(decimal score)
{
    if (score >= 97)
        return "A+";

    else if (score >= 93)
        return "A";

    else if (score >= 90)
        return "A-";

    else if (score >= 87)
        return "B+";

    else if (score >= 83)
        return "B";

    else if (score >= 80)
        return "B-";

    else if (score >= 77)
        return "C+";

    else if (score >= 73)
        return "C";

    else if (score >= 70)
        return "C-";

    else if (score >= 67)
        return "D+";

    else if (score >= 63)
        return "D";

    else if (score >= 60)
        return "D-";

    else
        return "F";
}