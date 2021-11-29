using mypracticework.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace mypracticework.Repository
{
    public class EmployeeStorage
    {
        private Dictionary<int, Employee> Employees { get; } = new Dictionary<int, Employee>();

        public void Create(Employee employee)
        {
            Employees.Add(employee.EmployeeId, employee);
        }

        public Employee Read(int employeeId)
        {
            return Employees[employeeId];
        }

        public Employee Update(int employeeId, Employee newEmployee)
        {
            Employees[employeeId] = newEmployee;
            return Employees[employeeId];
        }

        public bool Delete(int employeeId)
        {
            return Employees.Remove(employeeId);
        }

    }
}




      
    }
}