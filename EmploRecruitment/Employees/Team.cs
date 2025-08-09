namespace EmploRecruitment.Employees;

public class Team {
    public int Id { get; private set;}
    public string Name { get; private set;}

    public Team(int id, string name)
    {
        Id = id;
        Name = name;
    }
}