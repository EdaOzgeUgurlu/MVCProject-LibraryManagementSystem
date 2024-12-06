using System.ComponentModel.DataAnnotations;

namespace MVCProject_LibraryManagementSystem.Models.ViewModels.AuthorViewModels
{
    // Yazar detaylarını göstermek için kullanılan ViewModel sınıfı
    public class AuthorDetailsViewModel
    {
        // Yazarın benzersiz kimlik numarası
        public int Id { get; set; }

        [Display(Name = "Author First Name")]
        public string FirstName { get; set; } = "";


        [Display(Name = "Author Last Name")]
        public string LastName { get; set; } = "";


        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Details")]
        public string Details { get; set; } = "";

        public List<Book> Books { get; set; } = new();
    }
}
