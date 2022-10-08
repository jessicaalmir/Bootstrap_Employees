namespace GroupB_A1.Models;

//Company's Department

public class Department
{
    public int ID { get; set; }
    public String Name { get; set; }

    public Department()
    {
        
    }

    public Department(int id, String name)
    {
        ID = id;
        Name = name;
    }
}