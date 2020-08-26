using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace AVAS___Air_vehicle_accounting_system
{
    [Serializable]
    class Helicopter : AirTransport
    {
        public Helicopter()
        {
            Type = "Вертолёт";
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\Helicopter_description.txt");
            string description = str.ReadToEnd();
            return description;
        }
        public override Image ShowImage()
        {
            Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\Helicopter_image.jpg");
            return image;
        }
    }

    #region PassengerHelicopter

    [Serializable]
    class PassengerHelicopter : Helicopter
    {
        [Serializable]
        internal class HelicopterS92 : PassengerHelicopter
        {
            public HelicopterS92()
            {
                Name = "S-92";
                NumberOfSeats = 24;
                Weight = 7;
                Length = 20.88;
                FuelReserve = 2877;
                MaximumRange = 1007;
                MaximumSpeed = 305;
                EnginePower = 3758;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\PassengerHelicopter\S-92\S92_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\PassengerHelicopter\S-92\S92_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class HelicopterBell525 : PassengerHelicopter
        {
            public HelicopterBell525()
            {
                Name = "Bell-525";
                NumberOfSeats = 20;
                Weight = 5.4;
                Length = 16.42;
                FuelReserve = 2340;
                MaximumRange = 926;
                MaximumSpeed = 306;
                EnginePower = 2647.84;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\PassengerHelicopter\Bell-525\Bell525_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\PassengerHelicopter\Bell-525\Bell525_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class HelicopterPanhaSorena : PassengerHelicopter
        {
            public HelicopterPanhaSorena()
            {
                Name = "Panha Sorena";
                NumberOfSeats = 3;
                Weight = 0.68;
                Length = 7.68;
                FuelReserve = 525;
                MaximumRange = 420;
                MaximumSpeed = 205;
                EnginePower = 220.65;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\PassengerHelicopter\Panha Sorena\PanhaSorena_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\PassengerHelicopter\Panha Sorena\PanhaSorena_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class HelicopterAvicopterAC3X2 : PassengerHelicopter
        {
            public HelicopterAvicopterAC3X2()
            {
                Name = "Avicopter AC3X2";
                NumberOfSeats = 8;
                Weight = 1.7;
                Length = 9.28;
                FuelReserve = 840;
                MaximumRange = 650;
                MaximumSpeed = 300;
                EnginePower = 1206.24;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\PassengerHelicopter\Avicopter AC3X2\AvicopterAC3X2_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\PassengerHelicopter\Avicopter AC3X2\AvicopterAC3X2_image.jpg");
                return image;
            }
        }
    }
    #endregion

    #region TransportHelicopter
    [Serializable]
    class TransportHelicopter : Helicopter
    {
        [Serializable]
        internal class HelicopterMi171 : TransportHelicopter
        {
            public HelicopterMi171()
            {
                Name = "Ми-171";
                NumberOfSeats = 2;
                Weight = 6.8;
                Length = 18.17;
                FuelReserve = 900;
                MaximumRange = 610;
                MaximumSpeed = 250;
                EnginePower = 3280;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\TransportHelicopter\Ми-171\Mi171_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\TransportHelicopter\Ми-171\Mi171_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class HelicopterKa31 : TransportHelicopter
        {
            public HelicopterKa31()
            {
                Name = "Ка-31";
                NumberOfSeats = 6;
                Weight = 5.5;
                Length = 11.60;
                FuelReserve = 1100;
                MaximumRange = 680;
                MaximumSpeed = 255;
                EnginePower = 3320;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\TransportHelicopter\Ка-31\Ka31_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\TransportHelicopter\Ка-31\Ka31_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class HelicopterKa226 : TransportHelicopter
        {
            public HelicopterKa226()
            {
                Name = "Ка-226";
                NumberOfSeats = 2;
                Weight = 3.1;
                Length = 8.10;
                FuelReserve = 650;
                MaximumRange = 600;
                MaximumSpeed = 220;
                EnginePower = 676;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\TransportHelicopter\Ка-226\Ka226_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\TransportHelicopter\Ка-226\Ka226_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class HelicopterKa226T : TransportHelicopter
        {
            public HelicopterKa226T()
            {
                Name = "Ка-226T";
                NumberOfSeats = 0;
                Weight = 3.1;
                Length = 8.10;
                FuelReserve = 600;
                MaximumRange = 600;
                MaximumSpeed = 210;
                EnginePower = 660;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\TransportHelicopter\Ка-226Т\Ka226T_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\TransportHelicopter\Ка-226Т\Ka226T_image.jpg");
                return image;
            }
        }
    }
    #endregion

    #region CargoPassengerHelicopter
    [Serializable]
    class CargoPassengerHelicopter : Helicopter
    {
        [Serializable]
        internal class HelicopterBK117 : CargoPassengerHelicopter
        {
            public HelicopterBK117()
            {
                Name = "BK-117";
                NumberOfSeats = 9;
                Weight = 1.8;
                Length = 13.01;
                FuelReserve = 685;
                MaximumRange = 540;
                MaximumSpeed = 277;
                EnginePower = 1100;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\CargoPassengerHelicopter\BK-117\BK117_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\CargoPassengerHelicopter\BK-117\BK117_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class HelicopterAvicopterAC313 : CargoPassengerHelicopter
        {
            public HelicopterAvicopterAC313()
            {
                Name = "Avicopter AC313";
                NumberOfSeats = 27;
                Weight = 6.7;
                Length = 24;
                FuelReserve = 960;
                MaximumRange = 1050;
                MaximumSpeed = 220;
                EnginePower = 2691.97;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\CargoPassengerHelicopter\Avicopter AC313\AvicopterAC313_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\CargoPassengerHelicopter\Avicopter AC313\AvicopterAC313_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class HelicopterAirbusH175 : CargoPassengerHelicopter
        {
            public HelicopterAirbusH175()
            {
                Name = "Airbus H175";
                NumberOfSeats = 18;
                Weight = 4.6;
                Length = 18.06;
                FuelReserve = 1130;
                MaximumRange = 1260;
                MaximumSpeed = 315;
                EnginePower = 2611;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\CargoPassengerHelicopter\Airbus H175\AirbusH175_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\CargoPassengerHelicopter\Airbus H175\AirbusH175_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class HelicopterAerospatialeSA360 : CargoPassengerHelicopter
        {
            public HelicopterAerospatialeSA360()
            {
                Name = "Aerospatiale SA360";
                NumberOfSeats = 8;
                Weight = 1.6;
                Length = 13.2;
                FuelReserve = 530;
                MaximumRange = 675;
                MaximumSpeed = 315;
                EnginePower = 772.29;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\CargoPassengerHelicopter\Aerospatiale SA360\AerospatialeSA360_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Helicopter\CargoPassengerHelicopter\Aerospatiale SA360\AerospatialeSA360_image.jpg");
                return image;
            }
        }
    }
    #endregion
}
