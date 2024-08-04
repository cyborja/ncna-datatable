namespace DataTable.Models.Core
{
    public class EmployeeDetails
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public int Age { get; set; }
        public DateOnly StartDate { get; set; }
        public double Salary { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
    }
}
