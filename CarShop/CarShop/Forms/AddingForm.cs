using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CarShop
{
    public partial class AddingForm : Form
    {
        public Car ThisCar { get; set; }

        public AddingForm(Car car)
        {
            InitializeComponent();

            ThisCar = car;

            MakeBox.Text = car.Make;
            ModelBox.Text = car.Model;
            EngineBox.Text = car.Engine;
            ColorBox.Text = car.Color;
        }

        public AddingForm()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (MakeBox.Text != "" && ModelBox.Text != "" && EngineBox.Text != "" && ColorBox.Text != "")
                SaveBtn.Enabled = true;
            else
                SaveBtn.Enabled = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var car = new Car(MakeBox.Text, ModelBox.Text, EngineBox.Text, ColorBox.Text);
            var rentedCar = new RentedCar(car);

            RentedCarDeserializer.Cars.Add(rentedCar);

            ResetBoxes();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ResetBoxes();
        }

        private void ResetBoxes()
        {
            MakeBox.Text = "";
            ModelBox.Text = "";
            EngineBox.Text = "";
            ColorBox.Text = "";
        }

        private void SerializeCars(object sender, FormClosedEventArgs e)
        {
            var serializer = new XmlSerializer(RentedCarDeserializer.Cars.GetType(), "Cars");

            using (var writer = new StreamWriter("cars.xml", false))
            {
                serializer.Serialize(writer.BaseStream, RentedCarDeserializer.Cars);
            }
        }
    }
}