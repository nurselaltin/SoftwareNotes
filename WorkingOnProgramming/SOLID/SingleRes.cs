namespace WorkingOnProgramming.SOLID
{
    //Tanım: Bir sınıfın / modülün sadece tek bir sorumluluğu olmasıdır.Sınıf sadece veri tutmaya, ve bir sınıf sadece veritabanı bağlantısı yapmalıdır.
    //Uymuyor
    public class Book1
    {
        //Kitap Bilgilerini Tut
        private string title;

        //Kitap Bilgilerini yazdır
        public void PrintBooks()
        {
            Console.WriteLine("Title: " + title);
        }

        //Kitap Bilgilerini Kayıt et
        public void SaveToDatabase()
        {

        }
    }

    //Uyan Kısım
    public class Book
    {
        public string title { get; set; }

        public string GetTitle()
        {
            return title;
        }
    }
    public class BookPrinter
    {
        public void PrintBook(Book book)
        {
            Console.WriteLine("Title: " + book.GetTitle());
        }
    }
    public class BookRepository
    {
        public void SaveToDatabase(Book book)
        {

        }
    }
}
