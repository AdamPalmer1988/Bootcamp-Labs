using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLabs
{
    internal class Circle
    {
        //Properties
        private double Radius { get; set; }

        //Constructor

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        //Methods

        public double CalculateDiameter()
        {
            double diameter = 2 * Radius;
            return diameter;
        }

        public double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }

        public double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public void Grow()
        {
            Radius = Radius * 2;
            double diameter = CalculateDiameter();
            double circumference = CalculateCircumference();
            double area = CalculateArea();
        }

        public double GetRadius()
        {
            return Radius;
        }
    }
}
