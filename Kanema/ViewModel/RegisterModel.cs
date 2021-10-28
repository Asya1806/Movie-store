using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kanema.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Поле логин не заполнено")]
        [StringLength(40, ErrorMessage = "Логин должен быть от 8 до 40 символов", MinimumLength = 8)]
        [Display(Name = "Email")]
        public string Login { get; set; }
       
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Поле пароль не заполнено")]
        [StringLength(20, ErrorMessage = "Пароль должен быть от 8 до 20 символов", MinimumLength = 8)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Пароли не совпадают")]
        [StringLength(20, ErrorMessage = "Пароль должен быть от 8 до 20 символов", MinimumLength = 8)]
        [Display(Name = "Подтвердить пароль")]
        public string ConfirmPassword { get; set; }
    }
}
