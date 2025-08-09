using EmploRecruitment.Employees;

// Exercise 1
var jan = new Employee(id: 1, name: "Jan Kowalski");
var kamil = new Employee(id: 2, name: "Kamil Nowak", superiorId: 1, superior: jan);
var andrzej = new Employee(id: 3, name: "Andrzej Wiśniewski", superiorId: 2, superior: kamil);
var anna = new Employee(id: 4, name: "Anna Malinowska");

var employees = new List<Employee> { jan, kamil, andrzej, anna };

var helper = new EmployeeHierarchyHelper();
helper.FillEmployeesStructure(employees);

Console.WriteLine(helper.GetSuperiorRowOfEmployee(kamil.Id, jan.Id));
Console.WriteLine(helper.GetSuperiorRowOfEmployee(anna.Id, andrzej.Id));
Console.WriteLine(helper.GetSuperiorRowOfEmployee(andrzej.Id, jan.Id));