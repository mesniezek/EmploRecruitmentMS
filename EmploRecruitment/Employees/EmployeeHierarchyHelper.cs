namespace EmploRecruitment.Employees;

public class EmployeeHierarchyHelper : IEmployeeHierarchyHelper {
    private List<EmployeeStructure> _structure = new List<EmployeeStructure>();

    public List<EmployeeStructure> FillEmployeesStructure(List<Employee> employees)
    {
        _structure.Clear();
        
        var employeeLookup = employees.ToDictionary(e => e.Id, e => e);

        foreach (var emp in employees)
        {
            var row = 1;
            var currentSuperior = emp.SuperiorId;

            while (currentSuperior.HasValue)
            {
                _structure.Add(new EmployeeStructure(emp.Id, currentSuperior.Value, row));
                currentSuperior = employeeLookup[currentSuperior.Value].SuperiorId;
                row++;
            }
        }

        return _structure;
    }

    public int? GetSuperiorRowOfEmployee(int employeeId, int superiorId)
    {
        var relation = _structure.FirstOrDefault(s =>
            s.EmployeeId == employeeId && s.SuperiorId == superiorId);

        return relation?.Row;
    }
}
