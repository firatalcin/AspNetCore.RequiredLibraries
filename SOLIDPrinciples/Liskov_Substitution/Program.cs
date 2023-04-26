public interface ITakePhoto
{
    void TakePhoto();
}

public abstract class BasePhone
{
    public void Call()
    {
        Console.WriteLine("Arama yapıldı");
    }
}

public class IPhone : BasePhone, ITakePhoto
{
    public void TakePhoto()
    {
        Console.WriteLine("Fotoğraf Çekildi");
    }
}

public class Nokia3310 : BasePhone
{

}

public class Program
{
    public static void Main()
    {
        IPhone phone1 = new IPhone();
        phone1.Call();
        phone1.TakePhoto();
        Nokia3310 phone2 = new Nokia3310();
        phone2.Call();
        
    }
}
