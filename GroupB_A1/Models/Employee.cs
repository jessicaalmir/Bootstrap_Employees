namespace GroupB_A1.Models;
//Employee data
public class Employee
{
    public int ID { get; set; }
    public String MugshotPhoto { get; set; }
    public String Name { get; set; }
    public  String LastName { get; set; }
    public Department Department { get; set; }
    public Location OfficeLocation { get; set; }

    public Employee()
    {
        //Initialize a new department and a new office location for an employee
        Department = new Department();
        OfficeLocation = new Location();
    }
}