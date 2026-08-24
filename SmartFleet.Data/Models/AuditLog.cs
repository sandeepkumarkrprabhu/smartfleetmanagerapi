using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SmartFleet.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SmartFleet.Data.Models
{
    public class AuditLog
    {
        [Key]
        public long AuditId { get; set; }

        [Required]
        public int UserId { get; set; }

        [MaxLength(200)]
        public string? SessionId { get; set; }

        [Required]
        [MaxLength(50)]
        public AuditActionType ActionType { get; set; }  // CREATE / UPDATE / DELETE

        [Required]
        [MaxLength(150)]
        public string EntityName { get; set; } = string.Empty;  // Table name

        [MaxLength(100)]
        public string? EntityId { get; set; }

        public string? Changes { get; set; }   // JSON diff

        [MaxLength(50)]
        public string? Status { get; set; }    // Success / Failed

        public string? ErrorMessage { get; set; }

        public int? ExecutionTimeMs { get; set; }

        [MaxLength(50)]
        public string? IPAddress { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
