namespace EmploRecruitment.Employees;

public class EmployeeStructure {
    public int EmployeeId { get; private set;}
    public int SuperiorId { get; private set;}
    public int Row { get; private set;}
    
    public EmployeeStructure(int employeeId, int superiorId, int row)
    {
        EmployeeId = employeeId;
        SuperiorId = superiorId;
        Row = row;
    }
}
