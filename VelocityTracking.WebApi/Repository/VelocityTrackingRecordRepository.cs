using Dapper;
using System.Collections.Generic;
using System.Data;
using VelocityTracking.WebApi.Application.Interfaces;
using VelocityTracking.WebApi.Data;
using VelocityTracking.WebApi.Entities;

namespace VelocityTracking.WebApi.Repository
{
    public class VelocityTrackingRecordRepository : IVelocityTrackingRecordRepository
    {
        private readonly DapperContext _dapperContext;
        private readonly IDbConnection _connection;

        public VelocityTrackingRecordRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
            _connection = _dapperContext.CreateConnection();
        }

        public async Task<IEnumerable<VelocityTrackingRecord>> GetVelocityTrackingRecords()
        {
            var spr_name = "sp_velocity_tracking_record_lst";

            var query = await _connection.QueryAsync<VelocityTrackingRecord>(spr_name, commandType: CommandType.StoredProcedure);
            var result = query.ToList();
            return result;
        }

        public async Task<int> CreateVelocityTrackingRecord(VelocityTrackingRecord velocityTrackingRecord)
        {
            var spr_name = "sp_velocity_tracking_record_ins";
            var spr_params = new DynamicParameters();

            spr_params.Add("project_name", velocityTrackingRecord.ProjectName, DbType.String, ParameterDirection.Input);
            spr_params.Add("task_title", velocityTrackingRecord.TaskTitle, DbType.String, ParameterDirection.Input);
            spr_params.Add("task_description", velocityTrackingRecord.TaskDescription, DbType.String, ParameterDirection.Input);
            spr_params.Add("task_total_estimate", velocityTrackingRecord.TaskTotalEstimate, DbType.Int32, ParameterDirection.Input);
            spr_params.Add("employee_name", velocityTrackingRecord.EmployeeName, DbType.String, ParameterDirection.Input);
            spr_params.Add("estimated_hours", velocityTrackingRecord.EstimatedHours, DbType.Int32, ParameterDirection.Input);
            spr_params.Add("actual_hours", velocityTrackingRecord.ActualHours, DbType.Int32, ParameterDirection.Input);
            spr_params.Add("statuscode", velocityTrackingRecord.Statuscode, DbType.Int32, ParameterDirection.Input);

            var query = await _connection.ExecuteScalarAsync<int>(spr_name, spr_params, commandType: CommandType.StoredProcedure);

            return query;
        }
    }
}
