using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveApp.Models
{
    public class LeaveApplication
    {
        [Key]
        public int LeaveId { get; set; }

        public string Username { get; set; }

        [Required]
        public string Reason { get; set; }

        [Required]
        public DateTime FromDate { get; set; }

        [Required]
        public DateTime ToDate { get; set; }

        public string Status { get; set; } // Draft, Manager, HR Finalized, Rejected, Resubmission
    }
}
