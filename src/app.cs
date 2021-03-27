using System;

namespace ConsoleApp
{
  class Program
  {
    public const double NUM_PI = 3.14;
    public class Shape
    {
      protected int _x, _y;
      public Shape(int x, int y)
      {
          _x = x; _y = y;
          Console.WriteLine("Вызван конструктор класса Shape с параметрaми x = {0}, y = {1}", x, y);
      }
      public virtual int Area() {return 0;}
    }
    public class Circle : Shape
    {
      public Circle(int rad) : base(rad, 0)
      {
          Console.WriteLine("Вызван конструктор класса Circle с параметром rad = {0}", rad);
      }
      public override int Area() {return (int)(NUM_PI * _x * _x);}
    }
    public class Rect : Shape
    {
      public Rect(int x, int y) : base(x, y)
      {
          Console.WriteLine("Вызван конструктор класса Rect с параметрами x = {0}, y = {1}", x, y);
      }
      public override int Area() {return _x * _y; }
    }

    static void Main(string[] args)
    {
      int Num = 59018;
      Shape [] shapes = new Shape[8];
      for (int i = 0; i < 8; i++)
      {
        if ( (i + Num) % (i / 2 + 3) == 0) shapes[i] = new Circle(i);
        else if (i < 6) shapes[i] = new Rect(i, i+2);
        else shapes[i] = new Shape(i, i+3);
      }
      for(int i = 0; i < 8; i++)
        {
          Console.WriteLine("Class: {0,-8}, Area: {1,6}", shapes[i].
            GetType().Name, shapes[i].Area());
        }
        //Console.ReadKey();
    }
  }
}
