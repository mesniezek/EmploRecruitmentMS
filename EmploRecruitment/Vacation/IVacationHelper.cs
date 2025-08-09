using EmploRecruitment.Employees;

namespace EmploRecruitment.Vacation;

public interface IVacationHelper
{
    bool IfEmployeeCanRequestVacation(Employee employee, List<Vacation> vacations, VacationPackage vacationPackage);
}