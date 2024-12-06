namespace MVCProject_LibraryManagementSystem.Models.Data
{
    //static bir class oluşturuyoruz
    //verileri static bir listede tutuyoruz
    public static class Data
    {
        //Book sınıfında Books adında liste oluşturuyoruz
        public static List<Book> Books { get; set; } = new()
        {
            new Book { Id = 1, Title = "Anna Karenina", AuthorId = 1, Genre = "Roman", PublishDate = new DateTime(1877, 4, 1), ISBN = "978-350", CopiesAvailable = 10, Details = "Anna Karenina, Lev Tolstoy'un en bilinen eserlerinden biridir ve Rus aristokrasisinin yaşamını, aşkı, sadakati ve toplumsal baskıları derinlemesine işler." },
            new Book { Id = 2, Title = "Savaş ve Barış", AuthorId = 1, Genre = "Roman", PublishDate = new DateTime(1869, 1, 1), ISBN = "978-351", CopiesAvailable = 8, Details = "Savaş ve Barış, Lev Tolstoy'un en önemli eserlerinden biridir ve Rus toplumunun Napolyon savaşları sırasında yaşadığı değişimi ve toplumsal sınıflar arasındaki ilişkileri anlatır." },
            new Book { Id = 3, Title = "Madame Bovary", AuthorId = 2, Genre = "Roman", PublishDate = new DateTime(1857, 12, 1), ISBN = "978-352", CopiesAvailable = 12, Details = "Madame Bovary, Gustave Flaubert'in en bilinen eseridir. Eser, Fransız taşra yaşamını ve Emma Bovary'nin hayal kırıklıklarıyla dolu yaşamını anlatır." },
            new Book { Id = 4, Title = "Suç ve Ceza", AuthorId = 3, Genre = "Roman", PublishDate = new DateTime(1866, 1, 1), ISBN = "978-353", CopiesAvailable = 15, Details = "Suç ve Ceza, Fyodor Dostoyevski'nin en önemli eserlerinden biri olup, bir suçlunun vicdan azabı ve insan doğasına dair derinlemesine analizler sunar." },
            new Book { Id = 5, Title = "İnsancıklar", AuthorId = 3, Genre = "Roman", PublishDate = new DateTime(1846, 1, 15), ISBN = "978-354", CopiesAvailable = 5, Details = "İnsancıklar, Dostoyevski'nin ilk büyük romanıdır ve toplumun alt sınıflarındaki insanların zorluklarını konu alır." },
            new Book { Id = 6, Title = "Don Quixote", AuthorId = 4, Genre = "Macera", PublishDate = new DateTime(1605, 1, 16), ISBN = "978-355", CopiesAvailable = 7, Details = "Don Quixote, Miguel de Cervantes'in başyapıtıdır ve modern romanın doğuşunu simgeler. Eser, hayalleri ve gerçekleri arasındaki çatışmayı işler." },
            new Book { Id = 7, Title = "Monte Cristo Kontu", AuthorId = 5, Genre = "Macera", PublishDate = new DateTime(1844, 8, 28), ISBN = "978-356", CopiesAvailable = 6, Details = "Monte Cristo Kontu, Alexandre Dumas'ın en ünlü eseridir ve intikam, ihanet ve adalet temalarını işler." },
            new Book { Id = 8, Title = "Jane Eyre", AuthorId = 6, Genre = "Roman", PublishDate = new DateTime(1847, 10, 16), ISBN = "978-357", CopiesAvailable = 8, Details = "Jane Eyre, Charlotte Brontë'nin yazdığı, kadın özgürlüğü ve eşitlik mücadelesini konu alan bir başyapıttır." },
            new Book { Id = 9, Title = "Gurur ve Önyargı", AuthorId = 7, Genre = "Roman", PublishDate = new DateTime(1813, 1, 28), ISBN = "978-358", CopiesAvailable = 10, Details = "Gurur ve Önyargı, Jane Austen'in en sevilen eseridir. Roman, evlilik ve sosyal sınıf meseleleri etrafında döner." },
            new Book { Id = 10, Title = "Karamazov Kardeşler", AuthorId = 3, Genre = "Roman", PublishDate = new DateTime(1880, 11, 1), ISBN = "978-359", CopiesAvailable = 4, Details = "Karamazov Kardeşler, Dostoyevski'nin en karmaşık romanıdır ve inanç, ahlaki sorumluluk ve aile bağları üzerine derinlemesine bir inceleme sunar." },
            new Book { Id = 11, Title = "Notre Dame'ın Kamburu", AuthorId = 8, Genre = "Roman", PublishDate = new DateTime(1831, 3, 16), ISBN = "978-360", CopiesAvailable = 9, Details = "Notre Dame'ın Kamburu, Victor Hugo'nun ünlü eseri olup, insanlık, sevgi ve toplumsal dışlanmışlık üzerine önemli mesajlar verir." },
            new Book { Id = 12, Title = "Denizler Altında Yirmi Bin Fersah", AuthorId = 9, Genre = "Bilimkurgu", PublishDate = new DateTime(1870, 6, 20), ISBN = "978-361", CopiesAvailable = 6, Details = "Denizler Altında Yirmi Bin Fersah, Jules Verne'in yazdığı bir bilim kurgu klasiğidir ve denizaltı maceralarını anlatır." },
            new Book { Id = 13, Title = "Dracula", AuthorId = 10, Genre = "Korku", PublishDate = new DateTime(1897, 5, 26), ISBN = "978-362", CopiesAvailable = 7, Details = "Dracula, Bram Stoker'ın yazdığı bir korku romanıdır ve vampir mitolojisini popülerleştiren önemli bir eserdir." },
            new Book { Id = 14, Title = "Dorian Gray'in Portresi", AuthorId = 11, Genre = "Roman", PublishDate = new DateTime(1890, 7, 20), ISBN = "978-363", CopiesAvailable = 8, Details = "Dorian Gray'in Portresi, Oscar Wilde'ın eseridir ve estetik değerler, vicdan ve insan doğası üzerine derin felsefi sorular sorar." },
            new Book { Id = 15, Title = "Uğultulu Tepeler", AuthorId = 6, Genre = "Roman", PublishDate = new DateTime(1847, 12, 1), ISBN = "978-364", CopiesAvailable = 5, Details = "Uğultulu Tepeler, Charlotte Brontë'nin ablası Emily Brontë tarafından yazılan ve tutku, intikam ve ölüm üzerine kurulu bir romandır." },
            new Book { Id = 16, Title = "Oliver Twist", AuthorId = 12, Genre = "Roman", PublishDate = new DateTime(1838, 2, 1), ISBN = "978-365", CopiesAvailable = 6, Details = "Oliver Twist, Charles Dickens'in önemli eserlerinden biridir ve yoksulluk, çocuk hakları ve adaletsizlik üzerine bir hikaye anlatır." },
            new Book { Id = 17, Title = "Beyaz Diş", AuthorId = 13, Genre = "Macera", PublishDate = new DateTime(1906, 5, 1), ISBN = "978-366", CopiesAvailable = 10, Details = "Beyaz Diş, Jack London'un ünlü eserlerinden biridir ve doğa ile insan arasındaki ilişkiyi keşfeder." },
            new Book { Id = 18, Title = "Robinson Crusoe", AuthorId = 16, Genre = "Macera", PublishDate = new DateTime(1719, 4, 25), ISBN = "978-367", CopiesAvailable = 7, Details = "Robinson Crusoe, Daniel Defoe'nun yazdığı ve bir adamın ıssız bir adada hayatta kalma mücadelesini anlatan macera romanıdır." },
            new Book { Id = 19, Title = "Bülbülü Öldürmek", AuthorId = 14, Genre = "Roman", PublishDate = new DateTime(1960, 7, 11), ISBN = "978-368", CopiesAvailable = 12, Details = "Bülbülü Öldürmek, Harper Lee'nin Pulitzer ödüllü eseridir ve ırkçılık ve adalet temalarını işler." },
            new Book { Id = 20, Title = "1984", AuthorId = 15, Genre = "Distopya", PublishDate = new DateTime(1949, 6, 8), ISBN = "978-369", CopiesAvailable = 11, Details = "1984, George Orwell'in distopik romanıdır ve totaliter rejimler, özgürlük ve bireysel haklar üzerine bir uyarıdır." }



        };

    }
}
