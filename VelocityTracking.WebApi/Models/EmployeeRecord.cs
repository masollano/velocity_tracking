namespace VelocityTracking.WebApi.Models
{
    public class EmployeeRecord
    {
        public string EmployeeName { get; set; } = string.Empty;
        public int EstimatedHours  {get; set; }
        public int ActualHours { get; set; }
    }    
}
