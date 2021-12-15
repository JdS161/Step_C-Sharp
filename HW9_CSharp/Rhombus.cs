﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharp
{
    class Rhombus : Figure

    {
        public double Side { get; set; }
        public double Heigth { get; set; }


        public Rhombus()
        {
            Name = "EMPTY";
            Side = 0;
            Heigth = 0;
        }

        public Rhombus(string _name, double _side, double _heigth)
        {
            this.Name = _name;
            this.Side = _side;
            this.Heigth = _heigth;
        }

        public override double Perimeter()
        {
            return 4*Side;
        }

        public override double Area()
        {
            return Side*Heigth;
        }
    }
}