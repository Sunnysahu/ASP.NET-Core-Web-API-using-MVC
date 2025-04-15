using AdminPortal.Data;
using AdminPortal.Models;
using AdminPortal.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPortal.Controllers
{
    // localhost:xxxx/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        // Fetching all DATA from DB

        [HttpGet]
        public IActionResult GetAllEmployees()
        {

            var allEmployees = dbContext.Employees.ToList();

            return Ok(allEmployees);


        }

        // Fetching Data from DB using GUID

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeByID(Guid id)
        {
            var employee = dbContext.Employees.Find(id);

            if (employee is null)
            {
                return NotFound();
            }

            return Ok(employee);

        }

        // Adding DATA to DB

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeeDto addEmployeeeDto)  //use DTO --> Data Transfer Object
        {
            var employeeEntity = new Employee()
            {
                Name = addEmployeeeDto.Name,
                Email = addEmployeeeDto.Email,
                Phone = addEmployeeeDto.Phone,
                Salary = addEmployeeeDto.Salary,
            };

            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();

            return Ok(employeeEntity);

        }

        // Updating DATA to DB

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = dbContext.Employees.Find(id);

            if (employee is null)
            {
                return NotFound();
            }

            employee.Name = updateEmployeeDto.Name;
            employee.Email = updateEmployeeDto.Email;
            employee.Phone = updateEmployeeDto.Phone;
            employee.Salary = updateEmployeeDto.Salary;
            dbContext.SaveChanges();
            return Ok(employee);
        }
    }
}



// Here all the Bssic Setup is Done now only we have to write the Crud Operation
