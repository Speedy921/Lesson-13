using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class Garage
    {
        //скрытое поддеживающее поле int установлено в 1
        public int NumberofCars { get; set; } = 1;

        //Скрытое поддерживающее поле Car установлено в новый обьект car
        public Car MyAuto { get; set; } = new Car();

        //для переопределения стандартных значений присвоенных скрытым
        //поддерживающим полям должны исп конструкторы
        public Garage() { }

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberofCars = number;
        }
    }
}
