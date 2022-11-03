using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VelocityTracking.WebApi.Entities
{
    [Table("task")]
    public class Tasks
    {
        [Column("task_id")]
        [Key]
        public int Id { get; set; }

        [Column("project_id")]
        public int ProjectId { get; set; }

        [Column("name", TypeName = "varchar(128)")]
        public string Name { get; set; } = string.Empty;

        [Column("estimated_hours")]
        public int EstimatedHours { get; set; }

        [Column("actual_hours")]
        public int ActualHours { get; set; }

        [Column("datetime_created", TypeName = "datetime")]
        public DateTime DatetimeCreated { get; set; }

        [Column("datetime_updated", TypeName = "datetime")]
        public DateTime? DatetimeUpdated { get; set; } = null;

        public int StatusCode { get; set; }
    }
}
