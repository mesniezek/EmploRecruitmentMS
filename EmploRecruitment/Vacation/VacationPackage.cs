namespace EmploRecruitment.Vacation;

public class VacationPackage {
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int GrantedDays { get; private set; }
    public int Year { get; private set; }
    
    public VacationPackage(int id, string name, int grantedDays, int year)
    {
        Id = id;
        Name = name;
        GrantedDays = grantedDays;
        Year = year;
    }
}