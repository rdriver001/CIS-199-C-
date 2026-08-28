// Program4
// CS-199-50
// By: Raeshawn Driver
// Due date: 11/19/2024
/*
 * This is a program that holds the setup for a student class with 6 properties and an 
 * override function for correct output of the class to the console.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    // Properties
    public string Name { get; set; }
    private double _gpa;
    public double GPA
    {
        get => _gpa;
        set => _gpa = (value >= 0.0 && value <= 4.0) ? value : 4.0;
    }
    private int _creditHours;
    public int CreditHours
    {
        get => _creditHours;
        set => _creditHours = (value >= 0 && value <= 18) ? value : 12;
    }
    public string Classification { get; set; }
    public string Major { get; set; }
    private bool EnrollmentStatus { get; set; }

    // Constructor
    public Student(string name, double gpa, int creditHours, string classification, string major, bool enrollmentStatus)
    {
        Name = name;
        GPA = gpa;
        CreditHours = creditHours;
        Classification = classification;
        Major = major;
        EnrollmentStatus = enrollmentStatus;
    }

    // Methods
    public void Enroll()
    {
        EnrollmentStatus = true;
    }

    public void Unenroll()
    {
        EnrollmentStatus = false;
    }

    public bool IsEnrolled()
    {
        return EnrollmentStatus;
    }

    public override string ToString()
    {
        return $"Name: {Name}{Environment.NewLine}" +
               $"GPA: {GPA:F1}{Environment.NewLine}" +
               $"Credit Hours: {CreditHours}{Environment.NewLine}" +
               $"Classification: {Classification}{Environment.NewLine}" +
               $"Major: {Major}{Environment.NewLine}" +
               $"Enrollment Status: {(EnrollmentStatus ? "Enrolled" : "Not Enrolled")}{Environment.NewLine}";
    }
}

