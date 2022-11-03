using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelocityTracking.WebApi.Entities
{
    [Table("employee")]
    public class Employee
    {
        [Column("employee_id")]
        [Key]
        public int Id { get; set; }

        [Column("name", TypeName = "varchar(128)")]
        public string Name { get; set; } = string.Empty;

        [Column("datetime_created", TypeName = "datetime")]
        public DateTime DatetimeCreated { get; set; }

        [Column("datetime_updated", TypeName = "datetime")]
        public DateTime? DatetimeUpdated { get; set; } = null;

        public int StatusCode { get; set; }

    }
}
