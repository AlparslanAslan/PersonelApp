namespace PersonelApp.Data;

public class Personnel
{
    public int Id {get;set;}
    public string  FirstName { get; set; }
    public string  LastName { get; set; }
    public string  Department { get; set; }
    public string  Title { get; set; }
    public string Email  { get; set; }
    public string Phone  { get; set; }
    public string  Adress { get; set; }

    public DateTime DateOfBirth { get; set; }
}
