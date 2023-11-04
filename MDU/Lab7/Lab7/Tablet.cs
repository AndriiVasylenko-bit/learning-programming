namespace Lab7
{
    public class Tablet
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Installment { get; set; }
        public double Size { get; set; }
        public string Processor { get; set; }
        public bool FaceID { get; set; }
        public string Camera { get; set; }
        public string Connecteur { get; set; }
        public int NumberPayments()
        {
            if (Cost > 0 && Installment > 0 && Cost >= Installment)
                return Convert.ToInt32(Math.Round(Cost / Installment));
            else
                return 0;
        }
        public Tablet()
        {
        }
        public Tablet(string name, double cost, double installment,
        double size, string processor, bool faceID,
        string camera, string connecteur)
        {
            Name = name;
            Cost = cost;
            Installment = installment;
            Size = size;
            Processor = processor;
            FaceID = faceID;
            Camera = camera;
            Connecteur = connecteur;
        }
    }
}
