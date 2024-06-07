using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingOnProgramming.DesignPattern.Structural
{
  //Sistemimiz bazen her gereksinimi karşılayamıyor.Bunun için 3.part bir uygulama ihtiyacımız oluyor.
  //İşte bu farklı bir bileşeni var olana uyumlandırmak istediğimizde bu deseni kullanıyoruz.

  //Problem:Pos cihazından gelen veriyi okumak üzere bir uygulama yazdığımızı düşünelim.
  public class XBankPosReader
  {
    public string ReadFromCard()
    {
      return "X bank Pos cihazı çalışıyor.";
    }
  }

  //Adaptör arayüz : Tüm pos cihazları burayla çalışacak
   public interface ICardReaderAdapter
   {
    public string ReadCardData();
   }

  public class XBankCardReaderAdapter : ICardReaderAdapter
  {
    public string ReadCardData()
    {
       XBankPosReader posReader = new XBankPosReader();
       return posReader.ReadFromCard();
    }
  }

}
