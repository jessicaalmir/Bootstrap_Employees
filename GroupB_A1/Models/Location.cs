namespace GroupB_A1.Models;
//Company's Location

public class Location
{
    public int ID { get; set; }
    public String Name { get; set; }
    public String Address { get; set; }
    public String City { get; set; }
    public String ZipCode { get; set; }

    public Location()
    {
        
    }

    public Location(int id, String name, String address, String city, String zipCode)
    {
        ID = id;
        Name = name;
        Address = address;
        City = city;
        ZipCode = zipCode;
    }
    
}