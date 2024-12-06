using System.ComponentModel.DataAnnotations;

namespace MVCProject_LibraryManagementSystem.Models.ViewModels.AuthorViewModels
{
    // Yeni bir yazar eklemek için kullanılan ViewModel sınıfı
    public class NewAuthorViewModel
    {

        [Display(Name = "Author First Name")]
        [Required(ErrorMessage = "This field is required.")]// Bu alanın doldurulması zorunludur; aksi halde bir hata mesajı gösterilir.
        public string FirstName { get; set; } = "";

        [Display(Name = "Author Last Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string LastName { get; set; } = "";

        [Display(Name = "Date Of Birth")]
        [Required(ErrorMessage = "This field is required.")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Details")]
        [Required(ErrorMessage = "This field is required.")]
        public string Details { get; set; } = "";
    }
}

