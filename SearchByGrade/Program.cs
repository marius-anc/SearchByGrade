﻿using System;

namespace SearchByGrade
{
    public struct Student
    {
        public string Name;
        public double Grade;

        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }
    }

    public class Program
    {
        public static int SearchStudent(Student[] students, double studentGrade)
        {
            if (students == null)
            {
                throw new ArgumentNullException(nameof(students));
            }

            for (int i = 0; i < students.Length; i++)
            {
                if (Equals(students[i].Grade, studentGrade))
                {
                    return i;
                }
            }

            return -1;
        }

        static Student[] ReadStudents()
        {
            int studentsNumber = Convert.ToInt32(Console.ReadLine());
            Student[] result = new Student[studentsNumber];

            for (int i = 0; i < studentsNumber; i++)
            {
                string[] studentData = Console.ReadLine().Split(':');
                result[i] = new Student(studentData[0], Convert.ToDouble(studentData[1]));
            }

            return result;
        }

        static void Main()
        {
            Student[] students = ReadStudents();
            double studentGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(SearchStudent(students, studentGrade));
            Console.Read();
        }
    }
}
