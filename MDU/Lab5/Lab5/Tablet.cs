using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Tablet
    {
        public string _name { get; set; }
        public double _cost { get; set; }
        public double _installment { get; set; }
        public double _size { get; set; }
        public string _processor { get; set; }
        public bool _faceID { get; set; }
        public string _сamera { get; set; }
        public string _connecteur { get; set; }

        public int NumberPayments()
        {
            if (_cost > 0 && _installment > 0 && _cost >= _installment)
                return Convert.ToInt32(Math.Round(_cost / _installment));
            else
                return 0;
        }
    }
}
