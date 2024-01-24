



Doctor doctror=new Doctor("Dr. Johnson","Cordiology", 15 );
System.Console.WriteLine(doctror.TreatPatient("Shohrux"));
System.Console.WriteLine(doctror.PerformMedicalExamination("Shohrux"));
System.Console.WriteLine(doctror.PrescribeMedication("Shohrux" ,"Antibiotics"));
System.Console.WriteLine("**************************************************");
public class Doctor 
{
    private string _fullname;
    private string _specialty;
    private int _experience;

    public Doctor ()
    {
        
    }
    public Doctor(string fullName, string speciality)
    {
        _fullname=fullName;
        _specialty=speciality;
    }
    public Doctor(string fullname, string speciality, int experience)
    {
        _fullname=fullname;
        _specialty=speciality;
        _experience=experience;
    }

    public string TreatPatient(string patientName)
    {
        return $"{_fullname} {_specialty}, лечит пациента по имени {patientName}";
    }
    public string PerformMedicalExamination(string patientName)
    {
        return $"{_fullname} is performing a medical examination on  {patientName} ";
    }
    public string PrescribeMedication(string patientName, string medication)
    {
        return $"{_fullname} prescribes {medication} for {patientName}";
    }
    public void SetExperience(int years)
    {
        _experience=years;
    }
    public int GetExperience() 
    {
        return _experience;
    }

}