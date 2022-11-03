using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityTracking.WebApi.Entities;
using VelocityTracking.WebApi.Models;

namespace VelocityTracking.WebApi.Contracts.VelocityTrackingRecord
{
    public record VelocityTrackingRecordRequest
    (
        string ProjectName,
        string TaskTitle,
        string TaskDescription,
        int TaskTotalEstimate,
        List<EmployeeRecord> Employees
    );
}
