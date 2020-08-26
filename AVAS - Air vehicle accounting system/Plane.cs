using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AVAS___Air_vehicle_accounting_system
{
    [Serializable]
    class Plane : AirTransport
    {
        public Plane()
        {
            Type = "Cамолёт";
        }
        public override string ShowDescription()
        {
            StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\Plane_description.txt");
            string description = str.ReadToEnd();
            return description;
        }
        public override Image ShowImage()
        {
            Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\Plane_image.jpg");
            return image;
        }
    }
    #region PassengerPlane

    [Serializable]
    class PassengerPlane : Plane
    {
        [Serializable]
        internal class PlaneBoeing747 : PassengerPlane
        {
            public PlaneBoeing747()
            {
                Name = "Boeing-747";
                NumberOfSeats = 821;
                Weight = 162.4;
                Length = 70.6;
                FuelReserve = 183380;
                MaximumRange = 9800;
                MaximumSpeed = 1030;
                EnginePower = 222.4;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\PassengerPlane\Boeing-747\Boeing747_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\PassengerPlane\Boeing-747\Boeing747_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class PlaneAirbusA320 : PassengerPlane
        {
            public PlaneAirbusA320()
            {
                Name = "Airbus-A320";
                NumberOfSeats = 132;
                Weight = 68.5;
                Length = 37.57;
                FuelReserve = 24210;
                MaximumRange = 6100;
                MaximumSpeed = 980;
                EnginePower = 210;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\PassengerPlane\Airbus-A320\AirbusA320_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\PassengerPlane\Airbus-A320\AirbusA320_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class PlaneBombardierCRJ : PassengerPlane
        {
            public PlaneBombardierCRJ()
            {
                Name = "Bombardier CRJ";
                NumberOfSeats = 78;
                Weight = 53.7;
                Length = 32.3;
                FuelReserve = 11728;
                MaximumRange = 2553;
                MaximumSpeed = 876;
                EnginePower = 242;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\PassengerPlane\Bombardier CRJ\BombardierCRJ_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\PassengerPlane\Bombardier CRJ\BombardierCRJ_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class PlaneFokker100 : PassengerPlane
        {
            public PlaneFokker100()
            {
                Name = "Fokker-100";
                NumberOfSeats = 119;
                Weight = 43.39;
                Length = 35.53;
                FuelReserve = 5135;
                MaximumRange = 3111;
                MaximumSpeed = 845;
                EnginePower = 161.6
;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\PassengerPlane\Fokker-100\Fokker100_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\PassengerPlane\Fokker-100\Fokker100_image.jpg");
                return image;
            }
        }
    }
    #endregion 

    #region TransportPlane
    [Serializable]
    class TransportPlane : Plane
    {
        [Serializable]
        internal class PlaneAn124 : TransportPlane
        {
            public PlaneAn124()
            {
                Name = "Ан-124";
                NumberOfSeats = 8;
                Weight = 178.4;
                Length = 69.1;
                FuelReserve = 212350;
                MaximumRange = 4800;
                MaximumSpeed = 865;
                EnginePower = 229.8;
                
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\TransportPlane\Ан-124\Aн124_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\TransportPlane\Ан-124\Ан124_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class PlaneBaslerBT67 : TransportPlane
        {
            public PlaneBaslerBT67()
            {
                Name = "Basler BT-67";
                NumberOfSeats = 40;
                Weight = 7.1;
                Length = 20.62;
                FuelReserve = 2790;
                MaximumRange = 1760;
                MaximumSpeed = 398;
                EnginePower = 2094.73;

            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\TransportPlane\Basler BT-67\BaslerBT67_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\TransportPlane\Basler BT-67\BaslerBT67_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class PlaneBoeingC17 : TransportPlane
        {
            public PlaneBoeingC17()
            {
                Name = "Boeing C-17";
                NumberOfSeats = 3;
                Weight = 122;
                Length = 53.04;
                FuelReserve = 134556;
                MaximumRange = 8710;
                MaximumSpeed = 833;
                EnginePower = 742;

            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\TransportPlane\Boeing C-17\BoeingC17_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\TransportPlane\Boeing C-17\BoeingC17_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class PlaneAn74 : TransportPlane
        {
            public PlaneAn74()
            {
                Name = "Ан-74";
                NumberOfSeats = 60;
                Weight = 122;
                Length = 30;
                FuelReserve = 98625;
                MaximumRange = 1230;
                MaximumSpeed = 650;
                EnginePower = 127.5;

            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\TransportPlane\Ан-74\Ан74_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\TransportPlane\Ан-74\Ан74_image.jpg");
                return image;
            }
        }
    }
    #endregion

    #region CargoPassengerPlane
    [Serializable]
    class CargoPassengerPlane : Plane
    {
        [Serializable]
        internal class PlaneCessna208 : CargoPassengerPlane
        {
            public PlaneCessna208()
            {
                Name = "Cessna-208";
                NumberOfSeats = 15;
                Weight = 12.8;
                Length = 12.67;
                FuelReserve = 1485;
                MaximumRange = 1797;
                MaximumSpeed = 352;
                EnginePower = 503;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\CargoPassengerPlane\Cessna-208\Cessna208_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\CargoPassengerPlane\Cessna-208\Cessna208_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class PlaneAn22 : CargoPassengerPlane
        {
            public PlaneAn22()
            {
                Name = "Ан-22";
                NumberOfSeats = 290;
                Weight = 118.7;
                Length = 57.31;
                FuelReserve = 120500;
                MaximumRange = 5225;
                MaximumSpeed = 650;
                EnginePower = 44908;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\CargoPassengerPlane\Ан-22\An22_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\CargoPassengerPlane\Ан-22\An22_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class PlaneShort330 : CargoPassengerPlane
        {
            public PlaneShort330()
            {
                Name = "Short-330";
                NumberOfSeats = 30;
                Weight = 10.3;
                Length = 17.96;
                FuelReserve = 2180;
                MaximumRange = 515;
                MaximumSpeed = 440;
                EnginePower = 1765.23;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\CargoPassengerPlane\Short-330\Short330_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\CargoPassengerPlane\Short-330\Short330_image.jpg");
                return image;
            }
        }
        [Serializable]
        internal class PlaneAn140 : CargoPassengerPlane
        {
            public PlaneAn140()
            {
                Name = "Ан-140";
                NumberOfSeats = 52;
                Weight = 12.8;
                Length = 22.6;
                FuelReserve = 5600;
                MaximumRange = 3700;
                MaximumSpeed = 540;
                EnginePower = 4118.86;
            }
            public override string ShowDescription()
            {
                StreamReader str = new StreamReader(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\CargoPassengerPlane\Ан-140\An140_description.txt");
                string description = str.ReadToEnd();
                return description;
            }
            public override Image ShowImage()
            {
                Image image = Image.FromFile(@"C:\Users\Artyr\source\repos\AVAS - Air vehicle accounting system\AVAS - Air vehicle accounting system\Resources\Description\Plane\CargoPassengerPlane\Ан-140\An140_image.jpg");
                return image;
            }
        }
    }
    #endregion
}
