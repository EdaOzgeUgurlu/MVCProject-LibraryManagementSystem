using System.ComponentModel.DataAnnotations;

namespace MVCProject_LibraryManagementSystem.Models.ViewModels.AuthorViewModels
{
    // Yazar düzenlemesini göstermek için kullanılan ViewModel sınıfı
    public class AuthorEditViewModel
    {
        public int Id { get; set; } // Yazarın benzersiz ID'si

        [Display(Name = "Author First Name")]
        [Required(ErrorMessage = "This field is required.")] // Bu alanın doldurulması zorunlu, aksi takdirde hata mesajı gösterilecek.
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
