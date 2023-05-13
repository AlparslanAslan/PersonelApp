using PersonelApp.Data;
namespace PersonelApp.Service;

public class PersonnelService
{
    private static readonly Personnel[] Personnels = new []
    {
        new Personnel() { Id=1,FirstName="Ahmet",LastName="Durmaz",Department="Human Resource",Title ="HR Director",Email="ahmetd@email.com" , Phone="+905553491703",Adress="Taksim /Istanbul",DateOfBirth=new DateTime(1989,8,12)},
        new Personnel() { Id=2,FirstName="Fatma",LastName="Yılmaz",Department="IT",Title ="IT Engineer",Email="fatmay@email.com" , Phone="+905672368719",Adress="Adana",DateOfBirth=new DateTime(1993,08,12)},
        new Personnel() { Id=3,FirstName="Derya",LastName="Kaplan",Department="Human Resource",Title ="HR Specialist",Email="deryak@email.com" , Phone="+905670278102",Adress="Ankara",DateOfBirth=new DateTime(1998,5,3)},
        new Personnel() { Id=4,FirstName="Yusuf",LastName="Acar",Department="Finance",Title ="Fİnancial Analyst",Email="yusufa@email.com" , Phone="+905902615729",Adress="İzmir",DateOfBirth=new DateTime(1994,11,3)},
        new Personnel() { Id=5,FirstName="Mahmut",LastName="Atik",Department="Marketing",Title ="Marketing Generalist",Email="mahmuta@email.com" , Phone="+905239770102",Adress="İstanbul",DateOfBirth=new DateTime(1990,12,7)},
        new Personnel() { Id=6,FirstName="Deniz",LastName="Kılıç",Department="Management",Title ="CEO",Email="denizk@email.com" , Phone="+905789215461",Adress="Mersin",DateOfBirth=new DateTime(1969,01,14)},
        new Personnel() { Id=7,FirstName="Bekir",LastName="Yenilmez",Department="Human Resource",Title ="Recruiter",Email="bekiry@email.com" , Phone="+905559890120",Adress="Kocaeli",DateOfBirth=new DateTime(1998,7,2)}

        
    };

    public  Task<Personnel[]> GetPersonnelsAsync()
    {
         return Task.FromResult(Enumerable.Range(0, 6).Select(index => new Personnel
        {
            Id = Personnels[index].Id,
            FirstName = Personnels[index].FirstName,
            LastName = Personnels[index].LastName,
            Department=Personnels[index].Department,
            Title=Personnels[index].Title,
            Email =Personnels[index].Email,
            Phone=Personnels[index].Phone,
            Adress=Personnels[index].Adress,
            DateOfBirth=Personnels[index].DateOfBirth
        }).ToArray());
    }
}   
