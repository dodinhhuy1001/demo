namespace MISA.Web08.Api.Model
{
    public class Employee
    {
        public Guid EmployeeID { get; set; }

        public string FullName {  get; set; }

        public string EmployeeCode { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public int? Gender { get; set; }
    }
}
