using System.ComponentModel.DataAnnotations;

namespace skilltech.Models
{
    public class contatoModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
