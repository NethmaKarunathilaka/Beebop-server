using System.ComponentModel.DataAnnotations;

namespace Bee_bop.Models
{
    public class Message
    {
        [Key]
        public  required int mid { get; set; }
        public  required string message { get; set; }

        public int user_id { get; set; }
        public User? user { get; set; }

    }
}
