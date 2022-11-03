namespace VelocityTracking.WebApi.Models
{
    public class VelocityTrackingRecordResponseModel
    {
        public string ProjectName { get; set; } = String.Empty;
        public string TaskTitle { get; set; } = String.Empty;
        public string TaskDescription { get; set; } = String.Empty;
        public int TaskTotalEstimate;
        public List<EmployeeRecord> Employees { get; set; } = new List<EmployeeRecord>();
    }
}
