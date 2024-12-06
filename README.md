# Kütüphane Yönetim Sistemi

## Proje Hakkýnda
Bu proje, kitap ve yazarlarýn yönetimini saðlayan basit bir ASP.NET Core MVC uygulamasýdýr. Sistem, kitaplarýn ve yazarlarýn eklenmesi, düzenlenmesi, silinmesi ve görüntülenmesi iþlemlerini gerçekleþtirebilmektedir.

## Özellikler
- Kitap yönetimi (CRUD iþlemleri)
- Yazar yönetimi (CRUD iþlemleri)
- Yazarlara ait kitaplarýn listelenmesi
- Responsive tasarým
- Bootstrap ile modern arayüz

## Proje Yapýsý

### Modeller
- **Book**: Kitap bilgilerini tutan model

```1:13:MVCProject/Models/Book.cs
namespace MVCProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public int AuthorId { get; set; }
        public string Genre { get; set; } = "";
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; } = "";
        public int CopiesAvailable { get; set; }
    }
}
```


- **Author**: Yazar bilgilerini tutan model

```1:11:MVCProject/Models/Author.cs
namespace MVCProject.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateTime DateOfBirth { get; set; } 
    }
}

```


### View Modelleri
- BookDetailsViewModel
- BookEditViewModel
- NewBookViewModel
- AuthorDetailsViewModel
- AuthorEditViewModel
- NewAuthorViewModel

### Veri Yönetimi
Proje þu an için veritabaný kullanmamaktadýr. Veriler statik sýnýflarda tutulmaktadýr:

- **Data.cs**: Kitap verilerini tutan statik sýnýf
- **AData.cs**: Yazar verilerini tutan statik sýnýf

### Kontrolcüler
- **BooksController**: Kitap iþlemlerini yöneten kontrolcü
- **AuthorsController**: Yazar iþlemlerini yöneten kontrolcü
- **HomeController**: Ana sayfa ve genel görünümleri yöneten kontrolcü

## Görünümler (Views)

### Kitap Görünümleri
- Index: Tüm kitaplarýn listelendiði sayfa
- New: Yeni kitap ekleme formu
- Edit: Kitap düzenleme formu
- Details: Kitap detaylarý
- DeleteConfirmation: Silme onayý

### Yazar Görünümleri
- Index: Tüm yazarlarýn listelendiði sayfa
- NewAuthor: Yeni yazar ekleme formu
- Edit: Yazar düzenleme formu
- Details: Yazar detaylarý ve kitaplarý
- DeleteConfirmation: Silme onayý

## Stil ve Tasarým
Proje Bootstrap framework'ü kullanmaktadýr. Özel CSS tanýmlamalarý `site.css` dosyasýnda bulunmaktadýr:


```1:47:MVCProject/wwwroot/css/site.css
html {
  font-size: 14px;
}

@media (min-width: 768px) {
  html {
    font-size: 16px;
  }
}

.btn:focus, .btn:active:focus, .btn-link.nav-link:focus, .form-control:focus, .form-check-input:focus {
  box-shadow: 0 0 0 0.1rem white, 0 0 0 0.25rem #258cfb;
}

html {
  position: relative;
  min-height: 100%;
}

body {
  margin-bottom: 60px;
}

html, body {
    height: 100%;
    margin: 0;
    display: flex;
    flex-direction: column;
}

body {
    display: flex;
    flex-direction: column;
    min-height: 100vh;
}

.main-content {
    flex: 1;
}

.footer {
    position: relative;
    bottom: 0;
    width: 100%;
}

```


## Kurulum ve Çalýþtýrma

1. Projeyi klonlayýn
2. Visual Studio ile projeyi açýn
3. Projeyi derleyin ve çalýþtýrýn

## Test Etme

### Kitap Ýþlemleri Testi
1. Ana sayfadan "Books" butonuna týklayýn
2. Yeni kitap eklemek için "New Book" butonunu kullanýn
3. Mevcut kitaplarý düzenlemek için "Edit" butonunu kullanýn
4. Kitap detaylarýný görüntülemek için "Details" butonunu kullanýn
5. Kitap silmek için "Delete" butonunu kullanýn

### Yazar Ýþlemleri Testi
1. Ana sayfadan "Authors" butonuna týklayýn
2. Yeni yazar eklemek için "New Author" butonunu kullanýn
3. Mevcut yazarlarý düzenlemek için "Edit" butonunu kullanýn
4. Yazar detaylarýný ve kitaplarýný görüntülemek için "Details" butonunu kullanýn
5. Yazar silmek için "Delete" butonunu kullanýn

## Geliþtirici Notlarý
- Proje .NET 8.0 kullanýlarak geliþtirilmiþtir
- Veritabaný entegrasyonu ileriki sürümlerde eklenecektir
- Validation kontrolleri her form için eklenmiþtir
- Responsive tasarým tüm cihazlarda çalýþacak þekilde yapýlandýrýlmýþtýr

## Footer Bilgisi

```1:7:MVCProject/Views/Shared/_FooterPartial.cshtml
<footer class="border-top footer bg-dark text-light py-3">
    <div class="container text-center">
        <i class="bi bi-book me-2"></i>
        &copy; 2024 - Eda Özge Uðurlu Tüm Haklarý Saklýdýr.
    </div>
</footer>

```


## Lisans
Tüm haklarý saklýdýr © 2024 - Eda Özge Uðurlu
