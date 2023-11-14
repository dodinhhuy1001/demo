using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Dapper;
using MISA.Web08.Api.Model;

namespace MISA.Web08.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        /// <summary>
        /// Lấy danh sách toàn bộ nhân viên
        /// </summary>
        /// <returns>
        /// 200 - Danh sách khách hàng
        /// 204 - Không có dữ liệu
        /// </returns>
        /// Created By: ddhuy 
        [HttpGet]
        public IActionResult Get()
        {
            //Khởi tạo kết nối vs database:
            var connectionString = "Host=8.222.228.150; Port=3306; Database=misa.qlts_mf1726_ddhuy; UserId = nvmanh; Password=12345678";
            //1 Khởi tạo kết nối vs MariaDb:
            var sqlConnection = new MySqlConnection(connectionString);
            //2.Lấy dữ liệu:
            //2.1 Câu lệnh truy vấn dữ liệu:
            var sqlCommand = "SELECT * FROM Employee";
            //2.2 Thực hiện lấy dữ liệu:
            var employees = sqlConnection.Query<Employee>(sql: sqlCommand);
            //Trả kết quả cho Client:

            return Ok(employees);
        }
        /// <summary>
        /// Hàm lấy danh sách nhân viên theo id
        /// </summary>
        /// <returns>danh sách nhân viên dc chọn</returns>
        /// Created By: ddhuy 
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeId(Guid id)
        {
            var connectionString = "Host=8.222.228.150; Port=3306; Database=misa.qlts_mf1726_ddhuy; UserId = nvmanh; Password=12345678";
            var connection = new MySqlConnection(connectionString);

            var query = $"SELECT * FROM Employee WHERE EmployeeID = @id;";
            var result = await connection.QuerySingleOrDefaultAsync(query, new { id });

            return StatusCode(StatusCodes.Status200OK, result);
        }

        /// <summary>
        /// Hàm thêm nhân viên
        /// </summary>
        /// <returns>danh sách đã thêm 1 nhân viên</returns>
        /// Created By: ddhuy 
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            var connectionString = "Host=8.222.228.150; Port=3306; Database=misa.qlts_mf1726_ddhuy; UserId = nvmanh; Password=12345678";
            var connection = new MySqlConnection(connectionString);

            string insertQuery = @"INSERT INTO Employee(`EmployeeID`, `EmployeeCode`, `FullName`, `Email`, `PhoneNumber`) VALUES(@EmployeeID, @EmployeeCode, @FullName, @Email, @PhoneNumber)";
            var result = await connection.ExecuteAsync(insertQuery, employee);

            return StatusCode(StatusCodes.Status201Created, result);
        }

        ///<summary>
        ///Sửa thông tin của nhân viên có sẵn
        ///</summary>
        ///<return>Thông tin của nhân viên đã sửa</return>
        ///Created By: ddhuy 
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(Guid id, Employee employee)
        {
            var connectionString = "Host=8.222.228.150; Port=3306; Database=misa.qlts_mf1726_ddhuy; UserId = nvmanh; Password=12345678";
            var connection = new MySqlConnection(connectionString);
            string updateQuery = @"UPDATE Employee SET `EmployeeCode` = @EmployeeCode, `FullName`= @FullName, `Email`=@Email, `PhoneNumber`=@PhoneNumber, `Gender`= @Gender WHERE `EmployeeID`= @EmployeeID";
            employee.EmployeeID = id;
            var result = await connection.ExecuteAsync(updateQuery, employee);
            return StatusCode(StatusCodes.Status201Created, result);
        }

        ///<summary>
        ///Xóa thông tin của nhân viên theo id
        ///</summary>
        ///<return>Bảng có nhân viên đã xóa</return>
        ///Created By: ddhuy
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
            var connectionString = "Host=8.222.228.150; Port=3306; Database=misa.qlts_mf1726_ddhuy; UserId = nvmanh; Password=12345678";
            var connection = new MySqlConnection(connectionString);

            Employee employee;

            string selectQuery = @"SELECT * FROM Employee WHERE `EmployeeId`=@EmployeeId";
            employee = await connection.QueryFirstOrDefaultAsync<Employee>(selectQuery, new { EmployeeId = id });
            string deleteQuery = @"DELETE FROM Employee WHERE `EmployeeId`=@EmployeeId";
            var result = await connection.QueryFirstOrDefaultAsync<Employee>(deleteQuery, new { EmployeeId = id });
            return StatusCode(StatusCodes.Status200OK, result);
        }
    }
}
