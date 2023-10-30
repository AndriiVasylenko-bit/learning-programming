using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Test
{
    public class Bike
    {
        public string _name { get; set; }
        public double _cost { get; set; }
        public double _installment { get; set; }
        public double _diameterWheels { get; set; }
        public string _sleeveStyle { get; set; }
        public string _plugType { get; set; }
        public string _materialFrame { get; set; }
        public string _typeBrakes { get; set; }

        public int NumberPayments()
        {
            if (_installment > 0)
                return Convert.ToInt32(Math.Round(_cost / _installment));
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
            _name = name;
            _cost = cost;
            _installment = installment;
            _diameterWheels = diameterWheels;
            _sleeveStyle = sleeveStyle;
            _plugType = plugType;
            _materialFrame = materialFrame;
            _typeBrakes = typeBrakes;
        }
    }
}
