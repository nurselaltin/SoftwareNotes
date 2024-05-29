
namespace WorkingOnProgramming.SOLID
{
    //Tanım: Bir arayüzü çok fazla davranış verilmemeli, minimum ve öz davranışlar atanmalı

    //Uymayan kısım
    public interface IMultiFunctionPrinter
    {
        void Print(Document doc);
        void Scan(Document doc);
        void Fax(Document doc);
    }

    public class Document
    {

    }

    //Bu yazıcı sadece yazma yapacak
    public class OldFashionedPrinter : IMultiFunctionPrinter
    {
        public void Fax(Document doc)
        {
            throw new NotImplementedException();
        }

        public void Print(Document doc)
        {
           Console.WriteLine("Printing document");
        }

        public void Scan(Document doc)
        {
            throw new NotImplementedException();
        }
    }

    //Uyan Kısım 

    public interface IPrint
    {
        void Print(Document doc);
    }

    public interface IScan
    {
        void Scan(Document doc);
    }

    public interface IFax
    {
        void Fax(Document doc);
    }

    public class SimplePirnter : IPrint
    {
        public void Print(Document doc)
        {
            Console.WriteLine("Printing document");
        }
    }

    public class MultiFuunctionPrinter : IPrint, IFax, IScan
    {
        public void Fax(Document doc)
        {
            Console.WriteLine("Sending document");
        }

        public void Print(Document doc)
        {
            Console.WriteLine("Printing document");
        }

        public void Scan(Document doc)
        {
            Console.WriteLine("Scanning document");
        }
    }
}
