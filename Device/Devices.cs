using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    internal abstract class Devices
    {
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
    }

    internal class Microwave : Devices
    {
        public override void Sound()
        {
            Console.WriteLine("Бдыщ!!! Твоя раскаленная тарелка холодной еды готова!");
        }
        public override void Show()
        {
            Console.WriteLine("Greinacher");
        }
        public override void Desc()
        {
            Console.WriteLine("Подогревает вашу посуду");
        }
    }

    internal class Teapot : Devices
    {
        public override void Sound()
        {
            Console.WriteLine("Буль - буль");
        }
        public override void Show()
        {
            Console.WriteLine("Разогреватор 2000");
        }
        public override void Desc()
        {
            Console.WriteLine("нагревает воду до 100 градусов по цельсию");
        }
    }

    internal class Car : Devices
    {
        public override void Sound()
        {
            Console.WriteLine("Чых - пых");
        }
        public override void Show()
        {
            Console.WriteLine("Автомобиль!");
        }
        public override void Desc()
        {
            Console.WriteLine("Едет покуда бензин имеется");
        }
    }

    internal class Steamboat : Devices
    {
        public override void Sound()
        {
            Console.WriteLine("Бииииииии");
        }
        public override void Show()
        {
            Console.WriteLine("Победа");
        }
        public override void Desc()
        {
            Console.WriteLine("Средство для экскурсий по каналам");
        }
    }
}
