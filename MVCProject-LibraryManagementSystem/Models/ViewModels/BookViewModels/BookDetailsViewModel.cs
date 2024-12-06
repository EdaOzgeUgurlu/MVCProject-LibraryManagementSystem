using System.ComponentModel.DataAnnotations;

namespace MVCProject_LibraryManagementSystem.Models.ViewModels.BookViewModels
{
    // Kitap detaylarını göstermek için kullanılan ViewModel sınıfı
    public class BookDetailsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; } = "";

        [Display(Name = "Author Id")]
        public int AuthorId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; } = "";

        [Display(Name = "Book Genre")]
        public string Genre { get; set; } = "";

        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }

        [Display(Name = "ISBN")]
        public string ISBN { get; set; } = "";

        [Display(Name = "Copies Available")]
        public int CopiesAvailable { get; set; }

        [Display(Name = "Details")]
        public string Details { get; set; } = "";

    }
}
