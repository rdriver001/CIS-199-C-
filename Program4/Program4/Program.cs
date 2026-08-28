// Program4
// CS-199-50
// By: Raeshawn Driver
// Due date: 11/19/2024
/*
 * This is a program that creates 5 student classes, modifies them, and outputs them
 * both times.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an array of Student objects
        Student[] students = new Student[5]
        {
            new Student("Alice Johnson", 3.5, 15, "Sophomore", "Computer Science", true),
            new Student("Bob Smith", 2.8, 12, "Junior", "Mathematics", false),
            new Student("Charlie Brown", 4.0, 18, "Senior", "Engineering", true),
            new Student("Diana Prince", 3.2, 9, "Freshman", "Physics", true),
            new Student("Evan Davis", 3.7, 14, "Junior", "Biology", true)
        };

        Console.WriteLine("Original Student Data:");
        PrintStudentData(students);

        // Modify properties and use Enroll/Unenroll methods
        students[1].Enroll();
        students[3].Unenroll();
        students[0].Major = "Software Engineering";
        students[2].GPA = 3.9;

        Console.WriteLine("\nUpdated Student Data:");
        PrintStudentData(students);
    }

    // Method to print student data
    static void PrintStudentData(Student[] students)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }
}