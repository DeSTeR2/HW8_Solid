using System;
using System.Diagnostics;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

interface IDiscountable
{
    void ApplyDiscount(string discount);
}

interface IPromocodable
{
    void ApplyPromocode(string promocode);
}

interface IColorable
{
    void SetColor(byte color);
}

interface ISizable
{
    void SetSize(byte size);
}

interface IPriceable
{
    void SetPrice(double price);
}

class Book : IDiscountable, IPriceable
{
    public double Price { get; private set; }
    public string Discount { get; private set; }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
        Console.WriteLine($"Applied discount: {discount}");
    }

    public void SetPrice(double price)
    {
        Price = price;
        Console.WriteLine($"Set price: {price}");
    }
}

class Outerwear : IColorable, ISizable, IDiscountable, IPriceable
{
    public byte Color { get; private set; }
    public byte Size { get; private set; }
    public double Price { get; private set; }
    public string Discount { get; private set; }

    public void SetColor(byte color)
    {
        Color = color;
        Console.WriteLine($"Set color: {color}");
    }

    public void SetSize(byte size)
    {
        Size = size;
        Console.WriteLine($"Set size: {size}");
    }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
        Console.WriteLine($"Applied discount: {discount}");
    }

    public void SetPrice(double price)
    {
        Price = price;
        Console.WriteLine($"Set price: {price}");
    }
}


class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}
// Interface Segregation Principle