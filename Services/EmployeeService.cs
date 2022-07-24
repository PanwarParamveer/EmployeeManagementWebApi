using EmployeeManagementWebApi.Models;
using EmployeeManagementWebApi.Repository;

namespace EmployeeManagementWebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepo _employeeRepo;
        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public List<Employee> GetAllEmployee()
        {
            return _employeeRepo.GetAllEmployee();
        }

        public Employee GetEmployeeById(int empId)
        {
            return _employeeRepo.GetEmployeeById(empId);
        }
    }
}
