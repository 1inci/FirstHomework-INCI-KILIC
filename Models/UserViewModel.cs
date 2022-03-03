using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstHomework_INCI_KILIC.Models
{
    public class UserViewModel
    {
        //ID
        public int Id { get; set; }

        //FIRST NAME için gerekli tanımlamalar yapılmıştır.
        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [DataType(DataType.Text)]
        [Display(Name = "Adınız")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Lütfen geçerli bir ad giriniz!")]
        public String FirstName { get; set; }


        //SURNAME için gerekli tanımlamalar yapılmıştır.
        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [DataType(DataType.Text)]
        [Display(Name = "Soyadınız")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Lütfen geçerli bir soyad giriniz!")]
        public String LastName { get; set; }

        //MAIL için gerekli tanımlamalar yapılmıştır.
        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [Display(Name = "E-mail")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage = "Lütfen geçerli bir e-mail adresi giriniz! Örn: asd@fgh.com ")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        //PASSWORD için gerekli tanımlamalar yapılmıştır.
        [Required(ErrorMessage = "Bu alan gereklidir!")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Şifre en az 8 karakter olmalıdır! En az 1 büyük harf, en az 1 karakter ve en az 1 sayı içermelidir!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}
