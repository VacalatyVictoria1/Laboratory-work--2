using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2а_с_шарп
{
    /*Даная программа находит: 
     1)площадь и длину окружности
     2)обьем и площадь круглого прямого цилиндра
    */
    class Circle
    {
        protected double radius;
        public Circle()
        {
            radius = 0;
        }
        public Circle(double rd)
        {
            radius = rd;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public virtual string Info()
        {
            return string.Format("Circle: ");
        }
        public virtual double Square()
        {
            return radius * radius * Math.Round(Math.PI, 2);
        }
        public virtual double Lenght()
        {
            return 2 * radius * Math.Round(Math.PI, 2);
        }
    };
    class Cylinder : Circle
    {
        protected double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Cylinder(double radius, double height)
        {
            base.Radius = radius;
            Height = height;
        }
        public override string Info()
        {
            return string.Format("Cylinder: ");
        }
        public double Square1()
        {
            //return base.Square() * 2 + 2 * radius * height * Math.Round(Math.PI, 2);
            double Square1 = Math.Round(Math.PI, 2) * 2 * radius * radius + 2 * radius * height * Math.Round(Math.PI, 2);
            return Square1;
        }
        public double Volume()
        {
            //return base.Square() * height;
            double Volume = Math.Round(Math.PI, 2) * height * radius * radius;
            return Volume;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 2;
            double radius;
            for (int i = 0; i < N; i++)
            {

                Console.WriteLine("Введите длину радиуса окружности: ");
                radius = Convert.ToDouble(Console.ReadLine());
                Circle cr = new Circle(radius);

                Console.WriteLine(cr.Info());
                Console.WriteLine("Square {0} ", cr.Square());
                Console.WriteLine("Lenght {0} ", cr.Lenght());
                Console.WriteLine();
            }

            const int M = 3;
            double height;
            for (int j = 0; j < M; j++)
            {
                Console.WriteLine("Введите длину радиуса окружности цилиндра: ");
                radius = Convert.ToDouble(Console.ReadLine());
                Circle cr = new Circle(radius);

                Console.WriteLine("Введите длину высоты цилиндра: ");
                height = Convert.ToDouble(Console.ReadLine());
                Cylinder cl = new Cylinder(radius, height);

                Console.WriteLine(cl.Info());
                Console.WriteLine("Square {0} ", cl.Square1());
                Console.WriteLine("Volume {0} ", cl.Volume());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

}
