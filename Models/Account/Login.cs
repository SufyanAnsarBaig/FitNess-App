using System.ComponentModel.DataAnnotations;

namespace FitnessCare.Models.Acount
{
    public class Login

{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
}
