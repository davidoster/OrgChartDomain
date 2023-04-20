using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class BaseClass
    {
        public string Name { get; set; }

        public List<Employee>? Employees { get; set; }
    }


    public class Employee : BaseClass 
    {
        public string Title { get; set; }
        public string ReportingTo { get; set; }        
    
    }

    public class SubDepartment : LevelX<T>
    {
        //List<Employee>? Employees { get; set; }
    }

    public class Department : LevelX<SubDepartment>
    {
        //public List<SubDepartment> SubDepartments { get; set; }
        
    }

    public class Division: LevelX<Department> 
    {
        //List<Department> Departments { get; set; }
    }

    public enum LevelType
    {
        Division,
        Department,
        SubDepartment
    }
    public class LevelX<T>: BaseClass 
    {
        public string LevelName { get; set; }
        public LevelType Type { get; set; }
        public List<T>? SubLevel { get; set; }
    }
    

    public class MainObject : BaseClass 
    {
        public List<Level> Levels { get; set; }
        public List<BaseClass> Employees { get; set; }
    
    }
}
