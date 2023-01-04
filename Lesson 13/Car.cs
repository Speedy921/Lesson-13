using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class Car
    {
        //автоматичекие свойства
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string  Color { get; set; }

        //свойство только для записи
        public int MyReadOnlyProp { get; }

        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}
