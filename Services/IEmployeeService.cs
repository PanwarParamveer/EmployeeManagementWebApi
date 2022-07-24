using EmployeeManagementWebApi.Models;

namespace EmployeeManagementWebApi.Services
{
    public interface IEmployeeService
    {

        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int empId);

    }
}
