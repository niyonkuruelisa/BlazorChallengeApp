using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChallengeApp.Shared
{
    public class Booking
    {
        public string? Id { get; set; }
        [Required]
        [RegularExpression(@"^[\p{L}]+$",ErrorMessage ="Accepted Only Alphabet characters.")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        
        public string? Email { get; set; } = string.Empty;
        public string? day { get; set; }
        public string? time { get; set; }
        public int? movieId { get; set; }
        public List<Seat> seats { get; set; }
    }
}
