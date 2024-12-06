using System.ComponentModel.DataAnnotations;

namespace MVCProject_LibraryManagementSystem.Models.ViewModels.BookViewModels
{
    // Kitap düzenlemesini göstermek için kullanılan ViewModel sınıfı
    public class BookEditViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "This field is required.")] // Bu alanın doldurulması zorunludur; aksi halde bir hata mesajı gösterilir.
        public string Title { get; set; } = "";

        [Display(Name = "Author Id")]
        [Required(ErrorMessage = "This field is required.")]
        public int AuthorId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; } = "";

        [Display(Name = "Book Genre")]
        [Required(ErrorMessage = "This field is required.")]
        public string Genre { get; set; } = "";

        [Display(Name = "Publish Date")]
        [Required(ErrorMessage = "This field is required.")]
        public DateTime PublishDate { get; set; }

        [Display(Name = "ISBN")]
        [Required(ErrorMessage = "This field is required.")]
        [RegularExpression(@"^\d{3}-\d{3}$", ErrorMessage = "ISBN must be in the format 123-456.")]
        public string ISBN { get; set; } = "";

        [Display(Name = "Copies Available")]
        [Required(ErrorMessage = "This field is required.")]
        public int CopiesAvailable { get; set; }

        [Display(Name = "Details")]
        [Required(ErrorMessage = "This field is required.")]
        public string Details { get; set; } = "";
    }
}
