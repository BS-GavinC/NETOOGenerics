using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETOOGenerics
{
    public class Voiture
    {
        public Voiture(string color)
        {
            Color = color;
        }

        public string Color { get; set; }

        public bool IsColor(string color)
        {
            return Color == color;
        }

    }
}
