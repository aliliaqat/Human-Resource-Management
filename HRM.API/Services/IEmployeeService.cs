using HRM.API.Model;
using HRM.API.Repository;

namespace HRM.API.Services
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetEmployees();
        public Task<Employee> GetEmployee(int id);
        public Task<string> EditEmployee(int id, Employee employee);
        public Task<string> AddEmployee(Employee employee);
        public Task<string> RemoveEmployee(int id);
    }
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _employeeRepository = repository;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            try
            {
                return await _employeeRepository.SelectAllEmployees();
            }
            catch (Exception exp)
            {
                throw (exp);
            }
        }

        public async Task<Employee> GetEmployee(int id)
        {
            try
            {
                return await _employeeRepository.SelectEmployee(id);
            }
            catch (Exception exp)
            {
                throw (exp);
            }
        }

        public async Task<string> EditEmployee(int id, Employee employee)
        {
            try
            {
                return await _employeeRepository.UpdateEmployee(id, employee);
            }
            catch (Exception exp)
            {
                throw (exp);
            }
        }

        public async Task<string> AddEmployee(Employee employee)
        {
            try
            {
                return await _employeeRepository.SaveEmployee(employee);
            }
            catch (Exception exp)
            {
                throw (exp);
            }
        }

        public async Task<string> RemoveEmployee(int id)
        {
            try
            {
                return await _employeeRepository.DeleteEmployee(id);
            }
            catch (Exception exp)
            {
                throw (exp);
            }
        }

    }
}
