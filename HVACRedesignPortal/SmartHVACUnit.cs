namespace HVACProject
{
    // Inherits from HVACUnit, Implements IDiagnosable
    public class SmartHVACUnit : HVACUnit, IDiagnosable
    {
        public bool IsWifiEnabled { get; set; }

        // Passes base parameters up, handles the new Wifi parameter
        public SmartHVACUnit(string brand, string modelNumber, string systemType, double tonnage, double seerRating, bool isWifiEnabled)
            : base(brand, modelNumber, systemType, tonnage, seerRating)
        {
            IsWifiEnabled = isWifiEnabled;
        }

        // Fulfills the IDiagnosable interface
        public string RunSystemDiagnostics()
        {
            return $"Initiating diagnostics on {Brand} {ModelNumber}... Network Status: {(IsWifiEnabled ? "Connected" : "Offline")}. All systems nominal.";
        }
    }
}

