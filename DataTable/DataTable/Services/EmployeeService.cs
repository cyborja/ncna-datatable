using DataTable.Models.Core;
using System.Data;
using System;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Extensions.Hosting;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Runtime.InteropServices;

namespace DataTable.Services
{
    public class EmployeeService
    {
        public List<EmployeeDetails> GetEmployees()
        {
            return new List<EmployeeDetails>
            {
                new EmployeeDetails
                {
                    Firstname = "Tiger",
                    Lastname = "Nixon",
                    Position = "System Architect",
                    Office = "Edinburgh",
                    Age = 61,
                    StartDate = new DateOnly(2011, 4, 25),
                    Salary = 320_000,
                    Extension = "5421",
                    Email = "t.nixon@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Garret",
                    Lastname = "Winters",
                    Position = "Accountant",
                    Office = "Tokyo",
                    Age = 63,
                    StartDate = new DateOnly(2011, 7, 25),
                    Salary = 170_750,
                    Extension = "8422",
                    Email = "g.winters@datatables.net"
                },
                new EmployeeDetails {
                    Firstname = "Ashton",
                    Lastname = "Cox",
                    Position = "Junior Technical Author",
                    Office = "San Francisco",
                    Age = 66,
                    StartDate = new DateOnly(2009, 1, 12),
                    Salary = 86_000,
                    Extension = "1562",
                    Email = "a.cox@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Cedric",
                    Lastname = "Kelly",
                    Position = "Senior Javascript Developer",
                    Office = "Edinburgh",
                    Age = 22,
                    StartDate = new DateOnly(2012, 3, 29),
                    Salary = 433_060,
                    Extension = "6224",
                    Email = "c.kelly@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Airi",
                    Lastname = "Satou",
                    Position = "Accountant",
                    Office = "Tokyo",
                    Age = 33,
                    StartDate = new DateOnly(2008, 11, 28),
                    Salary = 162_700,
                    Extension = "5407",
                    Email = "a.satou@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Brielle",
                    Lastname = "Williamson",
                    Position = "Integration Specialist",
                    Office = "New York",
                    Age = 61,
                    StartDate = new DateOnly(2012, 12, 02),
                    Salary = 372_000,
                    Extension = "4804",
                    Email = "b.williamson@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Herrod",
                    Lastname = "Chandler",
                    Position = "Sales Assistant",
                    Office = "San Francisco",
                    Age = 59,
                    StartDate = new DateOnly(2012, 08, 06),
                    Salary = 137_500,
                    Extension = "9608",
                    Email = "h.chandler@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Rhona",
                    Lastname = "Davidson",
                    Position = "Integration Specialist",
                    Office = "Tokyo",
                    Age = 55,
                    StartDate = new DateOnly(2010, 10, 14),
                    Salary = 327_900,
                    Extension = "6200",
                    Email = "r.davidson@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Colleen",
                    Lastname = "Hurst",
                    Position = "Javascript Developer",
                    Office = "San Francisco",
                    Age = 39,
                    StartDate = new DateOnly(2009, 9, 15),
                    Salary = 205_500,
                    Extension = "2360",
                    Email = "c.hurst@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Sonya",
                    Lastname = "Frost",
                    Position = "Software Engineer",
                    Office = "Edinburgh",
                    Age = 23,
                    StartDate = new DateOnly(2008, 12, 13),
                    Salary = 103_600,
                    Extension = "1667",
                    Email = "s.frost@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Jena",
                    Lastname = "Gaines",
                    Position = "Office Manager",
                    Office = "London",
                    Age = 30,
                    StartDate = new DateOnly(2008, 12, 19),
                    Salary = 90_560,
                    Extension = "3814",
                    Email = "j.gaines@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Quinn",
                    Lastname = "Flynn",
                    Position = "Support Lead",
                    Office = "Edinburgh",
                    Age = 22,
                    StartDate = new DateOnly(2013, 3, 3),
                    Salary = 342_000,
                    Extension = "9497",
                    Email = "q.flynn@datatables.net"
                },
                new EmployeeDetails
                {
                    Firstname = "Charde",
                    Lastname = "Marshall",
                    Position = "Regional Director",
                    Office = "San Francisco",
                    Age = 36,
                    StartDate = new DateOnly(2008, 10, 16),
                    Salary = 470_600,
                    Extension = "6741",
                    Email = "c.marshall@datatables.net"
                }
            };
        }
    }
}
