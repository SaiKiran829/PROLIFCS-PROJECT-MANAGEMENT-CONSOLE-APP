using System;

namespace PPM.Main.PPM.Model
{
    
//project class
public class Project 
{
    public List<Employee> AddingEmplist = new List<Employee>();
    public string ProjectName { get; set; }
    public string Startdate { get; set; }
    public string Enddate { get; set; }
    public int? id { get; set; }
 
    public int EmpIDD;

    public Project(string projectname, string startdate, string enddate, int Id)
    {
        this.ProjectName = projectname;
        this.Startdate = startdate;
        this.Enddate = enddate;
        this.id = Id;
    }

    
    public Project(int empidd)
    {
        this.EmpIDD =empidd;
    }
public Project(){
    
}

}

//Employee class
public class Employee : IComparable<Employee>
{
    public int EmployeeID { get; set; }

    public string EmpFirstName{get;set;}
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string mobile { get; set; }
    public string address { get; set; }
    public int roleid { get; set; }
    public string roleName { get; set; }


    public Employee(int empid, string FirstName, string LastName, string Email, string Mobile, string Address, int ROleID, string ROlename)
    {
        this.EmployeeID = empid;
        this.EmpFirstName = FirstName;
        this.lastName = LastName;
        this.email = Email;
        this.mobile = Mobile;
        this.address = Address;
        this.roleid = ROleID;
        this.roleName = ROlename;
    }

    public Employee()
    {

    }

     public int CompareTo(Employee other){
        return this.roleid.CompareTo(other.roleid);
    }

}

//Role class
public class Role : IComparable<Role>
{
    public string RoleName { get; set; }
    public int RoleId { get; set; }

    public Role(int roleid, string roleName)
    {
        RoleName = roleName;
        RoleId = roleid;
    }
    
    public Role()
    {

    }

    public int CompareTo(Role other){
        return this.RoleId.CompareTo(other.RoleId);
    }

}


}
