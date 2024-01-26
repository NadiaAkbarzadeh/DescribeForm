using System.ComponentModel.DataAnnotations;

namespace DescribeForm.Models.Command
{
    public class RegisterDescribeCommand
    {
        [Display(Name = "ثبت شرح جدید ")]
        [MaxLength(250, ErrorMessage =  "این فیلد نباید بیشتر از 250 کاراکتر باشد!")]
        [Required (ErrorMessage = "این فیلد نباید خالی باشد! ")]
        public string Name { get; set; }

    }
}
