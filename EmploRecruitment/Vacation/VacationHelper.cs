using EmploRecruitment.Employees;

namespace EmploRecruitment.Vacation;

public class VacationHelper : IVacationHelper {
    private int CountFreeDaysForEmployee(Employee employee, List<Vacation> vacations,
        VacationPackage vacationPackage )
    {
        if (employee == null) throw new ArgumentNullException(nameof(employee));
        if (vacations == null) throw new ArgumentNullException(nameof(vacations));
        if (vacationPackage == null) throw new ArgumentNullException(nameof(vacationPackage));

        var currentYear = DateTime.Now.Year;
        var today = DateTime.Today;
        
        var usedDays = vacations
            .Where(v => v.EmployeeId == employee.Id &&
                        v.DateSince.Year == currentYear &&
                        v.DateUntil.Year == currentYear &&
                        v.DateUntil < today)
            .Sum(v => (v.DateUntil.Date - v.DateSince.Date).Days + 1);
        
        int freeDays = Math.Max(vacationPackage.GrantedDays - usedDays, 0);

        return freeDays;
    }
    
    public bool IfEmployeeCanRequestVacation(Employee employee, List<Vacation> vacations,
        VacationPackage vacationPackage)
    {
        var helper = new VacationHelper();
        int freeDays = helper.CountFreeDaysForEmployee(employee, vacations, vacationPackage);
        
        return freeDays > 0;
    }
}