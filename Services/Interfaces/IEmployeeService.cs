using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services.Interfaces
{
    public interface IEmployeeService
    {
        //Create
        void CreateEmployee(Employee employee);

        //Read
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();

        //update
        void UpdateEmployee(Employee employee);

        //Delete
        bool DeleteEmployee(int id );



    }
}
