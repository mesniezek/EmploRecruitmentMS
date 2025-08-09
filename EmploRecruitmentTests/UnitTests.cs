using EmploRecruitment.Employees;
using EmploRecruitment.Vacation;
using FluentAssertions;

namespace EmploRecruitmentTests;

[TestFixture]
public class UnitTests
{
    private IVacationHelper _vacationHelper = new VacationHelper();

    [Test]
    public void EmployeeWithAvailableVacationDays_ShouldBeAbleToRequestVacation()
    {
        var employee = new Employee(1, "Jan Kowalski");
        var vacationPackage = new VacationPackage (1, "Holidays Test", 20, DateTime.Now.Year);
        var vacation = new Vacation(1, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-5), 5, false, 1);

        bool canRequest = _vacationHelper.IfEmployeeCanRequestVacation(employee, new List<Vacation> { vacation }, vacationPackage);

        canRequest.Should().BeTrue();
    }

    [Test]
    public void EmployeeWithoutAvailableVacationDays_ShouldNotBeAbleToRequestVacation()
    {
        var employee = new Employee(2, "Anna Mateczna");
        var vacationPackage = new VacationPackage(2, "Holidays Test", 0, DateTime.Now.Year);
        var vacation = new Vacation(2, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-5), 5, false, 2);

        bool canRequest = _vacationHelper.IfEmployeeCanRequestVacation(employee, new List<Vacation> { vacation }, vacationPackage);

        canRequest.Should().BeFalse();
        
    }
}