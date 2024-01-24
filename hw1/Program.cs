

var teacher = new Teacher();
teacher.FullName = "Shahrom";
teacher.Subject = "mathematics";
teacher.Experience = 15;
System.Console.WriteLine($"{teacher.FullName} is teaching {teacher.Subject}");
public class Teacher
{
    private string _fullName;
    private string _subject;
    private int _experience;
    public string FullName
    {
       
        get
        {
            return _fullName;
        }
        set
        {
            _fullName = value;
        }
    }
    public string Subject
    {
       
        get
        {
            return _subject;
        }
        set
        {
            _subject = value;
        }
    }
    public int Experience
    {
       
        get
        {
            return _experience;
        }
        set
        {
            _experience = value;
        }
    }
}