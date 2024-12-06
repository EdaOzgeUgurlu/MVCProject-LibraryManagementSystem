using Microsoft.AspNetCore.Mvc;
using MVCProject_LibraryManagementSystem.Models;
using MVCProject_LibraryManagementSystem.Models.Data;
using MVCProject_LibraryManagementSystem.Models.ViewModels.AuthorViewModels;
namespace MVCProject_LibraryManagementSystem.Controllers
{
    public class AuthorsController : Controller
        {
            // Tüm yazarları listelemek için kullanılan yöntem
            public IActionResult Index()
            {
            var authors = AData.Authors; // Yazar verilerini getirir
            return View(authors);        // Verileri görünüme gönderir
            }

            // Yeni yazar formunu görüntülemek için kullanılan GET yöntemi
            [HttpGet]
            public IActionResult NewAuthor()
            {
                return View();
            }

            // Yeni yazar eklemek için kullanılan POST yöntemi
            [HttpPost]
            public IActionResult NewAuthor(NewAuthorViewModel author)
            {
                if (ModelState.IsValid) // Model doğrulama başarılıysa
                {
                    Author NewAuthor = new Author
                    {
                        Id = AData.Authors.Max(a => a.Id) + 1, // Yeni bir Id oluştur
                        FirstName = author.FirstName,
                        LastName = author.LastName,
                        DateOfBirth = author.DateOfBirth,
                        Details = author.Details,
                    };
                    AData.Authors.Add(NewAuthor); // Yeni yazarı listeye ekle
                    return RedirectToAction("Index");
                }
                return View();
            }

            // Yazar düzenleme formunu görüntülemek için kullanılan GET yöntemi
            [HttpGet]
            public IActionResult Edit(int id)
            {
                Author? author = AData.Authors.FirstOrDefault(a => a.Id == id); // İlgili yazarı bul

                if (author == null)
                    return NotFound(); // Yazar bulunamazsa 404 döndür

                AuthorEditViewModel vm = new AuthorEditViewModel()
                {
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    DateOfBirth = author.DateOfBirth,
                    Details = author.Details,
                };

                return View(vm);
            }

            // Yazar bilgilerini güncellemek için kullanılan POST yöntemi
            [HttpPost]
            public IActionResult Edit(AuthorEditViewModel vm)
            {
                Author? author = AData.Authors.FirstOrDefault(a => a.Id == vm.Id);

                if (author == null)
                    return NotFound();

                if (ModelState.IsValid) // Model doğrulama başarılıysa
                {
                    author.FirstName = vm.FirstName;
                    author.LastName = vm.LastName;
                    author.DateOfBirth = vm.DateOfBirth;
                    author.Details = vm.Details;

                    return RedirectToAction("Index"); // Yazarlar listesine yönlendir
                }

                return View(vm); 
            }

            // Silme işlemi öncesinde onay formunu görüntülemek için kullanılan yöntem
            public IActionResult DeleteConfirmation(int id)
            {
                Author? author = AData.Authors.FirstOrDefault(a => a.Id == id);

                if (author == null)
                {
                    return NotFound();
                }

                // Yazarın kitaplarını kontrol et
                var authorBooks = Data.Books.Any(b => b.AuthorId == id);
                if (authorBooks)
                {
                    TempData["ErrorMessage"] = "Cannot delete author with existing books!";
                    return RedirectToAction("Index");
                }

                return View(author);
            }

            // Yazar silme işlemini gerçekleştiren yöntem
            [HttpPost]
            public IActionResult Delete(int id)
            {
                Author? author = AData.Authors.FirstOrDefault(a => a.Id == id);

                if (author == null)
                {
                    return NotFound();
                }

                // Yazarın kitaplarını tekrar kontrol et
                var authorBooks = Data.Books.Any(b => b.AuthorId == id);
                if (authorBooks)
                {
                    TempData["ErrorMessage"] = "Cannot delete author with existing books!";
                    return RedirectToAction("Index");
                }

                AData.Authors.Remove(author);
                return RedirectToAction("Index");
            }

            // Yazar detaylarını görüntülemek için kullanılan yöntem
            public IActionResult Details(int id)
            {
                Author? author = AData.Authors.FirstOrDefault(a => a.Id == id);

                if (author == null)
                    return NotFound();

                var authorBooks = Data.Books.Where(b => b.AuthorId == id).ToList(); // Yazara ait kitapları bul

                AuthorDetailsViewModel vm = new AuthorDetailsViewModel()
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    DateOfBirth = author.DateOfBirth,
                    Books = authorBooks,
                    Details = author.Details,

                };

                return View(vm); // Yazar detaylarını döndür
            }
        }
    }

