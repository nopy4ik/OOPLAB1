using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB1
{
    internal class Angle
    {
        private int degrees = 0;
        private int minutes = 0;
        public int Degrees
        {
            get
            {
                return degrees;
            }
            set
            {
                degrees = value;
            }
        }
        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                minutes = value;
                while (minutes > 60)
                {
                    minutes -= 60;
                    degrees++;
                }
                while (minutes < 0)
                {
                    minutes += 60;
                    degrees--;
                }
            }
        }

        public Angle(int deg, int min)
        {
            this.degrees = deg;
            this.minutes = min;
            while (minutes > 60)
            {
                minutes -= 60;
                degrees++;
            }
            while (minutes < 0)
            {
                minutes += 60;
                degrees--;
            }
        }
        //перевести в радианы
        public double ToRadians()
        {
            return (degrees * Math.PI / 180 + minutes * Math.PI / 10800);
        }
        //нормализовать угл
        public void NormalizeAngle()
        {
            while (degrees > 360)
            {
                degrees -= 360;
            }
            while (degrees < 0)
            {
                degrees += 360;
            }
        }
        //добавить угл по градусу и углу
        public void AddAngle(int deg, int min)
        {
            degrees += deg;
            minutes += min;
            while (minutes > 60)
            {
                minutes -= 60;
                degrees++;
            }
            while (minutes < 0)
            {
                minutes += 60;
                degrees--;
            }
            ToRadians();
        }
        //получить синус
        public double GetSinus()
        {
            return Math.Sin(ToRadians());
        }
        //Сравнить два угла
        /// <summary>
        /// сравнивает два угла
        /// </summary>
        /// <returns> 1 если 1й больше, -1 если 2й больше, если равны 0</returns>
        public static int Compare(Angle a1, Angle a2)
        {
            if (a1.degrees > a2.degrees) return 1;
            if (a1.degrees < a2.degrees) return -1;
            if (a1.minutes > a2.minutes) return 1;
            if (a1.minutes < a2.minutes) return -1;
            return 0;
        }
    }
}
