//Створити об'єкт класу Одяг, використовуючи клас Куртка, Сорочка, Штани, Взуття. Методи: одягатись, вибирати різні види одягу. + Хеш код
using LL4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Вибір одягу:\n" +
            "1 - Сорочка\n" +
            "2 - Куртка\n" +
            "3 - Штани\n" +
            "4 - Взуття");
        int ch = int.Parse(Console.ReadLine());
        Cloth cloth = new();
        cloth.Dress(ch);
    }
}