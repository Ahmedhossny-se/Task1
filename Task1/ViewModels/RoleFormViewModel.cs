using System.ComponentModel.DataAnnotations;

namespace Task1.ViewModels
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}
