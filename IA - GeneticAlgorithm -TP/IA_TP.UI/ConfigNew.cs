using IA_TP.Model;
using System;
using System.Collections.Generic;

namespace IA_TP.UI
{
    public static class Config
    {
        public static TelcoSur GetBaseConfig()
        {
            TelcoSur telcoSur = new TelcoSur();
            telcoSur.Cities = BuildBaseCities();
            telcoSur.Catalogue = BuildBaseCatalogue();
            telcoSur.FiberChannelKmsAvailable = 250;
            telcoSur.Income = 0;
            return telcoSur;
        }

        private static Catalogue BuildBaseCatalogue()
        {
            return new Catalogue
            {
                Phone_Price = 100,
                Internet_Price = 95,
                TV_Price = 110
            };
        }

        private static IList<Model.City> BuildBaseCities()
        {
            //X <= 1000
            //Y <= 400
            return new List<Model.City>
            {
                new Model.City
                {
                    Latitude = 200, Longitude = 200, Name = "Nodo Central",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 205, Longitude = 270, Name = "Localidad A",
                    Demand = new UserDemand {Internet = 2400, Phone= 2000, TV = 1500 }
                },
                new Model.City
                {
                    Latitude = 118, Longitude = 300, Name = "Localidad B",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 },
                },
                new Model.City
                {
                    Latitude = 191, Longitude = 172, Name = "Localidad C",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 98, Longitude = 218, Name = "Localidad D",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                },
                new Model.City
                {
                    Latitude = 208, Longitude = 153, Name = "Localidad E",
                    Demand = new UserDemand {Internet = 5000, Phone= 600, TV = 500 }
                }
            };
        }
    }
}
