using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVAS___Air_vehicle_accounting_system
{
    public partial class Form1 : Form
    {
        List<AirTransport> airTransports = new List<AirTransport>();
        static internal AirTransport airTransport = new AirTransport(); // gjghfdbnm 
        Plane plane = new Plane();
        Helicopter helicopter = new Helicopter();
        bool buttonOrListBox;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = airTransport.ShowDescription();
            pictureBox1.Image = airTransport.ShowImage();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = plane.ShowDescription();
                pictureBox1.Image = plane.ShowImage();

                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new string[] {"Пассажирский самолёт", "Транспортный самолёт", "Грузо-пассажирский самолёт" });
                comboBox2.Text = "Тип самолёта";

                AddToTheList_button.Enabled = false;

                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;

                ClearTextBoxes();

            }
            else
            {
                textBox1.Text = helicopter.ShowDescription();
                pictureBox1.Image = helicopter.ShowImage();

                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new string[] { "Пассажирский вертолёт", "Транспортный вертолёт", "Грузо-пассажирский вертолёт" });
                comboBox2.Text = "Тип вертолёта";

                AddToTheList_button.Enabled = false;

                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;

                ClearTextBoxes();
            }

        }
        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Пассажирский самолёт")
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;

                AddToTheList_button.Enabled = false;
                ClearTextBoxes();
            }
            if (comboBox2.Text == "Транспортный самолёт")
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;

                AddToTheList_button.Enabled = false;
                ClearTextBoxes();
            }
            if (comboBox2.Text == "Грузо-пассажирский самолёт")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;

                AddToTheList_button.Enabled = false;
                ClearTextBoxes();
            }
            if (comboBox2.Text == "Пассажирский вертолёт")
            {
                panel4.Visible = true;
                panel5.Visible = false;
                panel6.Visible = false;

                AddToTheList_button.Enabled = false;
                ClearTextBoxes();
            }
            if (comboBox2.Text == "Транспортный вертолёт")
            {
                panel4.Visible = false;
                panel5.Visible = true;
                panel6.Visible = false;

                AddToTheList_button.Enabled = false;
                ClearTextBoxes();
            }
            if (comboBox2.Text == "Грузо-пассажирский вертолёт")
            {
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = true;

                AddToTheList_button.Enabled = false;
                ClearTextBoxes();
            }
        }


        #region  PassengerPlaneButtonClick
        private void Boeing747_button_Click(object sender, EventArgs e)
        {
            PassengerPlane.PlaneBoeing747 planeBoeing747 = new PassengerPlane.PlaneBoeing747();
            airTransport = planeBoeing747;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void AirbusA320_button_Click(object sender, EventArgs e)
        {
            PassengerPlane.PlaneAirbusA320 planeAirbusA320 = new PassengerPlane.PlaneAirbusA320();
            airTransport = planeAirbusA320;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void BombardierCRJ_button_Click(object sender, EventArgs e)
        {
            PassengerPlane.PlaneBombardierCRJ planeBombardierCRJ = new PassengerPlane.PlaneBombardierCRJ();
            airTransport = planeBombardierCRJ;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void Fokker100_button_Click(object sender, EventArgs e)
        {
            PassengerPlane.PlaneFokker100 planeFokker100 = new PassengerPlane.PlaneFokker100();
            airTransport = planeFokker100;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        #endregion

        #region TransportPlaneButtonClick
        private void An124_button_Click(object sender, EventArgs e)
        {
            TransportPlane.PlaneAn124 planeAn124 = new TransportPlane.PlaneAn124();
            airTransport = planeAn124;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        private void BaslerBT67_button_Click(object sender, EventArgs e)
        {
            TransportPlane.PlaneBaslerBT67 planeBaslerBT67 = new TransportPlane.PlaneBaslerBT67();
            airTransport = planeBaslerBT67;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        private void BoeingC17_button_Click(object sender, EventArgs e)
        {
            TransportPlane.PlaneBoeingC17 planeBoeingC17 = new TransportPlane.PlaneBoeingC17();
            airTransport = planeBoeingC17;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        private void An74_button_Click(object sender, EventArgs e)
        {
            TransportPlane.PlaneAn74 planeAn74 = new TransportPlane.PlaneAn74();
            airTransport = planeAn74;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        #endregion

        #region CargoPassengerPlaneButtonClick

        private void Cessna208_button_Click(object sender, EventArgs e)
        {
            CargoPassengerPlane.PlaneCessna208 planeCessna208 = new CargoPassengerPlane.PlaneCessna208();
            airTransport = planeCessna208;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        private void An22_button_Click(object sender, EventArgs e)
        {
            CargoPassengerPlane.PlaneAn22 planeAn22 = new CargoPassengerPlane.PlaneAn22();
            airTransport = planeAn22;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        private void Short330_button_Click(object sender, EventArgs e)
        {
            CargoPassengerPlane.PlaneShort330 planeShort330 = new CargoPassengerPlane.PlaneShort330();
            airTransport = planeShort330;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        private void An140_button_Click(object sender, EventArgs e)
        {
            CargoPassengerPlane.PlaneAn140 planeAn140 = new CargoPassengerPlane.PlaneAn140();
            airTransport = planeAn140;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        #endregion

        #region PassengerHelicopterButtonClick
        private void S92_button_Click(object sender, EventArgs e)
        {
            PassengerHelicopter.HelicopterS92 helicopterS92 = new PassengerHelicopter.HelicopterS92();
            airTransport = helicopterS92;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void Bell525_button_Click(object sender, EventArgs e)
        {
            PassengerHelicopter.HelicopterBell525 helicopterBell525 = new PassengerHelicopter.HelicopterBell525();
            airTransport = helicopterBell525;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void PanhaSorena_button_Click(object sender, EventArgs e)
        {
            PassengerHelicopter.HelicopterPanhaSorena helicopterPanhaSorena = new PassengerHelicopter.HelicopterPanhaSorena();
            airTransport = helicopterPanhaSorena;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void AvicopterAC3X2_button_Click(object sender, EventArgs e)
        {
            PassengerHelicopter.HelicopterAvicopterAC3X2 helicopterAvicopterAC3X2 = new PassengerHelicopter.HelicopterAvicopterAC3X2();
            airTransport = helicopterAvicopterAC3X2;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        #endregion

        #region TransportHelicopterButtonClick
        private void Mi171_button_Click(object sender, EventArgs e)
        {
            TransportHelicopter.HelicopterMi171 helicopterMi171 = new TransportHelicopter.HelicopterMi171();
            airTransport = helicopterMi171;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void Ka31_button_Click(object sender, EventArgs e)
        {
            TransportHelicopter.HelicopterKa31 helicopterKa31 = new TransportHelicopter.HelicopterKa31();
            airTransport = helicopterKa31;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void Ka226_button_Click(object sender, EventArgs e)
        {
            TransportHelicopter.HelicopterKa226 helicopterKa226 = new TransportHelicopter.HelicopterKa226();
            airTransport = helicopterKa226;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void Ka226T_button_Click(object sender, EventArgs e)
        {
            TransportHelicopter.HelicopterKa226T helicopterKa226T = new TransportHelicopter.HelicopterKa226T();
            airTransport = helicopterKa226T;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        #endregion

        #region CargoPassengerHelicopterButtonClick
        private void BK117_button_Click(object sender, EventArgs e)
        {
            CargoPassengerHelicopter.HelicopterBK117 helicopterBK117 = new CargoPassengerHelicopter.HelicopterBK117();
            airTransport = helicopterBK117;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void AvicopterAC313_button_Click(object sender, EventArgs e)
        {
            CargoPassengerHelicopter.HelicopterAvicopterAC313 helicopterAvicopterAC313 = new CargoPassengerHelicopter.HelicopterAvicopterAC313();
            airTransport = helicopterAvicopterAC313;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void AirbusH175_button_Click(object sender, EventArgs e)
        {
            CargoPassengerHelicopter.HelicopterAirbusH175 helicopterAirbusH175 = new CargoPassengerHelicopter.HelicopterAirbusH175();
            airTransport = helicopterAirbusH175;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void AerospatialeSA360_button_Click(object sender, EventArgs e)
        {
            CargoPassengerHelicopter.HelicopterAerospatialeSA360 helicopterAerospatialeSA360 = new CargoPassengerHelicopter.HelicopterAerospatialeSA360();
            airTransport = helicopterAerospatialeSA360;
            AddToTheList_button.Enabled = true;
            buttonOrListBox = true;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }
        #endregion

        private void listBox1_Click(object sender, EventArgs e)
        {
            buttonOrListBox = false;
            DisplayingInformationAboutAirTransport(buttonOrListBox);
        }

        private void AddToTheList_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            airTransports.Add(airTransport);
            foreach (AirTransport i in airTransports)
            {
                listBox1.Items.Add(i.Name);
            }

            RemoveFromList_button.Enabled = true;
        }

        private void RemoveFromList_button_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                try
                {
                    airTransports.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    if (listBox1.Items.Count == 0) 
                    {
                        RemoveFromList_button.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Чтобы удалить элемент, выберите его в списке и нажмите на кнопку 'Удалить из списка'");
                }
            }
            
        }

        private void SaveListToFile_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "BIN| *.bin";
            ofd.FileName = "airTransports.bin";
            ofd.ShowDialog();
            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, airTransports);
            }
        }

        private void LoadListFromFile_button_Click(object sender, EventArgs e)
        {
            var binFormatter = new BinaryFormatter();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BIN| *.bin";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream file = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                {

                    var newTools = binFormatter.Deserialize(file) as List<AirTransport>;
                    airTransports = newTools;
                    listBox1.Items.Clear();
                    foreach (AirTransport i in airTransports)
                    {
                        listBox1.Items.Add(i.Name);
                    }
                }
            }
            RemoveFromList_button.Enabled = true;
        }

        internal void DisplayingInformationAboutAirTransport(bool buttonOrListBox)
        {
            if (buttonOrListBox)
            {
                pictureBox1.Image = airTransport.ShowImage();
                textBox1.Text = airTransport.ShowDescription();
                textBox2.Text = airTransport.Name.ToString();
                textBox3.Text = airTransport.NumberOfSeats.ToString();
                textBox4.Text = airTransport.Weight.ToString();
                textBox5.Text = airTransport.Length.ToString();
                textBox6.Text = airTransport.FuelReserve.ToString();
                textBox7.Text = airTransport.MaximumRange.ToString();
                textBox8.Text = airTransport.MaximumSpeed.ToString();
                textBox9.Text = airTransport.EnginePower.ToString();
            }
            else
            {
                try
                {
                    pictureBox1.Image = airTransports[listBox1.SelectedIndex].ShowImage();
                    textBox1.Text = airTransports[listBox1.SelectedIndex].ShowDescription();
                    textBox2.Text = airTransports[listBox1.SelectedIndex].Name.ToString();
                    textBox3.Text = airTransports[listBox1.SelectedIndex].NumberOfSeats.ToString();
                    textBox4.Text = airTransports[listBox1.SelectedIndex].Weight.ToString();
                    textBox5.Text = airTransports[listBox1.SelectedIndex].Length.ToString();
                    textBox6.Text = airTransports[listBox1.SelectedIndex].FuelReserve.ToString();
                    textBox7.Text = airTransports[listBox1.SelectedIndex].MaximumRange.ToString();
                    textBox8.Text = airTransports[listBox1.SelectedIndex].MaximumSpeed.ToString();
                    textBox9.Text = airTransports[listBox1.SelectedIndex].EnginePower.ToString();
                }
                catch { }
            }
        }
        internal void ClearTextBoxes()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}
