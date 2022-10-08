using GroupB_A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroupB_A1.Controllers;

public class EmployeeController : Controller
{
    // GET Employee
    //Returns a list of employees with their departments and office location
    public ActionResult List()
    {
        //Create Departments
        //Accounting
        Department department1 = new Department();
        department1.ID = 1;
        department1.Name = "Accounting";
        //HR
        Department department2 = new Department();
        department2.ID = 2;
        department2.Name = "HR";
        //IT Services
        Department department3 = new Department();
        department3.ID = 3;
        department3.Name = "IT Services";
        //Infrastructure
        Department department4 = new Department();
        department4.ID = 4;
        department4.Name = "Infrastructure";
        //Software Development
        Department department5 = new Department();
        department5.ID = 5;
        department5.Name = "Software Development";

        //Create Office Locations
        //Location1
        Location location1 = new Location();
        location1.ID = 1;
        location1.Name = "Head Office";
        location1.Address = "288 Bremner Blvd";
        location1.City = "Toronto, ON";
        location1.ZipCode = "M5V 3L9";
        //Location2
        Location location2 = new Location();
        location2.ID = 2;
        location2.Name = "South Sales Office";
        location2.Address = "4960 Clifton Hill";
        location2.City = "Niagara Falls, ON";
        location2.ZipCode = "L2G 3N4";
        //Location1
        Location location3 = new Location();
        location3.ID = 3;
        location3.Name = "West CAN Sales Office";
        location3.Address = "8863 Cavendish Road";
        location3.City = "Cavendish, PEI Canada";
        location3.ZipCode = "C0A 1N0";
        

        //Create a List of Employees
        List<Employee> employees = new List<Employee>();
        
        //New Employee 1
        Employee employee1 = new Employee();
        employee1.ID = 100100;
        employee1.Name = "John";
        employee1.LastName = "Sterling";
        employee1.MugshotPhoto = "https://randomuser.me/api/portraits/men/94.jpg";
        employee1.Department = department3;
        employee1.OfficeLocation = location2;
        
        //New Employee 2
        Employee employee2 = new Employee();
        employee2.ID = 200100;
        employee2.Name = "Laura";
        employee2.LastName = "Simons";
        employee2.MugshotPhoto = "https://randomuser.me/api/portraits/women/88.jpg";
        employee2.Department = department5;
        employee2.OfficeLocation = location1;
        
        //New Employee 3
        Employee employee3 = new Employee();
        employee3.ID = 200300;
        employee3.Name = "Michell";
        employee3.LastName = "McLain";
        employee3.MugshotPhoto = "https://randomuser.me/api/portraits/women/91.jpg";
        employee3.Department = department2;
        employee3.OfficeLocation = location1;
        
        //New Employee 4
        Employee employee4 = new Employee();
        employee4.ID = 300500;
        employee4.Name = "Anna";
        employee4.LastName = "Smith";
        employee4.MugshotPhoto = "https://randomuser.me/api/portraits/women/42.jpg";
        employee4.Department = department4;
        employee4.OfficeLocation = location3;

        //New Employee 5
        Employee employee5 = new Employee();
        employee5.ID = 500300;
        employee5.Name = "Jasper";
        employee5.LastName = "Disney";
        employee5.MugshotPhoto = "https://randomuser.me/api/portraits/men/55.jpg";
        employee5.Department = department1;
        employee5.OfficeLocation = location3;
        
        //New Employee 6
        Employee employee6 = new Employee();
        employee6.ID = 500300;
        employee6.Name = "Brad";
        employee6.LastName = "Stuart";
        employee6.MugshotPhoto = "https://randomuser.me/api/portraits/men/82.jpg";
        employee6.Department = department2;
        employee6.OfficeLocation = location2;
        
        //Add employees to the list
        employees.Add(employee1);
        employees.Add(employee2);
        employees.Add(employee3);
        employees.Add(employee4);
        employees.Add(employee5);
        
        return View(employees);
    }
}