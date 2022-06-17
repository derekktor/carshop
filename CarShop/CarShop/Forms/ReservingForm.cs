using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CarShop
{
    public partial class ReservingForm : Form
    {
        public ReservingForm()
        {
            InitializeComponent();
            
            CarsBox.Items.AddRange(RentedCarDeserializer.Cars.ToArray());
            CarsBox.SelectedIndex = 0;

            ReserveBtn.Enabled = false;
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            var car = (RentedCar) CarsBox.SelectedItem;

            car.Reservations.Add(new RentedCar.Reservation(Calendar.SelectionStart, new Renter(FNameBox.Text, LNameBox.Text)));
            Calendar.AddBoldedDate(Calendar.SelectionStart);

            var tempDates = new List<DateTime>();
            tempDates.AddRange(Calendar.BoldedDates);
            tempDates.Add(Calendar.SelectionStart);
            Calendar.BoldedDates = tempDates.ToArray();

            FNameBox.Enabled = false;
            LNameBox.Enabled = false;
            ReserveBtn.Enabled = false;
        }

        private void CarsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var car = (RentedCar) CarsBox.SelectedItem;
            var dates = new List<DateTime>();

            car.Reservations.ForEach(reservation => dates.Add(reservation.Date));
            Calendar.BoldedDates = dates.ToArray();
            
            Calendar.Enabled = true;
            FNameBox.Enabled = true;
            LNameBox.Enabled = true;
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            var car = (RentedCar) CarsBox.SelectedItem;

            if (!Calendar.BoldedDates.Contains(Calendar.SelectionStart))
            {
                if (FNameBox.Text != "" && LNameBox.Text != "")
                {
                    ReserveBtn.Enabled = true;
                } else
                {
                    ReserveBtn.Enabled = false;
                }
                
                FNameBox.Enabled = true;
                LNameBox.Enabled = true;

                FNameBox.Text = "";
                LNameBox.Text = "";
            }
            else
            {
                ReserveBtn.Enabled = false;

                bool IsReservationFound(RentedCar.Reservation reservation)
                {
                    if (reservation.Date == null)
                        return false;
                    return reservation.Date == Calendar.SelectionStart;
                }

                FNameBox.Text = car.Reservations.Find(IsReservationFound).ThisRenter.FName;
                LNameBox.Text = car.Reservations.Find(IsReservationFound).ThisRenter.LName;

                FNameBox.Enabled = false;
                LNameBox.Enabled = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SerializeCars(object sender, FormClosedEventArgs e)
        {
            var serializer = new XmlSerializer(RentedCarDeserializer.Cars.GetType(), "Cars");

            using (var writer = new StreamWriter("cars.xml", false))
            {
                serializer.Serialize(writer.BaseStream, RentedCarDeserializer.Cars);
            }
        }

        private void NameBoxesChanged(object sender, EventArgs e)
        {
            if (!Calendar.BoldedDates.Contains(Calendar.SelectionStart) && FNameBox.Text != "" && LNameBox.Text != "")
            {
                ReserveBtn.Enabled = true;
            } else
            {
                ReserveBtn.Enabled = false;
            }
        }
    }
}