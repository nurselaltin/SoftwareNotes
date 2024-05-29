
namespace WorkingOnProgramming.SOLID
{
    //Tanım; Türetilen bir alt sınıf , türetildiği sınıfın davranışını sergileyebilmelidir.
    //Uymayan Kısım
    public abstract class DataSource
    {
        public abstract string Read(string data);
        public abstract string Write(string data);
    }

    //XML verisi yazmayacağım.Yazma davranışı sergilememe gerek yok
    public class XMLDataSource : DataSource
    {
        public override string Read(string data)
        {
            Console.WriteLine("Data read from Xml");
            return string.Empty;
        }

        //Bunu kullanmayacağım
        public override string Write(string data)
        {
            throw new NotImplementedException();
        }
    }

    //Bu türetilen sınıf ise bu prensibe uyuyor
    public class DBDataSource : DataSource
    {
        public override string Read(string data)
        {
            Console.WriteLine("Data read from DB");
            return string.Empty;
        }

        public override string Write(string data)
        {
            Console.WriteLine("Data write from DB");
            return string.Empty;
        }
    }

    //İki sınıf için Read okumak serbest ancak write metodu farklı.O zaman abstract sınıfa sadece Read davranışını verelim.
    public abstract class DataSource2
    {
        public abstract string Read(string data);
    }

    public interface IDataWritable
    {
        void Write(string data);
    }

    public class XMLDataSource2 : DataSource2
    {
        public override string Read(string data)
        {
            Console.WriteLine("Data read from Xml");
            return string.Empty;
        }
    }

    public class DBDataSource2 : DataSource2, IDataWritable 
    {
        public override string Read(string data)
        {
            Console.WriteLine("Data read from DB");
            return string.Empty;
        }

        public void Write(string data)
        {
            Console.WriteLine("Data write from DB");
        }
    }
}
