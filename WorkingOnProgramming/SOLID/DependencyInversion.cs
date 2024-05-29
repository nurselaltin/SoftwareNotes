namespace WorkingOnProgramming.SOLID
{
    //Tanım: Yüksek seviyeli sınıf/modüller, düşük seviyeli modüllere bağlılığını soyut sınıfa yönlendirilmesidir.Her iki modül birbirne bağımlı olmak yerine soyut sınfa/modüle bağımlıdır.

    //Uymayan Kısım
    public class FileLogger
    {
        public void Log(string msg)
        {
            
        }
    }

    public class Application
    {
        private FileLogger logger = new FileLogger();
        void DoLog(string msg)
        {
            logger.Log(msg);
        }
    }

    //Uyan Kısım
    public interface ILogger
    {
        void Log(string msg);
    }

    //Alt sınıfta soyut sınıfa bağımlı hale geldi
    public class FileLogger2 : ILogger
    {
        public void Log(string msg)
        {
            
        }
    }

    //Alt sınıfta soyut sınıfa bağımlı hale geldi
    public class ConsoleLogger : ILogger
    {
        public void Log(string msg)
        {
          
        }
    }

    //Üst sınıf soyut sınıfa bağımlı hale geldi
    public class Application2 : ILogger
    {
        private ILogger logger;
        public void Log(string msg)
        {
            logger = new ConsoleLogger();
            logger.Log(msg);
        }
    }
}
