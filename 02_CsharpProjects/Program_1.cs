using System;

// initialize variables - graded assignments 
// int currentAssignments = 5;


// Student names and scores
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[][] studentScores = new int[][]
{
    new int[] { 90, 86, 87, 98, 100, 94, 90 },  // Sophia
    new int[] { 92, 89, 81, 96, 90, 89},   // Andrew
    new int[] { 90, 85, 87, 98, 68, 89, 89, 89 },   // Emma
    new int[] { 90, 95, 87, 88, 96, 96 }    // Logan
};


Console.WriteLine("Student\t\tGrade\n");

for (int i = 0; i < studentNames.Length; i++)
{
    int scoreSum = 0;
    int currentAssignments = studentScores[i].Length;
    foreach (int score in studentScores[i])
    {
        scoreSum += score;
    }
    decimal final = (decimal) scoreSum / currentAssignments;
    string letterGrade = GetLetterGrade(final);
    Console.WriteLine($"{studentNames[i]}\t\t{final}\t\t{letterGrade}");
}



Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


// Grading system
static string GetLetterGrade(decimal score)
{
    if (score >=97)
    {
       return "A+";
    }
    else if(score >=93)
    {
        return "A";
    }
    else if(score >=90)
    {
        return "A-";
    }
    else if(score >=87)
    {
        return "B+";
    }
    else if(score >=83)
    {
        return "B";
    }
    else if(score >=80)
    {
        return "B-";
    }
    else if(score >=77)
    {
        return "C+";
    }
    else if(score >=73)
    {
        return "C";
    }
    else if(score >=70)
    {
        return "C-";
    }
    else if(score >=67)
    {
        return "D+";
    }
    else if(score >=63)
    {
        return "D";
    }
    else if(score >=60)
    {
        return "D-";
    }
    else
    {
        return "F";
    }
}
