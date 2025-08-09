using EmploRecruitment.Employees;

namespace EmploRecruitment.Vacation;

public class Vacation {
    public int Id { get; private set; }
    public DateTime DateSince { get; private set; }
    public DateTime DateUntil { get; private set; }
    public int NumberOfHours { get; private set; }
    public bool IsPartial { get; private set; }
    public int EmployeeId { get; private set; }
    public Employee? Employee { get; private set; }
    
    public Vacation(int id, DateTime dateSince, DateTime dateUntil, int numberOfHours, bool isPartial, int employeeId)
    {
        Id = id;
        DateSince = dateSince;
        DateUntil = dateUntil;
        NumberOfHours = numberOfHours;
        IsPartial = isPartial;
        EmployeeId = employeeId;
    }
}