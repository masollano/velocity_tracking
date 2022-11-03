using VelocityTracking.WebApi.Models;

namespace VelocityTracking.WebApi.Contracts.VelocityTrackingRecord
{
    public record VelocityTrackingRecordResponse
    (
        string ProjectName,
        string TaskTitle,
        string TaskDescription,
        int TaskTotalEstimate,
        List<EmployeeRecord> Employees
    );
}
