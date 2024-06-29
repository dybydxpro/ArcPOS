using System.ComponentModel.DataAnnotations;

namespace ArcPOS.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
    }
}
