using DataTable.Models.Core;
using DataTable.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataTable.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        /// <summary>
        /// Get employees
        /// </summary>
        /// <param name="lastname">Filter by lastname</param>
        /// <param name="position">Filter by position</param>
        /// <param name="office">Filter by office</param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<EmployeeDetails> GetEmployeeDetails(string? lastname, string? position, string? office)
        {
            var service = new EmployeeService();
            var query = service.GetEmployees().AsQueryable();

            if (lastname != null)
            {
                query = query.Where(e => string.Equals(e.Lastname, lastname, StringComparison.OrdinalIgnoreCase));
            }

            if (position != null)
            {
                query = query.Where(e => string.Equals(e.Position, position, StringComparison.OrdinalIgnoreCase));
            }

            if (office != null)
            {
                query = query.Where(e => string.Equals(e.Office, office, StringComparison.OrdinalIgnoreCase));
            }

            return query.AsEnumerable();
        }

        /// <summary>
        /// Get unique lastnames
        /// </summary>
        /// <returns></returns>
        [HttpGet("lastname")]
        public IEnumerable<string> GetUniqueLastname()
        {
            var service = new EmployeeService();
            var uniqueLastname = service.GetEmployees().Select(e => e.Lastname).Distinct();
            return uniqueLastname;
        }

        /// <summary>
        /// Get unique positions
        /// </summary>
        /// <returns></returns>
        [HttpGet("position")]
        public IEnumerable<string> GetUniquePosition()
        {
            var service = new EmployeeService();
            var uniquePosition = service.GetEmployees().Select(e => e.Position).Distinct();
            return uniquePosition;
        }

        /// <summary>
        /// Get unique office locations
        /// </summary>
        /// <returns></returns>
        [HttpGet("office")]
        public IEnumerable<string> GetUniqueOffice()
        {
            var service = new EmployeeService();
            var uniqueOffice = service.GetEmployees().Select(e => e.Office).Distinct();
            return uniqueOffice;
        }
    }
}
