using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class FunctionalProgramming
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student("Dimtar", "Dimitrov",21,700000001,"+359 888888888","Dimitar@abv.bg",new List<int> {2, 3, 4, 8},1),
            new Student("Pesho", "Peshev",18,700000002,"+359 2 88888887","PeshKo0@abv.bg",new List<int> {6, 6, 6, 6},2),
            new Student("Gosho", "Goshev",17,700000003,"+359 888888886","Goshuuu@abv.bg",new List<int> {5, 5, 5, 5},1),
            new Student("Ivan", "Ivanov",20,900000014,"02 88888885","Vanko_1@gmail.com",new List<int> {2, 2, 2, 2},2),
            new Student("Slavi", "Trifonov",48,700000005,"+359 888888884","Slavcho.baby@gmail.com",new List<int> {6, 6, 6, 6},1),
            new Student("Grigor", "Dimitrov",24,700000006,"+359 2 88888883","Sharapova@abv.bg",new List<int> {2,2},3),
            new Student("Kobrat", "Pulev",34,700000007,"+359 888888882","Prodaljavame.napred@hotmail.com",new List<int> {6, 2, 6, 6},2),
            new Student("Djordjano", "Stoqnov",29,700000008,"+359 888888881","kOpon@hotmail.com",new List<int> {6, 6, 6, 6},3),
        };
        StudentsByGroup(students);
        StudentsByFirstAndLastName(students);
        StudentsByAge(students);
        SortStudents(students);
        SortStudents1(students);
        FilterStudentsByEmailDomain(students);
        FilterStudentsByPhone(students);
        ExcellentStudents(students);
        WeakStudents(students);
        StudentsEnrolledIn2014(students);
    }
    private static void StudentsByGroup(List<Student> students)
    {
        Console.WriteLine("Problem 2. Students by Group :");
        var group2 = from student in students
                     where student.GroupNumber == 2
                     orderby student.FirstName
                     select student;
        foreach (var item in group2)
        {
            Console.WriteLine("{0} {1}: {2}", item.FirstName, item.LastName, item.GroupNumber);
        }
        Console.WriteLine();
    }
    private static void StudentsByFirstAndLastName(List<Student> students)
    {
        Console.WriteLine("Problem 3. Students by First and Last Name:");
        var studentsName = from student in students
                           where student.FirstName.CompareTo(student.LastName) < 0
                           select student;
        foreach (var item in studentsName)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
        }
        Console.WriteLine();
    }
    private static void StudentsByAge(List<Student> students)
    {
        Console.WriteLine("Problem 4. Students by Age:");
        var studentsByAge = from student in students
                            where student.Age >= 18 && student.Age <= 24
                            select new { student.FirstName, student.LastName, student.Age };
        foreach (var item in studentsByAge)
        {
            Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.Age);
        }
        Console.WriteLine();
    }
    private static void SortStudents(List<Student> students)
    {
        Console.WriteLine("Problem 5. Sort Students:");
        var studentsSort = from student in students
                           orderby student.FirstName descending, student.LastName descending
                           select student;
        foreach (var item in studentsSort)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
        }
        Console.WriteLine();
    }
    private static void SortStudents1(List<Student> students)
    {
        Console.WriteLine("Problem 5. Sort Students:");
        var studentsSort =
            students.OrderByDescending(item => item.FirstName)
                .ThenByDescending(item => item.LastName);
        foreach (var item in studentsSort)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
        }
        Console.WriteLine();
    }
    private static void FilterStudentsByEmailDomain(List<Student> students)
    {
        Console.WriteLine("Problem 6. Filter Students by Email Domain:");
        var StudentsByEmail = from student in students
                              where student.Email.Contains("@abv.bg")
                              select student;
        foreach (var item in StudentsByEmail)
        {
            Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.Email);
        }
        Console.WriteLine();
    }
    private static void FilterStudentsByPhone(List<Student> students)
    {
        Console.WriteLine("Problem 7. Filter Students by Phone:");
        var StudentsByPhone = from student in students
                              where student.Phone.Contains("02 ") || student.Phone.Contains("+3592") || student.Phone.Contains("+359 2 ")
                              select student;
        foreach (var item in StudentsByPhone)
        {
            Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.Phone);
        }
        Console.WriteLine();
    }
    private static void ExcellentStudents(List<Student> students)
    {
        Console.WriteLine("Problem 8. Excellent Students:");
        var studentsExcellent = from student in students
                                where student.Marks.Contains(6)
                                select new { FullName = student.FirstName + " " + student.LastName, student.Marks };
        foreach (var item in studentsExcellent)
        {
            Console.WriteLine(item.FullName + ": " + string.Join(", ", item.Marks));
        }
        Console.WriteLine();
    }
    private static void WeakStudents(List<Student> students)
    {
        Console.WriteLine("Problem 9. Weak Students:");
        var studentsWeak = students
            .Where(student => student.Marks.Count(mark => mark == 2) == 2)
            .Select(student => new { FullName = student.FirstName + " " + student.LastName, student.Marks });
        foreach (var item in studentsWeak)
        {
            Console.WriteLine(item.FullName + ": " + string.Join(", ", item.Marks));
        }
        Console.WriteLine();
    }
    private static void StudentsEnrolledIn2014(List<Student> students)
    {
        Console.WriteLine("Problem 10. Students Enrolled in 2014:");
        var students2014 = from student in students
                           where student.FacultyNumber % 100 == 14
                           select student;
        foreach (var item in students2014)
        {
            Console.WriteLine("{0} {1} FN: {2} Marks: {3}", item.FirstName, item.LastName, item.FacultyNumber, string.Join(", ", item.Marks));
        }
        Console.WriteLine();
    }

}
