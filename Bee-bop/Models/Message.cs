using System.ComponentModel.DataAnnotations;

namespace Bee_bop.Models
{
    public class Message
    {
        [Key]
        public  required int id { get; set; }
        public  required string message { get; set; }
        
    }
}
