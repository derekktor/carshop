using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Serialization;

namespace CarShop
{
    [Serializable]
    public class RentedCar
    {
        public Car ThisCar { get; set; }
        public List<Reservation> Reservations { get; set; }

        public RentedCar() { }
        public RentedCar(Car car)
        {
            ThisCar = car;
            Reservations = new List<Reservation>();
        }

        public override string ToString() => $"{ThisCar}";


        [Serializable]
        public class Reservation
        {
            public DateTime Date { get; set; }
            public Renter ThisRenter { get; set; }

            public Reservation() { }

            public Reservation(DateTime date, Renter renter)
            {
                Date = date;
                ThisRenter = renter;
            }
        }
    }
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }

        public Car() { }

        public Car(string make, string model, string engine, string color)
        {
            Make = make;
            Model = model;
            Engine = engine;
            Color = color;
        }

        public override string ToString() => $"{Make}/{Model}/{Engine}/{Color}";
    }

    public class Renter
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public Renter() { }

        public Renter(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }

        public override string ToString() => $"{FName}/{LName}";
    }
}