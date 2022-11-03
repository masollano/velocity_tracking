using VelocityTracking.WebApi.Data;
using VelocityTracking.WebApi.Application.Interfaces;
using VelocityTracking.WebApi.Entities;
using Dapper;
using System.Data;

namespace VelocityTracking.WebApi.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DapperContext _dapperContext;
        private readonly IDbConnection _connection;
        public EmployeeRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
            _connection = _dapperContext.CreateConnection();
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var spr_name = "sp_employee_lst";
            var query = await _connection.QueryAsync<Employee>(spr_name, commandType: CommandType.StoredProcedure);
            var result = query.ToList();
            return result;
        }

        public async Task<int> CreateEmployee(Employee employee)
        {
            var spr_name = "sp_employee_ins";
            var spr_params = new DynamicParameters();
            {
                spr_params.Add("name", employee.Name, DbType.String, ParameterDirection.Input);
                spr_params.Add("datetime_created", employee.DatetimeCreated, DbType.DateTime, ParameterDirection.Input);
                spr_params.Add("statuscode", employee.StatusCode, DbType.Int32, ParameterDirection.Input);
            };

                
            var query = await _connection.ExecuteScalarAsync<int>(spr_name, spr_params, commandType: CommandType.StoredProcedure);
           
            return query;
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            var spr_name = "sp_employee_sel";
            var spr_params = new DynamicParameters();
            {
                spr_params.Add("employee_id", id, DbType.Int32, ParameterDirection.Input);
            };

            var query = await _connection.ExecuteScalarAsync<Employee>(spr_name, spr_params, commandType: CommandType.StoredProcedure);
            
            return query;
        }

        public async Task<Employee> UpdateEmployee(int id, Employee employee)
        {
            var spr_name = "sp_employee_upd";
            var spr_params = new DynamicParameters();
            {
                spr_params.Add("employee_id", id, DbType.Int32, ParameterDirection.Input);
            };

            var query = await _connection.ExecuteScalarAsync<Employee>(spr_name, spr_params, commandType: CommandType.StoredProcedure);

            return query;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
