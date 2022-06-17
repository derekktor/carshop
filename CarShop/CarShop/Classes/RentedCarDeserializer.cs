using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CarShop
{
    public static class RentedCarDeserializer
    {
        public static List<RentedCar> Cars { set; get; }

        static RentedCarDeserializer()
        {
            Cars = new List<RentedCar>();
            
            var serializer = new XmlSerializer(Cars.GetType(), "Cars");

            object deserializedCars;

            try
            {
                using (var reader = new StreamReader("cars.xml"))
                {
                    deserializedCars = serializer.Deserialize(reader.BaseStream);
                }

                Cars = (List<RentedCar>) deserializedCars;
            }
            catch (FileNotFoundException) { }
        }
    }
}