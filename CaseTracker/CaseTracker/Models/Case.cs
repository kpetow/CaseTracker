using System.ComponentModel.DataAnnotations;

namespace CaseTracker.Models
{
    public class Case
    {
        [Key]
        public int Id { get; set; }
        public int ActivityId { get; set; } //assigned by employee
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public string CaseStatus { get; set; }
        [Required]
        public string VslName { get; set; }
        public int VslOffNum { get; set; }    
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string ContactNum { get; set; }
        public string UserEmail { get; set; }


    }
}
