using System.ComponentModel.DataAnnotations;

namespace Bee_bop.Models

{
    public class User
    {
        [Key]
        public  required int Id { get; set; }
        public required  string username { get; set; }
        public  required string password { get; set; }
    }
}
