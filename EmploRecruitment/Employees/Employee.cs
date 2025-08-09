using EmploRecruitment.Vacation;

namespace EmploRecruitment.Employees;

public class Employee {
    public int Id { get; private set;}
    public string Name { get; private set;}
    public int? SuperiorId { get; private set;}
    public Employee? Superior { get; private set;}
    public int? TeamId { get; private set; }
    public Team? Team { get; private set; }
    public int? VacationPackageId { get; private set; }
    public VacationPackage? VacationPackage { get; private set; }
    
    public Employee(int id, string name, int? superiorId = null, Employee? superior = null, 
        int? teamId = null, Team? team = null, int? vacationPackageId = null, VacationPackage? vacationPackage = null)
    {
        Id = id;
        Name = name;
        SuperiorId = superiorId;
        Superior = superior;
        TeamId = teamId;
        Team = team;
        VacationPackageId = vacationPackageId;
        VacationPackage = vacationPackage;
    }
}