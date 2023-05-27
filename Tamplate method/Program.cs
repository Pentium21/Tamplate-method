using System;

// Создаем абстрактный класс Sandwich
public abstract class Sandwich
{
    // Метод MakeSandwich содержит шаблонный метод для создания сэндвича
    public void MakeSandwich()
    {
        CutBread();
        if (HasMeat())
        {
            AddMeat();
        }
        AddVegetables();
        AddCondiments();
        WrapSandwich();
    }

    // Метод для нарезки хлеба
    public void CutBread()
    {
        Console.WriteLine("Нарезаем хлеб.");
    }

    // Абстрактные методы, которые будут определены в дочерних классах
    public abstract bool HasMeat();
    public abstract void AddMeat();
    public abstract void AddVegetables();
    public abstract void AddCondiments();

    // Метод для заворачивания сэндвича
    public void WrapSandwich()
    {
        Console.WriteLine("Сендвич готов.");
    }
}

// Создаем подкласс MeatSandwich, который наследует от класса Sandwich
public class MeatSandwich : Sandwich
{
    // Реализация метода HasMeat для сэндвича с мясом
    public override bool HasMeat()
    {
        return true;
    }

    // Реализация метода AddMeat для сэндвича с мясом
    public override void AddMeat()
    {
        Console.WriteLine("Добавляем мясо.");
    }

    // Реализация метода AddVegetables для сэндвича с мясом
    public override void AddVegetables()
    {
        Console.WriteLine("Добавляем овощи.");
    }

    // Реализация метода AddCondiments для сэндвича с мясом
    public override void AddCondiments()
    {
        Console.WriteLine("Добавляем специи.");
    }
}

// Создаем подкласс VeggieSandwich, который наследует от класса Sandwich
public class VeggieSandwich : Sandwich
{
    // Реализация метода HasMeat для вегетарианского сэндвича
    public override bool HasMeat()
    {
        return false;
    }

    // Реализация метода AddMeat для вегетарианского сэндвича
    public override void AddMeat()
    {
        // Здесь ничего не делаем, так как это вегетарианский сэндвич
    }

    // Реализация метода AddVegetables для вегетарианского сэндвича
    public override void AddVegetables()
    {
        Console.WriteLine("Добавляем овощи.");
    }

    // Реализация метода AddCondiments для вегетарианского сэндвича
    public override void AddCondiments()
    {
        Console.WriteLine("Добавляем специи.");
    }
}

// Тестирование создания сэндвичей с помощью шаблонного метода
class Program
{
    static void Main(string[] args)
    {
        // Создание и приготовление сэндвича с мясом
        Console.WriteLine("Приготовление сендвича с мясом:");
        Sandwich meatSandwich = new MeatSandwich();
        meatSandwich.MakeSandwich();

        // Создание и приготовление вегетарианского сэндвича
        Console.WriteLine("\nПриготовление овощного сендвич:");
        Sandwich veggieSandwich = new VeggieSandwich();
        veggieSandwich.MakeSandwich();

        // Ожидание ввода, чтобы вывести результаты на экран
        Console.ReadKey();
    }
}