using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class UserModel
    {

        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        [RegularExpression(@"^[a-zA-ZÖöıİşçÇğĞÜüŞ0-9''-'\s]+$",
        ErrorMessage = "İsim alanına Rakam ve özel karakter girilemez.")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Şifre alanı boş olamaz.")]
        [MinLength(7), MaxLength(20)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[a-zA-Z0-9İıöÖüÜçÇğĞşŞ]{7,20}$", 
            ErrorMessage = "En az 7, en fazla 20 karakter girilebilir Özel karakter girilemez!")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
        [StringLength(20, ErrorMessage = "En az 7, en fazla 20 karakter girilebilir Özel karakter girilemez!", MinimumLength = 7)]
        public string ConfirmPassword { get; set; }



        [Required(ErrorMessage = "Email alanı boş olamaz.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", 
            ErrorMessage = "Not a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon alanı boş olamaz.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([5]{1}[0-9]{1}[0-9]{1})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{2})[-. ]?([0-9]{2})$", 
            ErrorMessage = "Not a valid phone number 553-XXX-XX-XX || 553XXXXXXX")]
        public string Phone { get; set; }
    }







}

