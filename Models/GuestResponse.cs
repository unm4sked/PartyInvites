using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podać swoje imię i nazwisko.")]
        public string Name {get; set;}
        
        [Required(ErrorMessage = "Proszę podać adres email.")]
        public string Email {get; set;}

        [Required(ErrorMessage = "Proszę podać numer telefonu.")]
        public string Phone {get; set;}

        [Required(ErrorMessage = "Określ czy weźmiesz udział.")]
        public bool? WillAttend {get; set;}

    }
}