using EmployeeManagementWebApi.Models;

namespace EmployeeManagementWebApi.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public List<Employee> GetAllEmployee()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { Id = 1, Name = "Param" });
            list.Add(new Employee { Id = 2, Name = "Dharam" });
            return list;
        }

        public Employee GetEmployeeById(int empId)
        {            
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { Id = 1, Name = "Param" });
            list.Add(new Employee { Id = 2, Name = "Dharam" });
            return list.Find(x => x.Id == empId);
        }
    }
}
