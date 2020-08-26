using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace AVAS___Air_vehicle_accounting_system
{
    [Serializable]
    class AirTransport
    {
        private int numberOfSeats;     // количество мест
        private int fuelReserve;       // запас топлива (л)
        private int maximumRange;      // максимальная дальность (км)
        private int maximumSpeed;      // максимальная скорость (км\час)
        private double weight;         // вес (т)
        private double enginePower;    // тяга двигателя (т)
        private double length;         // длина (м)
        private string name;           // название
        private string type;           // тип

        public virtual string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\AVAS_description.txt");
            string description = str.ReadToEnd();
            return description;
        }
        public virtual Image ShowImage()
        {
            Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\AVAS_image.png");
            return image;
        }
        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set { this.numberOfSeats = value; }
        }
        public int FuelReserve
        {
            get { return fuelReserve; }
            set { this.fuelReserve = value; }
        }
        public int MaximumRange
        {
            get { return maximumRange; }
            set { maximumRange = value; }
        }
        public int MaximumSpeed
        {
            get { return maximumSpeed; }
            set { maximumSpeed = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double EnginePower
        {
            get { return enginePower; }
            set { enginePower = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
