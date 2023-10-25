namespace ClassLibrary1
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

        public int numberPayments
        {
            get
            {
                return GetNumberPayments();
            }
        }

        private int GetNumberPayments()
        {
            return Convert.ToInt32(Math.Round(_cost / _installment));
        }
    }
}