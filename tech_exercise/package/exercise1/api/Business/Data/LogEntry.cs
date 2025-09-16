using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StargateAPI.Business.Data
{
    [Table("Logs")]
    public class LogEntry
    {
        [Key]
        public int Id { get; set; }

        public required string LogContent { get; set; }

        public string? ExceptionMessage { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
