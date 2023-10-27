using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Bike
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
    }
}
