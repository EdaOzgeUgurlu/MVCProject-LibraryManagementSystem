namespace MVCProject_LibraryManagementSystem.Models
{
    public class Author
    {
        // Authors sınıfının özellikleri
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        public string Details { get; set; } = "";
    }
}
