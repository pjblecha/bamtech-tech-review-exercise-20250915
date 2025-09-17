using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StargateAPI.Business.Data
{
    [Table("Logs")]
    public class LogEntry
    {
        [Key]
        public int Id { get; set; }

        public required string LogContent { get; set; } = string.Empty;

        public string ExceptionMessage { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; }

    }

    public class LogEntryConfiguration : IEntityTypeConfiguration<LogEntry>
    {
        public void Configure(EntityTypeBuilder<LogEntry> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }
}
