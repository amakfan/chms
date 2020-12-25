using System.Collections.Generic;
public class Respondent
{
    private string RespondentId;
    private string Name;
    public List<Medication> Medications {get; set; }

    public Respondent()
    {
        RespondentId = "12345";
        Name = "John Doe";
        Medications = new List<Medication>();
        Medications.Add(new Medication() { Id = "1111", Name = "Tylenol"});
        Medications.Add(new Medication() { Id = "2222", Name = "Advil"});
    }
    
}