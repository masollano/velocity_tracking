using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelocityTracking.WebApi.Entities
{
    [Table("velocity_tracking_record")]
    public class VelocityTrackingRecord
    {
        [Key]
        [Column("velocity_tracking_record_id")]
        public int Id { get; set; }
        [Column("project_name")]
        public string ProjectName { get; set; } = string.Empty;
        [Column("task_title")]
        public string TaskTitle { get; set; } = string.Empty;
        [Column("task_description")]
        public string TaskDescription { get; set; } = string.Empty;
        [Column("task_total_estimate")]
        public int TaskTotalEstimate { get; set; }
        [Column("employee_name")]
        public string EmployeeName { get; set; } = string.Empty;
        [Column("estimated_hours")]
        public int EstimatedHours { get; set; }
        [Column("actual_hours")]
        public int ActualHours { get; set; }
        [Column("datetime_created", TypeName = "datetime")]
        public DateTime DateTimeCreated { get; set; }
        [Column("datetime_updated", TypeName = "datetime")]
        public DateTime? DateTimeUpdated { get; set; } = null;
        public int Statuscode { get; set; }
    }
}
