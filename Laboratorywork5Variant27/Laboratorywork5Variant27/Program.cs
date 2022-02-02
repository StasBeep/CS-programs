using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorywork5Variant27
{
    class Program
    {
        static void Main(string[] args)
        {
            // подключение класса branching (branching() - конструктор)
            // Obj - переменная обращения к классу branching
            // с помощью неё происходит запрос к public данным
            branching Obj = new branching();

            // запрос входных данных
            Console.WriteLine("Введите с: ");
            Obj.c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            Obj.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x: ");
            Obj.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите z: ");
            Obj.z = Convert.ToDouble(Console.ReadLine());

            // вычисление результата через метод systemSolution
            Obj.l = Obj.systemSolution(Obj.c, Obj.y, Obj.x, Obj.z);

            // очистка консоли
            Console.Clear();

            // вывод результата на консоль
            Console.WriteLine("При с = " + Obj.c + " при y = " + Obj.y + " при x = " + Obj.x + " при z =" + Obj.z);
            Console.WriteLine("Система принимает результат: " + Obj.l);

            // задержка
            Console.ReadLine();
        }
    }
}
