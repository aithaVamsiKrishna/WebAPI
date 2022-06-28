using WebApplication1.Services.Interfaces;
using WebApplication1.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees;
        public EmployeeService()
        {
            _employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Raj"},
                new Employee() { Id = 2, Name = "Vishnu"}
            };
        }
        //Create
        public void CreateEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        //Read

        public Employee GetEmployee(int id)
        {
            return _employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }

        //Delete

        public bool DeleteEmployee(int id)
        {
            _employees = _employees.Where(x => x.Id != id).ToList();
            return true;
        }
       

        //Update

        public void UpdateEmployee(Employee employee)
        {
            
            var originalEmployee = GetEmployee(employee.Id);
            if (originalEmployee != null)
            {
                _employees.ForEach(item =>
                {
                    if (item.Id == employee.Id)
                    {
                        item.Name = employee.Name;

                    }
                }); 

            }
            else
            {
                _employees.Add(employee);
            }
        }

    }
}
