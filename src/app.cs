using System;

namespace ConsoleApp
{
  class Program
  {
    public const double NUM_PI = 3.14; //обявление константы с значением Пи
    public class Shape // описание класса Shape
    {
      protected int _x, _y; // инициализация защищенных переменных(они досутпны только внутри класса)
      public Shape(int x, int y) //обявление и описание конструктора
      {
          _x = x; _y = y; // из параметров метода берем и присваеваем их свойствам класса Shape
          Console.WriteLine("Вызван конструктор класса Shape с параметрaми x = {0}, y = {1}", x, y); // вывод в консоль
      }
      public virtual int Area() {return 0;} // метод который можно переопределить
    }
    public class Circle : Shape // создание класса который наследутся от класса Shape
    {
      // описание метода Circle который наследуется от Shape
      public Circle(int rad) : base(rad, 0) 
      {
          Console.WriteLine("Вызван конструктор класса Circle с параметром rad = {0}", rad); // вывод в консоль
      }
      public override int Area() {return (int)(NUM_PI * _x * _x);} // переопределили виртуалный метод из родителького класса
    }
    public class Rect : Shape // создание класса который наследутся от класса Shape
    {
      //описание метода Rect который наследуется от Shape
      public Rect(int x, int y) : base(x, y) 
      {
          Console.WriteLine("Вызван конструктор класса Rect с параметрами x = {0}, y = {1}", x, y); //
      }
      public override int Area() {return _x * _y; } // переопределили виртуалный метод из родителького класса
    }

    static void Main(string[] args) // ну это и так понятно
    {
      int Num = 59018; // обявление переменной 
      Shape [] shapes = new Shape[8]; // создание экземпляров класса
      for (int i = 0; i < 8; i++) // цикл
      {
        if ( (i + Num) % (i / 2 + 3) == 0) shapes[i] = new Circle(i); // если условие верно то создается круг и присвается елементу массива
        else if (i < 6) shapes[i] = new Rect(i, i+2); // иначе если условие верно создается прямоуголник и присваеватся елементу массива 
        else shapes[i] = new Shape(i, i+3); // иначе создается фигура(форма) 
      }
      for(int i = 0; i < 8; i++) // <------ это цикл
        {
          Console.WriteLine("Class: {0,-8}, Area: {1,6}", shapes[i].
            GetType().Name, shapes[i].Area()); // просто форматированный вывод в консоль 
        }
        Console.ReadKey(); // удобство. Чисто для себя
    }
  }
}
