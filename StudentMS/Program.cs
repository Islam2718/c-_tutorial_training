using System;

public class Student 
{
    private string? _name;
    private DateTime _dateOfBirth;
    private string? _rollNumber;

    public string Name { 
        get{return _name;} 
        set{_name = value;} 
    }

    public DateTime DateOfBirth { 
        get{return _dateOfBirth;} 
        set{
            if (value > DateTime.Now) {
                // Console.WriteLine("Date of birth cannot be in the future.");
                throw new Exception("Date of birth cannot be in the future.");
            } else {
                _dateOfBirth = value;
            }
        } 
    }

    public string RollNumber {
        get{return _rollNumber;}
        set{_rollNumber = value;}
    }

    public Student(string name, DateTime dateOfBirth, string rollNumber) {
        Name = name;
        DateOfBirth = dateOfBirth;
        RollNumber = rollNumber;
    }

    private int CalculateAge() {
        if(DateOfBirth == null) { return 0; }
        int age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }
    public int age { get { return CalculateAge(); } }
}

public class MyClass
{
    public static void Main(string[] args)
    {
        try {
            Student student1 = new Student("Islam Hossain", new DateTime(1991, 08, 10), "CSE-59");

            Console.WriteLine("---------------");
            Console.WriteLine("Name: " + student1.Name);
            Console.WriteLine("Date of Birth: " + student1.DateOfBirth);
            Console.WriteLine("Roll Number: " + student1.RollNumber);
            Console.WriteLine("Age: " + student1.age.ToString());

            // Student student2 = new Student("Irtaza", new DateTime(2018, 1, 1), "CSE-59");
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}