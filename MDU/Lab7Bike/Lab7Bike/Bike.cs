using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Bike
{
    public class Bike
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Installment { get; set; }
        public double DiameterWheels { get; set; }
        public string SleeveStyle { get; set; }
        public string PlugType { get; set; }
        public string MaterialFrame { get; set; }
        public string TypeBrakes { get; set; }

        public int NumberPayments()
        {
            if (Installment > 0)
                return Convert.ToInt32(Math.Round(Cost / Installment));
            else
                return 0;
        }
        public Bike()
        {
        }
        public Bike(string name, double cost, 
            double installment, double diameterWheels, string
            sleeveStyle, string plugType, string materialFrame,
            string typeBrakes)
        {
            Name = name;
            Cost = cost;
            Installment = installment;
            DiameterWheels = diameterWheels;
            SleeveStyle = sleeveStyle;
            PlugType = plugType;
            MaterialFrame = materialFrame;
            TypeBrakes = typeBrakes;
        }
    }
}
