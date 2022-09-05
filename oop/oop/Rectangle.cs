using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Rectangle
    {
        // Fields
        // private = kein Zugriff ausserhalb (Zugriffsmodifizierer)
        // Benennung von Fields: camelCase
        //private string          name;
        //private readonly int    width;
        //private readonly int    height;
        //private Color           color = Color.Black;


        // Properties
        // public props = PascalCase
        // Property mit BackingField
        // get; set; Autoproperties
        public string   Name { get; set; } = "Rectangle";
        public int      Width { get; } = 15;
        public int      Height { get; } = 10;
        public Color    Color { get; set; } = Color.Black;

        public int      Area { get { return Width * Height; } }






    }
}
