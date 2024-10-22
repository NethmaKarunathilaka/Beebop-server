using System.ComponentModel.DataAnnotations;

namespace Bee_bop.Models

{
    public class User
    {
        [Key]
        public  required int id { get; set; }
        public required  string username { get; set; }
        public  required string password { get; set; }

        public ICollection<Message>? messages { get; set; }
    }
}
