using ContactList.Server.Areas.Identity.Data;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace ContactList.Server.Models
{
    public class Attempt
    {
        [Key]
        public int AttemptId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
