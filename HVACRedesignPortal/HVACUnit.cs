namespace HVACProject
{
    public class HVACUnit
    {
        public string Brand { get; set; }
        public string ModelNumber { get; set; }
        public string SystemType { get; set; }
        public double Tonnage { get; set; }
        public double SeerRating { get; set; }

        // Parameterized constructor to match your Week 1 Program.cs style
        public HVACUnit(string brand, string modelNumber, string systemType, double tonnage, double seerRating)
        {
            Brand = brand;
            ModelNumber = modelNumber;
            SystemType = systemType;
            Tonnage = tonnage;
            SeerRating = seerRating;
        }

        public double CalculateBtuCapacity()
        {
            return Tonnage * 12000;
        }

        public string EvaluateEfficiencyTier()
        {
            if (SeerRating >= 18) return "High Efficiency (Premium)";
            if (SeerRating >= 16) return "Standard Efficiency";
            return "Base Efficiency";
        }
    }
}