using System.ComponentModel.DataAnnotations;

namespace DescribeForm.Models.Command
{
    public class EditDescribeCommand
    {
        public int Id { get; set; }

        [Display(Name = "ثبت شرح جدید")]
        [MaxLength(50, ErrorMessage = "این فیلد نباید بیشتر از 250 کاراکتر باشد!")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد! ")]
        public string Name { get; set; }
    }
}
