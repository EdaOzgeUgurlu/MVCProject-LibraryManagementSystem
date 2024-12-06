using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCProject_LibraryManagementSystem.Models;
using MVCProject_LibraryManagementSystem.Models.Data;
using MVCProject_LibraryManagementSystem.Models.ViewModels.BookViewModels;

namespace MVCProject_LibraryManagementSystem.Controllers
{
         public class BooksController : Controller
        {
            // Kitapların listesini görüntülemek için kullanılan yöntem
            public IActionResult Index()
            {
                // Veri kaynağındaki kitapların bir listesini almak için LINQ kullanılıyor.
                var books = Data.Books.Select(book => new Book
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,

                    // Yazar adını ve soyadını almak için Authors listesinden uygun yazarı bul
                    AuthorName = AData.Authors
                        .FirstOrDefault(a => a.Id == book.AuthorId)?.FirstName + " " +
                                 AData.Authors.FirstOrDefault(a => a.Id == book.AuthorId)?.LastName,

                    Genre = book.Genre,
                    PublishDate = book.PublishDate,
                    ISBN = book.ISBN,
                    CopiesAvailable = book.CopiesAvailable
                }).ToList(); // Tüm kitapları listeye dönüştür.

                // Elde edilen kitap listesini View'e (görünüme) gönder.
                return View(books);
            }

            // Yeni kitap ekleme formunu görüntülemek için kullanılan GET yöntemi
            [HttpGet]
            public IActionResult New()
            {
                // Yazar listesini ViewBag üzerinden görünüme aktar
                ViewBag.Authors = new SelectList(AData.Authors.Select(a => new
                {
                    Id = a.Id,
                    FullName = $"{a.FirstName} {a.LastName}"
                }), "Id", "FullName");

                return View();
            }

            // Yeni kitap ekleme işlemi için kullanılan POST yöntemi
            [HttpPost]
            public IActionResult New(NewBookViewModel book)
            {
                if (ModelState.IsValid)
                {

                    Book New = new Book
                    {
                        Id = Data.Books.Max(b => b.Id) + 1, // Yeni bir ID belirle
                        Title = book.Title,
                        AuthorId = book.AuthorId,
                        Genre = book.Genre,
                        PublishDate = book.PublishDate,
                        ISBN = book.ISBN,
                        CopiesAvailable = book.CopiesAvailable,
                        Details = book.Details,
                    };
                    Data.Books.Add(New); // Kitabı listeye ekle
                    return RedirectToAction("Index"); // Kitap listesine yönlendir
                }

                ViewBag.Authors = new SelectList(AData.Authors.Select(a => new
                {
                    Id = a.Id,
                    FullName = $"{a.FirstName} {a.LastName}"
                }), "Id", "FullName");

                return View();
            }

            // Kitap düzenleme formunu görüntülemek için kullanılan GET yöntemi
            public IActionResult Edit(int id)
            {
                Book? book = Data.Books.FirstOrDefault(b => b.Id == id); // İlgili kitabı bul

                if (book == null)
                    return NotFound(); // Kitap bulunamazsa 404 döndür

                // Düzenleme formu için ViewModel oluştur
                BookEditViewModel vm = new BookEditViewModel()
                {
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    Genre = book.Genre,
                    PublishDate = book.PublishDate,
                    ISBN = book.ISBN,
                    CopiesAvailable = book.CopiesAvailable,
                    Details = book.Details,
                };

                // Yazar listesini ViewBag üzerinden görünüme aktar
                ViewBag.Authors = new SelectList(AData.Authors.Select(a => new
                {
                    Id = a.Id,
                    FullName = $"{a.FirstName} {a.LastName}"
                }), "Id", "FullName");

                return View(vm);
            }

            // Kitap bilgilerini güncellemek için kullanılan POST yöntemi
            [HttpPost]
            public IActionResult Edit(BookEditViewModel vm)
            {
                Book? book = Data.Books.FirstOrDefault(b => b.Id == vm.Id);

                if (book == null)
                    return NotFound();

                if (ModelState.IsValid) // Model doğrulama başarılıysa
                {
                    // Kitap bilgilerini güncelle
                    book.Title = vm.Title;
                    book.Genre = vm.Genre;
                    book.AuthorId = vm.AuthorId;
                    book.PublishDate = vm.PublishDate;
                    book.ISBN = vm.ISBN;
                    book.CopiesAvailable = vm.CopiesAvailable;
                    book.Details = vm.Details;

                    return RedirectToAction("Index");
                }


                ViewBag.Authors = new SelectList(AData.Authors.Select(a => new
                {
                    Id = a.Id,
                    FullName = $"{a.FirstName} {a.LastName}"
                }), "Id", "FullName");

                return View(vm);
            }

            // Silme işlemi öncesinde onay formunu görüntülemek için kullanılan yöntem
            public IActionResult DeleteConfirmation(int id)
            {
                Book? book = Data.Books.FirstOrDefault(b => b.Id == id); // İlgili kitabı bul

                if (book == null)
                {
                    return NotFound();
                }

                return View(book);
            }

            // Kitap silme işlemini gerçekleştiren yöntem
            [HttpPost]
            public IActionResult Delete(int id)
            {
                Book? book = Data.Books.FirstOrDefault(b => b.Id == id);

                if (book == null)
                {
                    return NotFound();
                }
                Data.Books.Remove(book);
                return RedirectToAction("Index");
            }

            // Kitap detaylarını görüntülemek için kullanılan yöntem
            public IActionResult Details(int id)
            {
                Book? book = Data.Books.FirstOrDefault(b => b.Id == id);

                if (book == null)
                    return NotFound();

                // Kitap detayları için ViewModel oluştur
                BookDetailsViewModel vm = new BookDetailsViewModel()
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    FullName = AData.Authors.FirstOrDefault(a => a.Id == book.AuthorId)?.FirstName + " " +
                               AData.Authors.FirstOrDefault(a => a.Id == book.AuthorId)?.LastName, // Yazarın tam adı
                    Genre = book.Genre,
                    PublishDate = book.PublishDate,
                    ISBN = book.ISBN,
                    CopiesAvailable = book.CopiesAvailable,
                    Details = book.Details,
                };

                return View(vm); // Kitap detaylarını döndür
            }
        }
    }
