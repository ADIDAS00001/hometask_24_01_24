


var student = new Student();
student.FullName="Abdullo";
student.Grade=10;
System.Console.WriteLine($"{student.FullName} is studying.");

public class Student
{
    private string _fullname;
    private int _age;
    private int _grade; 
    public string FullName
    {
        get
        {
            return _fullname;
        }
        set
        {
            _fullname = value;
        }
    }
     public int Grade
    {
       
        get
        {
            return _grade;
        }
        set
        {
            _grade = value;
        }
    }

}