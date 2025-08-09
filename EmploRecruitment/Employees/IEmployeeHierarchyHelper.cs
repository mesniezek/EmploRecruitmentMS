namespace EmploRecruitment.Employees;

public interface IEmployeeHierarchyHelper
{
    List<EmployeeStructure> FillEmployeesStructure(List<Employee> employees);
    int? GetSuperiorRowOfEmployee(int employeeId, int superiorId);
}