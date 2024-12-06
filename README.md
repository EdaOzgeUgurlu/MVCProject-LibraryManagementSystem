# K�t�phane Y�netim Sistemi

## Proje Hakk�nda
Bu proje, kitap ve yazarlar�n y�netimini sa�layan basit bir ASP.NET Core MVC uygulamas�d�r. Sistem, kitaplar�n ve yazarlar�n eklenmesi, d�zenlenmesi, silinmesi ve g�r�nt�lenmesi i�lemlerini ger�ekle�tirebilmektedir.

## �zellikler
- Kitap y�netimi (CRUD i�lemleri)
- Yazar y�netimi (CRUD i�lemleri)
- Yazarlara ait kitaplar�n listelenmesi
- Responsive tasar�m
- Bootstrap ile modern aray�z

## Proje Yap�s�

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

### Veri Y�netimi
Proje �u an i�in veritaban� kullanmamaktad�r. Veriler statik s�n�flarda tutulmaktad�r:

- **Data.cs**: Kitap verilerini tutan statik s�n�f
- **AData.cs**: Yazar verilerini tutan statik s�n�f

### Kontrolc�ler
- **BooksController**: Kitap i�lemlerini y�neten kontrolc�
- **AuthorsController**: Yazar i�lemlerini y�neten kontrolc�
- **HomeController**: Ana sayfa ve genel g�r�n�mleri y�neten kontrolc�

## G�r�n�mler (Views)

### Kitap G�r�n�mleri
- Index: T�m kitaplar�n listelendi�i sayfa
- New: Yeni kitap ekleme formu
- Edit: Kitap d�zenleme formu
- Details: Kitap detaylar�
- DeleteConfirmation: Silme onay�

### Yazar G�r�n�mleri
- Index: T�m yazarlar�n listelendi�i sayfa
- NewAuthor: Yeni yazar ekleme formu
- Edit: Yazar d�zenleme formu
- Details: Yazar detaylar� ve kitaplar�
- DeleteConfirmation: Silme onay�

## Stil ve Tasar�m
Proje Bootstrap framework'� kullanmaktad�r. �zel CSS tan�mlamalar� `site.css` dosyas�nda bulunmaktad�r:


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


## Kurulum ve �al��t�rma

1. Projeyi klonlay�n
2. Visual Studio ile projeyi a��n
3. Projeyi derleyin ve �al��t�r�n

## Test Etme

### Kitap ��lemleri Testi
1. Ana sayfadan "Books" butonuna t�klay�n
2. Yeni kitap eklemek i�in "New Book" butonunu kullan�n
3. Mevcut kitaplar� d�zenlemek i�in "Edit" butonunu kullan�n
4. Kitap detaylar�n� g�r�nt�lemek i�in "Details" butonunu kullan�n
5. Kitap silmek i�in "Delete" butonunu kullan�n

### Yazar ��lemleri Testi
1. Ana sayfadan "Authors" butonuna t�klay�n
2. Yeni yazar eklemek i�in "New Author" butonunu kullan�n
3. Mevcut yazarlar� d�zenlemek i�in "Edit" butonunu kullan�n
4. Yazar detaylar�n� ve kitaplar�n� g�r�nt�lemek i�in "Details" butonunu kullan�n
5. Yazar silmek i�in "Delete" butonunu kullan�n

## Geli�tirici Notlar�
- Proje .NET 8.0 kullan�larak geli�tirilmi�tir
- Veritaban� entegrasyonu ileriki s�r�mlerde eklenecektir
- Validation kontrolleri her form i�in eklenmi�tir
- Responsive tasar�m t�m cihazlarda �al��acak �ekilde yap�land�r�lm��t�r

## Footer Bilgisi

```1:7:MVCProject/Views/Shared/_FooterPartial.cshtml
<footer class="border-top footer bg-dark text-light py-3">
    <div class="container text-center">
        <i class="bi bi-book me-2"></i>
        &copy; 2024 - Eda �zge U�urlu T�m Haklar� Sakl�d�r.
    </div>
</footer>

```


## Lisans
T�m haklar� sakl�d�r � 2024 - Eda �zge U�urlu
