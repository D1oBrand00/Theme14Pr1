using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme14Pr1
{
    /// <summary>
    /// Нестатический класс описания точки
    /// </summary>
    class Point
    {
        /// <summary>
        /// Внутреннее поле координаты x точки
        /// </summary>
        double x;
        /// <summary>
        /// Внутреннее поле координаты y точки
        /// </summary>
        double y;
        /// <summary>
        /// Поле счётчика
        /// </summary>
        public static int count;
        /// <summary>
        /// Статический конструктор Point(), который инициализирует статическую переменную count нулевым значением;
        /// </summary>
        static Point()
        {
            count = 0;
        }
        /// <summary>
        /// Нестатический конструктор Point(double, double) с двумя параметрами, которые инициализируют одноименные внутренние поля класса;
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            count++;
        }
        /// <summary>
        /// Нестатический конструктор Point() без параметров, который инициализирует внутренние поля класса значением 1.0
        /// </summary>
        public Point() 
        {
            this.x = 1.0;
            this.y = 1.0;
            count++;
        }
        /// <summary>
        /// Методы доступа к внутренним переменным x, y с именами GetX(), GetY(), SetX(), SetY();
        /// </summary>
        /// <returns></returns>
        public double GetX()
        { return x; }
        public void SetX(double x)
        {
            this.x = x;
        }
        public double GetY()
        { return y; }
        public void SetY(double y)
        {
            this.y = y;
        }
        public void Print()
        { Console.WriteLine($"x = {x}\ty = {y}"); }
        /// <summary>
        /// Статический метод LengthPoints() для вычисления расстояния между двумя точками. В качестве параметров метод должен получать экземпляры типа Point
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
 
        }

    }
}
