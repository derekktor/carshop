using System.Collections.Generic;
using CarShop.Properties;

namespace CarShop
{
    public static class MakeBuilder
    {
        public static readonly List<Make> Makes = new List<Make>();

        static MakeBuilder()
        {
            Makes.Add(new Make("Tesla", new[]
            {
                new Make.Model("Model S", new []
                    {
                        "Dual Motor",
                        "Tri Motor"
                    },
                    new[]
                    {
                        new Make.Model.Color("Red", Resources.tS_red),
                        new Make.Model.Color("Black", Resources.tS_black),
                        new Make.Model.Color("White", Resources.tS_white)
                    }),

                new Make.Model("Model 3", new []
                    {
                        "Long Range",
                        "Performance"
                    },
                    new[]
                    {
                        new Make.Model.Color("Red", Resources.t3_red),
                        new Make.Model.Color("Black", Resources.t3_black),
                        new Make.Model.Color("White", Resources.t3_white)
                    }),

                new Make.Model("Model X", new []
                    {
                        "Dual Motor",
                        "Tri Motor"
                    },
                    new[]
                    {
                        new Make.Model.Color("Red", Resources.tX_red),
                        new Make.Model.Color("Black", Resources.tX_black),
                        new Make.Model.Color("White", Resources.tX_white)
                    }),

            }));

            Makes.Add(new Make("Audi", new[]
            {
                new Make.Model("S4", new []
                    {
                        "FWD S Tronic",
                        "quattro S Tronic"
                    },
                    new[]
                    {
                        new Make.Model.Color("Blue", Resources.aS4_blue),
                        new Make.Model.Color("Black", Resources.aS4_black),
                        new Make.Model.Color("White", Resources.aS4_white)
                    }),
                new Make.Model("A8",new []
                    {
                        "FWD S Tronic",
                        "quattro S Tronic"
                    },
                    new[]
                    {
                        new Make.Model.Color("Blue", Resources.aA8_blue),
                        new Make.Model.Color("Black", Resources.aA8_black),
                        new Make.Model.Color("White", Resources.aA8_white)
                    }),
                new Make.Model("A3", new []
                    {
                        "FWD S Tronic",
                        "quattro S Tronic"
                    },
                    new[]
                    {
                        new Make.Model.Color("Blue", Resources.aA3_blue),
                        new Make.Model.Color("Black", Resources.aA3_black),
                        new Make.Model.Color("White", Resources.aA3_white)
                    }),
            }));

            Makes.Add(new Make("Mercedes Benz", new[]
            {
                new Make.Model("S500", new []
                    {
                        "3.0L inline-6 turbo",
                        "4.0L V8 biturbo"
                    },
                    new[]
                    {
                        new Make.Model.Color("Blue", Resources.benzS_blue),
                        new Make.Model.Color("Black", Resources.benzS_black),
                        new Make.Model.Color("White", Resources.benzS_white)
                    }),
                new Make.Model("E350", new []
                    {
                        "2.0L inline-4 turbo",
                        "3.0L inline-6 turbo"
                    },
                    new[]
                    {
                        new Make.Model.Color("Blue", Resources.benzE_blue),
                        new Make.Model.Color("Black", Resources.benzE_black),
                        new Make.Model.Color("White", Resources.benzE_white)
                    }),
                new Make.Model("C300", new []
                    {
                        "2.0L inline-4 turbo"
                    },
                    new[]
                    {
                        new Make.Model.Color("Blue", Resources.benzC_blue),
                        new Make.Model.Color("Black", Resources.benzC_black),
                        new Make.Model.Color("White", Resources.benzC_white)
                    }),
            }));
        }

    }
}