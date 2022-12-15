using System;
using PPM.Main.PPM.Model;
namespace PPM.Main.PPM.Domain
{
   //Class which consists of methods for adding and viewing projects
public class ProjectManagement
{
    public List<Project> projects = new List<Project>();
    
    EmpManagement obj1 = new EmpManagement();

    //Method for adding projects
    public void AddingProjects(Project project)
    {
        projects.Add(project);
    }
    public void displayProject(Project project)
    {
        Console.WriteLine(" Name of the project - " + project.ProjectName + "\n Project Id - " + project.id + "\n Start date of project - " + project.Startdate + "\n End date of project - " + project.Enddate);
        Console.WriteLine("");
    }

    public void displayAllProjects()
    {
        if(projects.Count == 0){
            Console.WriteLine("The List is Empty !!!");
        }
        else{
        foreach (var e in projects)
        {
            displayProject(e);
        }}
    }

    public void display()
    {

          
        
            for (int j = 0; j < projects.Count; j++)
            {
                projects[j].AddingEmplist.Sort();
                if(projects[j].AddingEmplist.Count == 0){
                    Console.WriteLine("No employee in the project");
                }
                else{
                    
                    Console.WriteLine("=====================================================================================");
                    Console.WriteLine("\nProject Name - "+projects[j].ProjectName+"\n");
                    Console.WriteLine("Below are the details of employees in this project");
                for (int i = 0; i < projects[j].AddingEmplist.Count; i++)
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine(projects[j].AddingEmplist[i].EmpFirstName+" ["+projects[j].AddingEmplist[i].roleName+"]");
                }
            }}
    }

    public void emptopro(int pid,Employee ename){
        if(!obj1.exist(pid)){
        for(int i=0; i<projects.Count;i++){
            if(projects[i].id==pid){
                projects[i].AddingEmplist.Add(ename);
            }
        }}
        else
        {
           Console.WriteLine("The employee with this id already exists in this project");
           Console.WriteLine("Enter any key to get to main menu");
           Console.ReadLine();
        }
    }

     public void empfrompro(int pid,Employee ename){
        for(int i=0; i<projects.Count;i++){
            if(projects[i].id==pid){
                projects[i].AddingEmplist.Remove(ename);
            }
        }
    }


    public Boolean exist(int pid){
        for(int i=0; i<projects.Count;i++){
            if(pid== projects[i].id){
                return true;
            }
        }
        return false;
    }

    //Method to view all projects
    public void ShowProject(int eid)
    {
        foreach (Project e in projects)
        {

            if (e.id == eid)
            {
                Console.WriteLine(" Name of the project - " + e.ProjectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.Startdate + "\n End date of project - " + e.Enddate);
            }
            else
            {
                Console.WriteLine("Id not found");
            }
        }
    }

    public void SearchProject(string search)
    {
        
        var match = projects.Where(c => c.ProjectName.Contains(search));
        foreach (var e in match)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Name of the project - " + e.ProjectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.Startdate + "\n End date of project - " + e.Enddate);
        }

    }

}
//Class which consists of methods for adding and viewing Employees
public class EmpManagement
{
    public List<Employee> empList = new List<Employee>();
     
    //Method for adding new employee
    public void AddEmp(Employee emp)
    {
        empList.Add(emp);
    }


    public void displayEmp(Employee emp)
    {
        
        
        Console.WriteLine(" Employee Id - " + emp.EmployeeID + "\n Employee first name - " + emp.EmpFirstName + "\n Employee last name - " + emp.lastName + "\n Employee email id - " + emp.email + "\n Employee mobile number - " + emp.mobile + "\n Employee address - " + emp.address + "\n Role Id - " + emp.roleid + "\n Role Name - " + emp.roleName);
        Console.WriteLine("");
        Console.WriteLine("");
        
    }


    public Employee eDetails(int eid){
        Employee emp = new Employee();
        for(int i=0;i<empList.Count;i++){
            if(eid==empList[i].EmployeeID){
               emp=empList[i];
                return emp;
            }
        }
        return emp;
    }

    

    //Method for viewing all employees
    public void ShowEmp()
    {
        if(empList.Count == 0){
            Console.WriteLine("No employees available");
        }
        else{
        foreach (var e in empList)
        {
            displayEmp(e);
        }}
    }

    public void ShowEmployee(int eid)
    {
        foreach (Employee e in empList)
        {

            if (e.EmployeeID == eid)
            {
                Console.WriteLine(" Name of the Employee - " + e.EmpFirstName + " " + e.lastName + "\n Employee Id - " + e.EmployeeID);
            }
            else
            {
                Console.WriteLine("Id not found");
            }
        }
    }

    public Boolean exist(int eid){
        for(int i=0; i<empList.Count;i++){
            if(eid== empList[i].EmployeeID){
                return true;
            }
        }
        return false;
    }
}

//Class which consists of methods for adding and viewing roles
public class RoleManagement
{


    public List<Role> RoleList = new List<Role>();



    //Method for adding roles
    public void RoleAdd(Role role)
    {
        RoleList.Add(role);
    }

    //Method for viewing all roles
    public void displayRole()
    {
        RoleList.Sort();
        foreach (Role e in RoleList)
        {
            Console.WriteLine(" Name of the Role - " + e.RoleName + "\n Role Id - " + e.RoleId);
            Console.WriteLine();
        }
    }
}
}

