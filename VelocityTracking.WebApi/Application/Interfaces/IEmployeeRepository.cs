using VelocityTracking.WebApi.Entities;

namespace VelocityTracking.WebApi.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeById(int id);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<int> CreateEmployee(Employee employee);
        Task<Employee> UpdateEmployee(int id, Employee employee);
        Task<bool> DeleteEmployee(int id);
    }
}
