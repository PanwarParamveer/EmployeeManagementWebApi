using EmployeeManagementWebApi.Models;

namespace EmployeeManagementWebApi.Repository
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int empId);
    }
}
