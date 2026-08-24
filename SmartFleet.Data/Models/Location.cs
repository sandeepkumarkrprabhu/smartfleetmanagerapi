
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string LocationCode {get;set;}   
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        

        [MaxLength(100)]
        public string ContactPerson {get;set;}  
        
        [MaxLength(100)]
        public string Email {get;set;}
        
        [MaxLength(30)]
        public string Phone {get;set;}
        
        [MaxLength(200)]
        public string Address {get;set;}

        [MaxLength(50)]
        public string City {get;set;}
        
        [MaxLength(50)]
        public string State {get;set;}
        
        [MaxLength(20)]
        public string LocationType {get;set;}
        
        [MaxLength(50)]
        public string Country {get;set;}

        [MaxLength(20)]
        public string PostalCode {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public int BranchID { get; set; }
        public bool IsLocalForOppo { get; set; } = false;

        [MaxLength(8)]
        public string? ShortName { get; set; }

        
    }
}
