using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CarShop
{
    public class Make
    {
        public string MakeName { get; }
        public Model[] Models { get; }

        public Make(string name, Model[] models)
        {
            MakeName = name;
            Models = models;
        }

        public override string ToString() => MakeName;

        public class Model
        {
            public string ModelName { get; }
            public string[] Engines { get; }
            public Color[] Colors { get; }
            public Model(string name, string[] engines, Color[] colors)
            {
                ModelName = name;
                Engines = engines;
                Colors = colors;
            }

            public override string ToString() => ModelName;


            public class Color
            {
                public string ColorName { get; }
                public Image Img { get; }
                
                public Color(string color, Image img)
                {
                    ColorName = color;
                    Img = img;
                }
                public override string ToString() => ColorName;

            }
            
        }
    }
}