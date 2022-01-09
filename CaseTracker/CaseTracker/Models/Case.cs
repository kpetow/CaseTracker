namespace CaseTracker.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string CaseStatus { get; set; }
        public string VslName { get; set; }
        public int VslOffNum { get; set; }
        public int ActivityId { get; set; } //assigned by employee
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string ContactNum { get; set; }
        public string UserEmail { get; set; }
        
        
    }
}
